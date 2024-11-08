using FiapLanchonete.Application.Repositories;
using FiapLanchonete.Domain;
using FiapLanchonete.Domain.ValueObjects;
using FiapLanchonete.Application.Exception;

namespace FiapLanchonete.Application.CommandsUseCases.ReceiveOrder
{
    public sealed class ReceiveOrderStatusUseCase : IReceiveOrderUseCase
    {
        private readonly IOrderWriteOnlyRepository orderWriteOnlyRepository;
        private readonly IOrderReadOnlyRepository orderReadOnlyRepository;
        public ReceiveOrderStatusUseCase(
           IOrderWriteOnlyRepository orderWriteOnlyRepository, IOrderReadOnlyRepository orderReadOnlyRepository)
        {
            this.orderWriteOnlyRepository = orderWriteOnlyRepository;
            this.orderReadOnlyRepository = orderReadOnlyRepository;
        }

        public async Task<Guid> Execute(Order order)
        {
            if (order.Status != OrderStatus.Recebido) 
            {
                throw new OrderStatusException($"The order should have OrderStatus 'Recebido'");
            }

            Order orderResult = await orderReadOnlyRepository.Get(order.Id);
            if (orderResult != null)
            {
                throw new OrderAlreadyExistsException($"The order {orderResult.Id} already exists.");
            }

            await orderWriteOnlyRepository.Add(order);

            return order.Id;
        }
    }
}
