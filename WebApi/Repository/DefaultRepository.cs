using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WebApi.Repository
{
    public abstract class DefaultRepository<T> : IDefaultRepository<T> where T : class
    {
        private readonly DbContext context;

        protected DefaultRepository(DbContext target)
        {
            this.context = target;
        }


        public bool Delete(T target)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T Save(T target)
        {
            throw new NotImplementedException();
        }

        public T Update(T target)
        {
            throw new NotImplementedException();
        }
    }
}
