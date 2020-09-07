using ELibrary.Core.Context;
using ELibrary.Core.Model;
using ELibrary.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Repositories
{
    public class WeekRepository : BaseRepository<Week>, IWeekRepositoy
    {
        public WeekRepository(ElibraryContext context) : base(context) { }
    }
}
