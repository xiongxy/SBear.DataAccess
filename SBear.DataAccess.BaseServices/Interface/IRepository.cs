using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SBear.DataAccess.BaseServices.Interface
{
    public interface IRepository<T> where T : class
    {
        T Get(object id);
        T Insert(T entity);
        T Update(T entity);
        bool Delete(T entity);
        bool Delete(object id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetList(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> order = null);
    }
}
