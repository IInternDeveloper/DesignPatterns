using Microsoft.EntityFrameworkCore;
using DesignPatterns.Patterns.Repository;

namespace DesignPatterns.Patterns.UoW;

public class UnitOfWork : IUnitOfWork {
    private readonly DbContext _context;
    
    private IRepository<Person> _personRepository;
    private IRepository<Order> _orderRepository;

    public UnitOfWork(DbContext context) {
        _context = context;
    }
    
    public IRepository<Person> Persons => _personRepository ??= new Repository<Person>(_context);
    public IRepository<Order> Orders => _orderRepository ??= new Repository<Order>(_context);

    public void Save() {
        _context.SaveChanges();
    }

    public void Dispose() {
        _context.Dispose();
    }
}