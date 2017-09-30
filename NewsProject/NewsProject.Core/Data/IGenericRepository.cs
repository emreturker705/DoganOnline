using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Core.Data
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity :class
    {
        IQueryable<TEntity> AsQueryable();
        void Add(TEntity entity);
        void Delete(TEntity entity);
        TEntity Update(TEntity entity);
        int SaveChanges();
    }
}
