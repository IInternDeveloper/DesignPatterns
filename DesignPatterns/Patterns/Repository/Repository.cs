using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Patterns.Repository;

public class Repository<T> : IRepository<T> where T : class {
    private readonly DbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(DbContext context) {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IEnumerable<T> GetAll() {
        return _dbSet.ToList();
    }

    public T GetById(int id) {
        return _dbSet.Find(id);
    }

    public void Add(T entity) {
        _dbSet.Add(entity);
    }

    public void Update(T entity) {
        _dbSet.Update(entity);
    }

    public void Remove(T entity) {
        _dbSet.Remove(entity);
    }
}