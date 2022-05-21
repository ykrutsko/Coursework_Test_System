using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLib
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        // add
        void Add(TEntity item);

        // return one by Id
        TEntity FindById(object id);

        // return all
        IEnumerable<TEntity> GetAll();

        //return by predicate
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);

        // delete
        void Remove(TEntity item);

        // update
        void Update(TEntity item);
    }
}
