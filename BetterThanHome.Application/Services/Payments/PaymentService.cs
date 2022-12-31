using BetterThanHome.Application.Models.PaymentModel;

namespace BetterThanHome.Application.Services.Payments
{
    public class PaymentService : IPaymentService
    {
        private static readonly Dictionary<Guid, Payment> _payments = new();
        public void CreatePayment(Payment payment)
        {
            _payments.Add(payment.Id, payment);
        }

        public void DeletePayment(Guid id)
        {
            _payments.Remove(id);
        }

        public Payment GetPayment(Guid id)
        {
            return _payments[id];
        }

        public UpsertedPayment UpsertPayment(Payment payment)
        {
            var isNewlyCreated = !_payments.ContainsKey(payment.Id);

            _payments[payment.Id] = payment;

            return new UpsertedPayment(isNewlyCreated);
        }
    }
}
