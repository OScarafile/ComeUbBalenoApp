using ComeUbBalenoApp.DAL.Entities;

namespace ComeUbBalenoApp.BLL.Interfaces;

public interface IMaterialService
{
    Task<IEnumerable<Material>> GetAllMaterialsAsync(CancellationToken cancellationToken = default);
    Task<Material?> GetMaterialByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Material> CreateMaterialAsync(Material material, CancellationToken cancellationToken = default);
    Task<Material?> UpdateMaterialAsync(int id, Material material, CancellationToken cancellationToken = default);
    Task<bool> DeleteMaterialAsync(int id, CancellationToken cancellationToken = default);
}
