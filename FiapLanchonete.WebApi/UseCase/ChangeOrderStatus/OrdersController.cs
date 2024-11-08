using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FiapLanchonete.Application.CommandsUseCases.ChangeOrderStatus;
using FiapLanchonete.Domain.ValueObjects;

namespace FiapLanchonete.WebApi.UseCase.ChangeOrderStatus
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IChangeOrderStatusUseCase changeOrderService;

        public OrdersController(IChangeOrderStatusUseCase changeOrderService)
        {
            this.changeOrderService = changeOrderService;
        }

        /// <summary>
        /// Change Order Status
        /// </summary>
        [HttpDelete("{orderId}")]
        public async Task<IActionResult> ChangeOrderStatus(Guid orderId, OrderStatus orderStatus)
        {
            Guid changeStatusResult = await changeOrderService.Execute(orderId, orderStatus);

            if (changeStatusResult == Guid.Empty)
            {
                return new NoContentResult();
            }

            return Ok();
        }

    }
}
