// Implementazione concreta del repository prodotti con EF Core.
// Per aggiungere query personalizzate (es. filtro per categoria), aggiungere metodo all'interfaccia e implementarlo qui.
using ComeUbBalenoApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComeUbBalenoApp.DAL.Repositories;

/// <summary>Repository prodotti con Entity Framework Core.</summary>
public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken = default)
        => await _context.Products.Include(p => p.Images).AsNoTracking().ToListAsync(cancellationToken);

    public async Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        => await _context.Products
            .Include(p => p.Images)
            .Include(p => p.BillOfMaterials).ThenInclude(b => b.Material)
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id, cancellationToken);

    public async Task<Product> AddAsync(Product product, CancellationToken cancellationToken = default)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync(cancellationToken);
        return product;
    }

    public async Task<Product> UpdateAsync(Product product, CancellationToken cancellationToken = default)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync(cancellationToken);
        return product;
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var product = await _context.Products.FindAsync(new object[] { id }, cancellationToken);
        if (product is null) return false;
        _context.Products.Remove(product);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<bool> ExistsAsync(int id, CancellationToken cancellationToken = default)
        => await _context.Products.AnyAsync(p => p.Id == id, cancellationToken);
}
