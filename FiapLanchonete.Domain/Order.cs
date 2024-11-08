using FiapLanchonete.Domain.Interfaces;
using FiapLanchonete.Domain.Shared;
using FiapLanchonete.Domain.ValueObjects;

namespace FiapLanchonete.Domain
{
    public sealed class Order : IEntity
    {
        public Guid Id { get; private set; }
        public OrderStatus Status { get; private set; }
        public DateTime CreatedAt { get; set; }
        public List<Product> Products { get; set; }
        private Order(IOrderProps props, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            Status = props.Status;
            CreatedAt = DateTime.UtcNow;
            Products = props.Products ?? new List<Product>();
        }

        public static Order Create(IOrderProps props, Guid? id = null)
        {
            return new Order(props, id);
        }
        public void UpdateStatus(OrderStatus status)
        {
            Status = status;
        }
    }
}