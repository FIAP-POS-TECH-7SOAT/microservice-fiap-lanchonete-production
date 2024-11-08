namespace FiapLanchonete.Application.Results
{
    public sealed class ProductResult
    {
        public DateTime CreatedAt { get; set; }
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public string Category { get; private set; }

        public ProductResult(
            DateTime createdAt,
            string name,
            int amount,
            string category)
        {
            CreatedAt = createdAt;
            Name = name;
            Amount = amount;
            Category = category;
        }
    }
}
