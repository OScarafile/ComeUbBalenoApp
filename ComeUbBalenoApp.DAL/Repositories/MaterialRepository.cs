using ComeUbBalenoApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComeUbBalenoApp.DAL.Repositories;

/// <summary>Repository materiali con Entity Framework Core.</summary>
public class MaterialRepository : IMaterialRepository
{
    private readonly AppDbContext _context;

    public MaterialRepository(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Material>> GetAllAsync(CancellationToken cancellationToken = default)
        => await _context.Materials.AsNoTracking().ToListAsync(cancellationToken);

    public async Task<Material?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        => await _context.Materials.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id, cancellationToken);

    public async Task<Material> AddAsync(Material material, CancellationToken cancellationToken = default)
    {
        _context.Materials.Add(material);
        await _context.SaveChangesAsync(cancellationToken);
        return material;
    }

    public async Task<Material> UpdateAsync(Material material, CancellationToken cancellationToken = default)
    {
        _context.Materials.Update(material);
        await _context.SaveChangesAsync(cancellationToken);
        return material;
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var material = await _context.Materials.FindAsync(new object[] { id }, cancellationToken);
        if (material is null) return false;
        _context.Materials.Remove(material);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
