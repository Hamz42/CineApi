using System.Linq.Expressions;

namespace MC.Cine.BLL.Interfaces.Repository.Base
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeProperties = "");
        Task<bool> CreateAsync(T entity);
        Task<T?> FindAsync(int id);

        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeProperties = "");
        bool Create(T entity);
        T? Find(int id);
    }
}
