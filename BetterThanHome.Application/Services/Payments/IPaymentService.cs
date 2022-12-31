using BetterThanHome.Application.Models.PaymentModel;

namespace BetterThanHome.Application.Services.Payments
{
    public interface IPaymentService
    {
        void CreatePayment(Payment payment);
        void DeletePayment(Guid id);
        Payment GetPayment(Guid id);
        UpsertedPayment UpsertPayment(Payment payment);
    }
}
