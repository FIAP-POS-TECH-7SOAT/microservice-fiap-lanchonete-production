using FiapLanchonete.Application.Repositories;
using FiapLanchonete.Domain;
using FiapLanchonete.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.CommandsUseCases.FindOrdersByStatus
{
    public sealed class FindOrderByStatusUseCase : IFindOrderByStatusUseCase
    {
        private readonly IOrderReadOnlyRepository orderReadOnlyRepository;

        public FindOrderByStatusUseCase(IOrderReadOnlyRepository orderReadOnlyRepository) 
        {
            this.orderReadOnlyRepository = orderReadOnlyRepository;
        }

        public Task<IEnumerable<Order>> Execute(OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }
    }
}
