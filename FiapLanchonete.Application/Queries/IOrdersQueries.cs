using FiapLanchonete.Application.Results;
using FiapLanchonete.Domain;

namespace FiapLanchonete.Application.Queries
{
    public interface IOrdersQueries
    {
        Task<OrderResult> GetOrder(Guid orderId);
        Task<OrderResult> CreateOrder(Order order);
    }
}
