using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Model
{
    public class Currency : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }

    }
}
