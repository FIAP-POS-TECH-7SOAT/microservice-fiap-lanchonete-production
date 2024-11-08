using FiapLanchonete.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.CommandsUseCases.ChangeOrderStatus
{
    public interface IChangeOrderStatusUseCase
    {
        Task<Guid> Execute(Guid orderId, OrderStatus orderStatus);
    }
}
