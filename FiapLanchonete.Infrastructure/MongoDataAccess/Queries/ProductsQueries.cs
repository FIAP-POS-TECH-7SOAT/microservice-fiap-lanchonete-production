using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiapLanchonete.Application.Queries;
using FiapLanchonete.Application.Results;
using MongoDB.Driver;

namespace FiapLanchonete.Infrastructure.MongoDataAccess.Queries
{
    public class ProductsQueries : IProductsQueries
    {
        private readonly Context context;

        public ProductsQueries(Context context)
        {
            this.context = context;
        }

        public Task<ProductResult> GetProduct(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
