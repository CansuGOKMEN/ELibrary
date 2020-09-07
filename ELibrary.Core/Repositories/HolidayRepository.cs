using ELibrary.Core.Context;
using ELibrary.Core.Model;
using ELibrary.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Repositories
{
    public class HolidayRepository : BaseRepository<Holiday>, IHolidayRepository
    {
        public HolidayRepository(ElibraryContext context) : base(context) { }
    }
}
