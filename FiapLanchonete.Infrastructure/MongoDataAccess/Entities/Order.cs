using FiapLanchonete.Domain.ValueObjects;

namespace FiapLanchonete.Infrastructure.MongoDataAccess.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public OrderStatus Status { get; private set; }
        public DateTime CreatedAt { get; set; }
        public List<Product> Products { get; set; }

    }
}
