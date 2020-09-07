using ELibrary.Core.Context;
using ELibrary.Core.Model;
using ELibrary.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ELibrary.Core.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntityBase, new()
    {
        public ElibraryContext context;

        public BaseRepository(ElibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }

        public T Get(int id)
        {
            return context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
