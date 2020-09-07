using ELibrary.Core.Context;
using ELibrary.Core.Model;
using ELibrary.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(ElibraryContext context) : base(context) { }
    }
}
