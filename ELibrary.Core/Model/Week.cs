using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Model
{
    public class Week : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Code { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
