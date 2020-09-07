using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Model
{
    public class Country : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
    }
}
