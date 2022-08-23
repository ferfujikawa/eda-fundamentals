using eda_fundamentals.Order.Domain.Commands;
using eda_fundamentals.Order.Domain.Handler;
using Microsoft.AspNetCore.Mvc;

namespace eda_fundamentals.Order.Api;

[ApiController]
[Route("v1/orders")]
public class OrderController
{
    [HttpPost]
    [Route("place")]
    public async Task<IActionResult> PlaceOrder(
        [FromServices] PlaceOrderHandler handler,
        [FromBody] PlaceOrderCommand command)
    {
        await handler.HandleAsync(command);
        return new OkResult();
    }
}