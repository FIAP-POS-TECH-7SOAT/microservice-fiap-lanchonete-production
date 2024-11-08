using FiapLanchonete.Domain.Interfaces;

namespace FiapLanchonete.Domain
{
    public sealed class Product : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public string Category { get; private set; }

        // Private constructor to enforce the use of the Create method
        private Product(Guid id, string name, int amount, string category, DateTime createdAt)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Category = category;
            CreatedAt = createdAt;
        }

        // Static factory method to create a new instance of Product
        public static Product Create(string name, int amount, string category)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty.", nameof(name));
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentException("Category cannot be empty.", nameof(category));
            }

            // Generate a new Id for the product
            var newId = Guid.NewGuid();

            // Use the private constructor to create the Product instance
            return new Product(newId, name, amount, category, DateTime.UtcNow);
        }
    }
}