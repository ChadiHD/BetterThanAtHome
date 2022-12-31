using BetterThanHome.Contracts._Payment;
using BetterThanHome.Application.Services.Payments;
using Microsoft.AspNetCore.Mvc;
using BetterThanHome.Application.Models.PaymentModel;

namespace BetterThanHome.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        // POST api/<PaymentController>
        [HttpPost]
        public IActionResult CreatePayment(CreatePaymentRequest request)
        {
            Payment payment = Payment.From(request);
            _paymentService.CreatePayment(payment);
            return CreateAtGetPayment(payment);
        }

        // GET api/<PaymentController>/5
        [HttpGet("{id:guid}")]
        public IActionResult GetPayment(Guid id)
        {
            Payment payment = _paymentService.GetPayment(id);
            return Ok(MapPaymentResponse(payment));
        }

        // PUT api/<PaymentController>/5
        [HttpPut("{id:guid}")]
        public IActionResult UpsertPayment(Guid id, UpsertPaymentRequest request)
        {
            Payment payment = Payment.From(id, request);

            UpsertedPayment upsertPaymentResult = _paymentService.UpsertPayment(payment);

            return upsertPaymentResult.IsNewlyCreated ? CreateAtGetPayment(payment) : NoContent();
        }

        // DELETE api/<PaymentController>/5
        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            _paymentService.DeletePayment(id);
            return NoContent();
        }

        private CreatedAtActionResult CreateAtGetPayment(Payment payment)
        {
            return CreatedAtAction(
                actionName: nameof(GetPayment),
                routeValues: new { id = payment.Id },
                value: MapPaymentResponse(payment));
        }
        private static PaymentResponse MapPaymentResponse(Payment payment)
        {
            return new PaymentResponse(
                payment.Id,
                payment.PaymentType,
                payment.Amount,
                payment.DateOfPayment,
                payment.Orders);
        }
    }
}
