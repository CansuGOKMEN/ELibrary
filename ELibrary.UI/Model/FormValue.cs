using ELibrary.Core.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELibrary.UI.Model
{
    public class FormValue
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Country { get; set; }

        public int Days { get; set; }
        public decimal Amount { get; set; }
        public string Symbol { get; set; }
    }
}
