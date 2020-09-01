using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Infrastracture
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where);
        TEntity GetById(object Id);
        IEnumerable<TEntity> GetByIdwithinclude(string children);
        IEnumerable<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> where);
        
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);
        Task<List<TEntity>> GetManyAsyncWithInclude(string children);
        IEnumerable<TEntity> GetAllWithWhereandInclude(string children, Expression<Func<TEntity, bool>> where);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity> GetFirstAsync();
        Task<List<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> where);
        Task<int> GetCount();
    }
}
