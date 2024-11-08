using FiapLanchonete.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.Repositories
{
    public interface IProductWriteOnlyRepository
    {
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(Product product);
    }
}
