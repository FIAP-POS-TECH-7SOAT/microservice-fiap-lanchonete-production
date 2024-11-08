using FiapLanchonete.Application.Queries;
using FiapLanchonete.Application.Results;
using FiapLanchonete.Domain;
using FiapLanchonete.Domain.ValueObjects;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Infrastructure.MongoDataAccess.Queries
{
    public class OrdersQueries : IOrdersQueries
    {
        private readonly Context _context;

        public OrdersQueries(Context context)
        {
            _context = context;
        }

        public Task<OrderResult> CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<OrderResult> GetOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetOrdersByStatus(OrderStatus orderStatus)
        {
            // Use the filter to find matching documents in the Orders collection
            List<Entities.Order> orders = await _context.Orders.Find(order => order.Status == orderStatus).ToListAsync();

            return orders is null ? throw new NullReferenceException() : (IEnumerable<Order>)orders;
        }
    }
}
