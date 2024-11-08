using FiapLanchonete.Domain;
using FiapLanchonete.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.Repositories
{
    public interface IOrderReadOnlyRepository
    {
        Task<Order> Get(Guid id);
    }
}
