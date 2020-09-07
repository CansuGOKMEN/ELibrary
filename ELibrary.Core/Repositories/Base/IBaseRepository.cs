using ELibrary.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ELibrary.Core.Repositories.Base
{
    public interface IBaseRepository<T> where T : class, IEntityBase, new()
    {
        List<T> GetAll();
        T Get(int id);
        T Get(Expression<Func<T, bool>> expression);//Get Currency
        IEnumerable<T> FindBy(Expression<Func<T, bool>> expression); //Get Holiday
    }
}
