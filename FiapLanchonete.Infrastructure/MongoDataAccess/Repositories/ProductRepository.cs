using FiapLanchonete.Application.Repositories;
using FiapLanchonete.Domain;
using MongoDB.Driver;

namespace FiapLanchonete.Infrastructure.MongoDataAccess.Repositories
{
    public class ProductRepository : IProductReadOnlyRepository, IProductWriteOnlyRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public Task Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
