using DesignPatterns.Patterns.Repository;

namespace DesignPatterns.Patterns.UoW;

public interface IUnitOfWork : IDisposable {
    IRepository<Person> Persons { get; }
    IRepository<Order> Orders { get; }
    void Save();
}
