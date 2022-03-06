using System.Linq.Expressions;

namespace HelpingHand.Core.Data.Common
{
    public interface IRepository
    {
        Task SaveChangesAsync();

        Task AddAsync<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        IQueryable<T> GetOne<T>(Expression<Func<T, bool>> predicate) where T : class;

        IQueryable<T> GetAll<T>() where T : class;
    }
}
