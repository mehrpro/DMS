using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DevExpress.Utils.Extensions;

namespace DMS.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> FindByIdAsync(int Id);
        Task<IEnumerable<TEntity>> FindAllAsync();
        Task<TEntity> FindCondition(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> FindAllByCondition(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        Task<bool> AnyByCondition(Expression<Func<TEntity, bool>> predicate);
        void Update(TEntity entity, int entityId);
    }

    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public async Task<TEntity> FindCondition(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().FindAsync(predicate);
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public async Task<bool> AnyByCondition(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().AnyAsync(predicate);
        }

        public void Update(TEntity entity, int entityId)
        {
            var local = Context.Set<TEntity>().Find(entityId);
            if (local != null)
            {
                Context.Entry(local).State = EntityState.Detached;
            }
            Context.Entry(entity).State = EntityState.Modified;

        }

        public Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }



        public async Task<IEnumerable<TEntity>> FindAllByCondition(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().Where(predicate).ToListAsync();
        }
    }
}