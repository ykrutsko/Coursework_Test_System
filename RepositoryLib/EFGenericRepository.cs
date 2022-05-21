using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryLib
{
    public class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext context;
        DbSet<TEntity> dbSet;

        public EFGenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }
        public void Add(TEntity item)
        {
            dbSet.Add(item);
            context.SaveChanges();
        }

        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate) == null ? null : dbSet.Where(predicate).ToList();
        }

        public TEntity FindById(object id)
        {
            return dbSet.Find(id) == null ? null : dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet == null ? null : dbSet.ToList();
        }

        public void Remove(TEntity item)
        {
            dbSet.Remove(item);
            context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}