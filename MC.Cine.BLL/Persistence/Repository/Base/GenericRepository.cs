using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository.Base;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MC.Cine.BLL.Persistence.Repository.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(T entity)
        {
            try
            {
                await _unitOfWork.ContextSirec.Set<T>().AddAsync(entity);
                await _unitOfWork.ContextSirec.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T?> FindAsync(int id)
        {
            return await _unitOfWork.ContextSirec.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _unitOfWork.ContextSirec.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = _unitOfWork.ContextSirec.Set<T>();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        public bool Create(T entity)
        {
            try
            {
                _unitOfWork.ContextSirec.Set<T>().Add(entity);
                _unitOfWork.ContextSirec.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T? Find(int id)
        {
            return _unitOfWork.ContextSirec.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _unitOfWork.ContextSirec.Set<T>().ToList();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = _unitOfWork.ContextSirec.Set<T>();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
    }
}
