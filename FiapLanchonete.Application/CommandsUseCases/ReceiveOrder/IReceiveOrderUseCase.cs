using FiapLanchonete.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.CommandsUseCases.ReceiveOrder
{
    public interface IReceiveOrderUseCase
    {
        Task<Guid> Execute(Order order);
    }
}
