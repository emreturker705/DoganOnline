using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsProject.Ioc;

namespace NewsProject.Core.Data
{
    public abstract class Repository<T> : IGenericRepository<T>, IDisposable where T : class
    {
        private DbContext _context { get; set; }
        private readonly DbSet<T> _dbSet;
        public Repository()
        {
            _context = IocContainer.Resolve<DbContext>();
            _dbSet = _context.Set<T>();
        }

        #region IGenericRepository<T> Members

        public IQueryable<T> AsQueryable()
        {
            return _dbSet;
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            var deletedEntity = _dbSet.Attach(entity);
            _context.Entry<T>(entity).State = EntityState.Deleted;
        }

        public T Update(T entity)
        {
            var updated = _dbSet.Attach(entity);
            _context.Entry<T>(entity).State = EntityState.Modified;
            return updated;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
            }
        }

        #endregion
    }
}
