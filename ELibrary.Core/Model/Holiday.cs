using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Model
{
    public class Holiday : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
