using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HelpingHand.Core.Data.Common
{
    public class Repository : IRepository
    {
        private ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
             DbSet<T>().Remove(entity);
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> GetOne<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return GetAll<T>().Where(predicate);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        private DbSet<T> DbSet<T>()
            where T : class
        {
            return _context.Set<T>();
        }
    }
}
