using ComeUbBalenoApp.DAL.Entities;

namespace ComeUbBalenoApp.DAL.Interfaces;

/// <summary>Operazioni CRUD sui materiali.</summary>
public interface IMaterialRepository
{
    Task<IEnumerable<Material>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Material?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Material> AddAsync(Material material, CancellationToken cancellationToken = default);
    Task<Material> UpdateAsync(Material material, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
}
