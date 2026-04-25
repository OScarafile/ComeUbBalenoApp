using ComeUbBalenoApp.DAL.Entities;

namespace ComeUbBalenoApp.BLL.Interfaces;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetOrdersByUserAsync(int userId, CancellationToken cancellationToken = default);
    Task<IEnumerable<Order>> GetAllOrdersAsync(CancellationToken cancellationToken = default);
    Task<Order?> GetOrderByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Order> CreateOrderAsync(Order order, CancellationToken cancellationToken = default);
}
