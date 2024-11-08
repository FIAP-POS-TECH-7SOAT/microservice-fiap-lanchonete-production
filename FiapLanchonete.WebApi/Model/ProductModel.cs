namespace FiapLanchonete.WebApi.Model
{
    public sealed class ProductModel
    {
        public DateTime CreatedAt { get; }
        public string Name { get; }
        public int Amount { get; }
        public string Category { get; } 
        public ProductModel(DateTime createdAt, string name, int amount, string category)
        {
            CreatedAt = createdAt;
            Name = name;
            Amount = amount;
            Category = category;
        }
    }
}
