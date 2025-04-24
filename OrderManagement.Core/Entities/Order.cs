namespace OrderManagement.Core.Entities;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
