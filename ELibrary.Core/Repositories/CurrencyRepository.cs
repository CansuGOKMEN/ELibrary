using ELibrary.Core.Context;
using ELibrary.Core.Model;
using ELibrary.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Repositories
{
    public class CurrencyRepository : BaseRepository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(ElibraryContext context) : base(context) { }
    }
}
