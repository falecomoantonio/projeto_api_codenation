using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WebApi.Repository
{
    public interface IDefaultRepository<T> where T : class
    {
        T Find(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        T Save(T target);
        T Update(T target);
        bool Delete(T target);

    }
}
