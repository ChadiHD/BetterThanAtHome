using BetterThanHome.Contracts._Order;
using BetterThanHome.Application.Services.Orders;
using Microsoft.AspNetCore.Mvc;
using BetterThanHome.Application.Models.OrderModel;
using BetterThanHome.Application;

namespace BetterThanHome.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        
        // GET api/<OrderController>/5
        [HttpGet("{id:guid}")]
        public IActionResult GetOrder(Guid id)
        {
            Order order = _orderService.GetOrder(id);
            
            return Ok(MapOrderResponse(order));
        }

        // POST api/<OrderController>
        [HttpPost]
        public IActionResult CreateOrder(CreateOrderRequest request)
        {
            // Create new order object
            Order order = Order.From(request);

            //Save to Database
            _orderService.CreateOrder(order);

            return CreateAtGetOrder(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id:guid}")]
        public IActionResult UpsertOrder(Guid id, UpsertOrderRequest request)
        {
            Order order = Order.From(id,request);

            UpsertedOrder upsertOrderResult = _orderService.UpsertOrder(order);

            return upsertOrderResult.IsNewlyCreated ? CreateAtGetOrder(order) : NoContent();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteMenu(Guid id)
        {
            _orderService.DeleteOrder(id);
            return NoContent();
        }

        private static OrderResponse MapOrderResponse(Order order)
        {
            return new OrderResponse(
                order.Id,
                order.OrderStatus,
                order.OrderDate,
                order.GuestsNumber,
                order.Guests,
                order.StaffMembers,
                order.Dishes);
        }

        private CreatedAtActionResult CreateAtGetOrder(Order order)
        {
            return CreatedAtAction(
                actionName: nameof(GetOrder),
                routeValues: new { id = order.Id },
                value: MapOrderResponse(order));
        }
    }
}
