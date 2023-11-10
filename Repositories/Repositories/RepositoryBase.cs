using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected BookstoreDbContext _context;
        public RepositoryBase(BookstoreDbContext context) => _context = context;
        public IQueryable<T> GetAll(bool trackChanges) => !trackChanges ? _context.Set<T>().AsNoTracking():_context.Set<T>();
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges) => !trackChanges ?
            _context.Set<T>().Where(expression).AsNoTracking() :
            _context.Set<T>().Where(expression);
        public void Create(T Entity) => _context.Set<T>().Add(Entity);
        public void Delete(T Entity) => _context.Set<T>().Remove(Entity);
        public void Update(T Entity) => _context.Set<T>().Update(Entity);

    }
}
