using OrderManagement.Core.Entities;
using OrderManagement.Core.Ports;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.Repositories;

public class InMemoryOrderRepository : IOrderRepository
{
    private readonly ConcurrentDictionary<int, Order> _orders = new();
    private int _currentId = 1;

    public Task<IEnumerable<Order>> GetAllAsync() =>
        Task.FromResult(_orders.Values.AsEnumerable());

    public Task<Order?> GetByIdAsync(int id) =>
        Task.FromResult(_orders.TryGetValue(id, out var order) ? order : null);

    public Task<Order> CreateAsync(Order order)
    {
        order.Id = _currentId++;
        _orders[order.Id] = order;
        return Task.FromResult(order);
    }

    public Task<bool> UpdateAsync(Order order)
    {
        if (!_orders.ContainsKey(order.Id))
            return Task.FromResult(false);

        _orders[order.Id] = order;
        return Task.FromResult(true);
    }

    public Task<bool> DeleteAsync(int id) =>
        Task.FromResult(_orders.TryRemove(id, out _));
}
