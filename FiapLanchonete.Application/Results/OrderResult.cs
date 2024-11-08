using FiapLanchonete.Domain;
using FiapLanchonete.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.Results
{
    public sealed class OrderResult
    {
        public Guid Id { get; private set; }
        public OrderStatus Status { get; private set; }
        public DateTime CreatedAt { get; set; }
        public List<ProductResult> Products { get; set; }

        public OrderResult(
            Guid orderId,
            OrderStatus status,
            DateTime createdAt,
            List<ProductResult> products)
        {
            Id = orderId;
            Status = status;
            CreatedAt = createdAt;
            Products = products;
        }

        public OrderResult(Order order)
        {
            Id = order.Id;

            List<ProductResult> productsResult = new List<ProductResult>();
            foreach (Product product in order.Products)
            {
                ProductResult productResult = new ProductResult(
                    product.CreatedAt, product.Name, product.Amount, product.Category);
                productsResult.Add(productResult);
            }

            Products = productsResult;
        }
    }
}
