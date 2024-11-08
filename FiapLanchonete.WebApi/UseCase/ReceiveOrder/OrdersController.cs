using FiapLanchonete.Application.CommandsUseCases.ReceiveOrder;
using FiapLanchonete.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FiapLanchonete.WebApi.UseCase.ReceiveOrder
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IReceiveOrderUseCase receiveOrderService;

        public OrdersController(IReceiveOrderUseCase receiveOrderService)
        {
            this.receiveOrderService = receiveOrderService;
        }

        /// <summary>
        /// Change Order Status
        /// </summary>
        [HttpDelete("{orderId}")]
        public async Task<IActionResult> ReceiveOrder([FromBody] Order order)
        {
            if (order == null)
            {
                return BadRequest();
            }

            Guid receiveOrderResult = await receiveOrderService.Execute(order);

            if (receiveOrderResult == Guid.Empty)
            {
                return new NoContentResult();
            }

            return Ok();
        }

    }
}
