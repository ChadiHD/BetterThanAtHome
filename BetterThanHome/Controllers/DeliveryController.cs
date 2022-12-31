using BetterThanHome.Contracts._Delivery;
using BetterThanHome.Application.Services.Deliveries;
using Microsoft.AspNetCore.Mvc;
using BetterThanHome.Application.Models.DeliveryModel;

namespace BetterThanHome.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryService _deliveryService;

        public DeliveryController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        // POST api/<DeliveryController>
        [HttpPost]
        public IActionResult CreateDelivery(CreateDeliveryRequest request)
        {
            Delivery delivery = Delivery.From(request);
            _deliveryService.CreateDelivery(delivery);
            return CreateAtGetDelivery(delivery);
        }

        // GET api/<DeliveryController>/5
        [HttpGet("{id:guid}")]
        public IActionResult GetDelivery(Guid id)
        {
            Delivery delivery = _deliveryService.GetDelivery(id);
            return Ok(MapDeliveryResponse(delivery));
        }

        // PUT api/<DeliveryController>/5
        [HttpPut("{id:guid}")]
        public IActionResult UpsertDelivery(Guid id, UpsertDeliveryRequest request)
        {
            Delivery delivery = Delivery.From(id, request);
            UpsertedDelivery upsertDeliveryResult = _deliveryService.UpsertDelivery(delivery);
            return upsertDeliveryResult.IsNewlyCreated ? CreateAtGetDelivery(delivery) : NoContent();
        }

        // DELETE api/<DeliveryController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDelivery(Guid id)
        {
            _deliveryService.DeleteDelivery(id);
            return NoContent();
        }

        private static DeliveryResponse MapDeliveryResponse(Delivery delivery)
        {
            return new DeliveryResponse(
                delivery.Id,
                delivery.DeliveryAddress,
                delivery.DateOfDelivery,
                delivery.OrderList);
        }

        private IActionResult CreateAtGetDelivery(Delivery delivery)
        {
            return CreatedAtAction(
                actionName: nameof(GetDelivery),
                routeValues: new { id = delivery.Id },
                value: MapDeliveryResponse(delivery));
        }
    }
}
