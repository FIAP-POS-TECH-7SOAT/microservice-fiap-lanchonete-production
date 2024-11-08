using FiapLanchonete.Application.Repositories;
using FiapLanchonete.Domain;
using FiapLanchonete.Domain.ValueObjects;
using MongoDB.Driver;
using System.Net.NetworkInformation;

namespace FiapLanchonete.Infrastructure.MongoDataAccess.Repositories
{
    public class OrderRepository : IOrderReadOnlyRepository, IOrderWriteOnlyRepository
    {
        private readonly Context _context;

        public OrderRepository(Context context)
        {
            _context = context;
        }

        public Task Add(Order order)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
