using Nitrogen.Data.Mysql.Data;
using Nitrogen.DataBase.Data;
using Nitrogen.Foundation.Page;
using Nitrogen.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Nitrogen.Logic
{
    public class BaseLogic<T> : BaseILogic<T> where T: class
    {
        // public 
        protected MySqlDbContext _dbContext;
 
        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChangesAsync();
        }

        //public IQueryable<T> FindList(Expression<Func<T, bool>> condition, string orderField, bool isAsc, int pageSize, int pageIndex, out int total)
        //{
        //    total = _dbContext.Set<T>().AsQueryable<T>().Count();
        //    return _dbContext.Set<T>().Where(condition).Skip(pageSize * (pageIndex - 1)).Take(pageIndex);
        //}

        public IQueryable<T> FindList(Expression<Func<T, bool>> condition, Pagination pagination)
        {
            // pagination.total = _dbContext.Set<T>().AsQueryable<T>().Count();
            return _dbContext.Set<T>().Where(condition).Skip(pagination.rows * (pagination.page - 1)).Take(pagination.rows);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where<T>(expression);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
