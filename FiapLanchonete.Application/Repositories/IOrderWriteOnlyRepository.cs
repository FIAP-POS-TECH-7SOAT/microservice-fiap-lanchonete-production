using FiapLanchonete.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.Repositories
{
    public interface IOrderWriteOnlyRepository
    {
        Task Add(Order order);
        Task Update(Order order);
        Task Delete(Order order);
    }
}
