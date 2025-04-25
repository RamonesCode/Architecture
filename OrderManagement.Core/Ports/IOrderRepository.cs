using OrderManagement.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderManagement.Core.Ports;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllAsync();
    Task<Order?> GetByIdAsync(int id);
    Task<Order> CreateAsync(Order order);
    Task<bool> UpdateAsync(Order order);
    Task<bool> DeleteAsync(int id);
}
