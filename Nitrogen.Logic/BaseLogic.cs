using Nitrogen.Data.Mysql.Data;
using Nitrogen.DataBase.Data;
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
