using FiapLanchonete.Application.Exception;
using FiapLanchonete.Application.Repositories;
using FiapLanchonete.Domain;
using FiapLanchonete.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.CommandsUseCases.ChangeOrderStatus
{
    public sealed class ChangeOrderStatusUseCase : IChangeOrderStatusUseCase
    {
        private readonly IOrderReadOnlyRepository orderReadOnlyRepository;
        private readonly IOrderWriteOnlyRepository orderWriteOnlyRepository;

        public ChangeOrderStatusUseCase(
            IOrderReadOnlyRepository orderReadOnlyRepository,
            IOrderWriteOnlyRepository orderWriteOnlyRepository)
        {
            this.orderReadOnlyRepository = orderReadOnlyRepository;
            this.orderWriteOnlyRepository = orderWriteOnlyRepository;
        }

        public async Task<Guid> Execute(Guid orderId, OrderStatus orderStatus)
        {
            Order order = await orderReadOnlyRepository.Get(orderId);
            if (order == null)
                throw new OrderNotFoundException($"The order {orderId} does not exists.");

            order.UpdateStatus(orderStatus);

            await orderWriteOnlyRepository.Update(order);

            return order.Id;
        }
    }
}
