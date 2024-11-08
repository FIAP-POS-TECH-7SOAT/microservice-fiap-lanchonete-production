using FiapLanchonete.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.Queries
{
    public interface IProductsQueries
    {
        Task<ProductResult> GetProduct(Guid productId);
    }
}
