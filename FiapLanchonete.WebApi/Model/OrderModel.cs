using FiapLanchonete.Domain.ValueObjects;
using FiapLanchonete.Domain;

namespace FiapLanchonete.WebApi.Model
{
    public class OrderModel
    {
        public Guid Id { get; }
        public OrderStatus Status { get; }
        public DateTime CreatedAt { get; }
        public List<Product> Products { get; }
        public OrderModel(DateTime createdAt, OrderStatus orderStatus, List<Product> products)
        {
            CreatedAt = createdAt;
            Status = orderStatus;
            Products = products;
        }

    }
}
