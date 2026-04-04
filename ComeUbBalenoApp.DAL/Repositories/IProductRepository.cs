// Interfaccia repository prodotti. Segue DIP: il BLL dipende dall'interfaccia, non dall'implementazione.
using ComeUbBalenoApp.DAL.Entities;

namespace ComeUbBalenoApp.DAL.Repositories;

/// <summary>Operazioni CRUD sui prodotti.</summary>
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Product> AddAsync(Product product, CancellationToken cancellationToken = default);
    Task<Product> UpdateAsync(Product product, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
    Task<bool> ExistsAsync(int id, CancellationToken cancellationToken = default);
}
