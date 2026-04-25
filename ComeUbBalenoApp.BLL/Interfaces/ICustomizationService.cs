using ComeUbBalenoApp.DAL.Entities;

namespace ComeUbBalenoApp.BLL.Interfaces;

public interface ICustomizationService
{
    Task<CustomizationRequest> CreateRequestAsync(CustomizationRequest request, CancellationToken cancellationToken = default);
    Task<IEnumerable<CustomizationRequest>> GetByProductAsync(int productId, CancellationToken cancellationToken = default);
    Task<IEnumerable<CustomizationRequest>> GetByUserAsync(int userId, CancellationToken cancellationToken = default);
}
