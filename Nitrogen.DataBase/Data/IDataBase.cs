using Nitrogen.Foundation.Page;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Nitrogen.DataBase.Data
{
    public interface IDataBase<T> where T : class
    {
        T Get(Expression<Func<T, bool>> expression);

        /// <summary>
        /// 删除实体。
        /// </summary>
        /// <param name="entity">实体对象。</param>
        void Delete(T entity);

        /// <summary>
        /// 更新实体。
        /// </summary>
        /// <param name="entity">实体对象。</param>
        void Update(T entity);

        /// <summary>
        /// GetList.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>

        IQueryable<T> GetList(Expression<Func<T, bool>> expression);

        /// <summary>
        /// GetList分页
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="orderField"></param>
        /// <param name="isAsc"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        IQueryable<T> FindList(Expression<Func<T, bool>> condition, Pagination pagination);
    }
}
