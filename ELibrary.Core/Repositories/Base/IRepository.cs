using ELibrary.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Repositories.Base
{
    public interface IWeekRepositoy : IBaseRepository<Week> { }

    public interface ICountryRepository : IBaseRepository<Country> { }

    public interface IHolidayRepository : IBaseRepository<Holiday> { }

    public interface ICurrencyRepository : IBaseRepository<Currency> { }
}
