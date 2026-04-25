using ComeUbBalenoApp.DAL.Entities;

namespace ComeUbBalenoApp.BLL.Interfaces;

/// <summary>Interfaccia servizio prodotti. Il controller (PL) dipende da questa interfaccia (DIP).</summary>
public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync(CancellationToken cancellationToken = default);
    Task<Product?> GetProductByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Product> CreateProductAsync(Product product, CancellationToken cancellationToken = default);
    Task<Product?> UpdateProductAsync(int id, Product product, CancellationToken cancellationToken = default);
    Task<bool> DeleteProductAsync(int id, CancellationToken cancellationToken = default);
}
