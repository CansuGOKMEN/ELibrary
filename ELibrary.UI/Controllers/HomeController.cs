using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ELibrary.Core.Components;
using ELibrary.Core.Model;
using ELibrary.Core.Repositories;
using ELibrary.Core.Repositories.Base;
using ELibrary.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ELibrary.UI.Controllers
{
    public class HomeController : Controller
    {
        private IWeekRepositoy weekendRepository;
        private IHolidayRepository holidayRepository;
        private ICurrencyRepository currencyRepository;
        public HomeController(IWeekRepositoy weekendRepository, IHolidayRepository holidayRepository, ICurrencyRepository currencyRepository)
        {
            this.weekendRepository = weekendRepository;
            this.holidayRepository = holidayRepository;
            this.currencyRepository = currencyRepository;
        }

        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("index")]
        [ValidateAntiForgeryToken]
        public IActionResult Index(FormValue model)
        {
            if (model == null)
                throw new Exception();

            DateTime checkOutDate = DateTime.Parse(model.StartDate);
            DateTime returnDate = DateTime.Parse(model.EndDate);
            int countryId = Convert.ToInt32(model.Country);

            if (checkOutDate > returnDate) throw new Exception();

            List<Week> weekends = weekendRepository.FindBy(x => x.CountryId == countryId).ToList();
            if (weekends == null) throw new Exception();

            List<Holiday> holidays = holidayRepository.FindBy(x => x.CountryId == countryId).ToList();

            int dayCount = 0;
            for (DateTime date = checkOutDate; date < returnDate; date = date.AddDays(1))
            {
                var continueWeekend = weekends.Where(x => x.Code == (int)date.DayOfWeek).ToList();

                if (continueWeekend.Count == 0) dayCount++;

                Holiday holiday = holidayRepository.Get(x => x.CountryId == countryId && x.StartDate == date);
                if (holiday != null && holiday.Duration != 0) returnDate.AddDays(holiday.Duration);
            }

            decimal amount = 5, totalAmount = decimal.Zero;
            bool success = true;
            string symbol = string.Empty;

            if (dayCount > 10)
            {
                totalAmount = (dayCount - 10) * amount;
                success = false;

                Currency currency = currencyRepository.Get(x => x.CountryId == countryId);
                if (currency != null) symbol = currency.Symbol;
            }

            FormValue result = new FormValue()
            {
                Days = dayCount,
                Amount = totalAmount,
                Symbol = symbol,
                StartDate = model.StartDate,
                EndDate = model.EndDate
            };

            ViewBag.result = new ApiResponse() { success = success };

            return View(result);
        }
    }
}
