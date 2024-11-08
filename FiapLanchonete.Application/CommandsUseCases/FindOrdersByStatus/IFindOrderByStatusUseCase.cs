using FiapLanchonete.Domain;
using FiapLanchonete.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.CommandsUseCases.FindOrdersByStatus
{
    public interface IFindOrderByStatusUseCase
    {
        Task<IEnumerable<Order>> Execute(OrderStatus orderStatus);
    }
}
