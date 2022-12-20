using FitnessApp.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FitnessApp.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DatabaseService _database;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(
            DatabaseService database)
        {
            _database = database;
            _dbSet = _database.Set<T>();
        }

        public void Add(T entity)
            => _database.Add(entity);

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
            => await _database.AddAsync(entity, cancellationToken);

        public void AddRange(IEnumerable<T> entities)
            => _database.AddRange(entities);

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
            => await _database.AddRangeAsync(entities, cancellationToken);

        public T Get(Expression<Func<T, bool>> expression)
            => _dbSet.FirstOrDefault(expression);

        public IEnumerable<T> GetAll()
            => _dbSet.AsEnumerable();

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression)
            => _dbSet.Where(expression).AsEnumerable();

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _dbSet.ToListAsync(cancellationToken);

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
            => await _dbSet.Where(expression).ToListAsync(cancellationToken);

        public Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
            => _dbSet.FirstOrDefaultAsync(expression);

        public void Remove(T entity)
            => _database.Remove(entity);

        public void RemoveRange(IEnumerable<T> entities)
            => _database.RemoveRange(entities);

        public void Update(T entity)
            => _database.Update(entity);

        public void UpdateRange(IEnumerable<T> entities)
            => _database.UpdateRange(entities);
    }
}
