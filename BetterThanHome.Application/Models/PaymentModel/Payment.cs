using BetterThanHome.Contracts._Payment;
using BetterThanHome.Contracts;

namespace BetterThanHome.Application.Models.PaymentModel
{
    public class Payment
    {
        public Guid Id { get; }

        public string PaymentType { get; }

        public decimal Amount { get; }

        public DateTime DateOfPayment { get; }

        public List<Order> Orders { get; }

        public Payment(
            Guid id,
            string paymentType,
            decimal amount,
            DateTime dateOfPayment,
            List<Order> orders)
        {
            Id = id;
            PaymentType = paymentType;
            Amount = amount;
            DateOfPayment = dateOfPayment;
            Orders = orders;
        }

        private static Payment Create(
            string paymentType,
            decimal amount,
            DateTime dateOfPayment,
            List<Order> orders,
            Guid? id = null)
        {
            return new Payment(
                id ?? Guid.NewGuid(),
                paymentType,
                amount,
                dateOfPayment,
                orders);
        }

        public static Payment From(Guid id, UpsertPaymentRequest request)
        {
            return Create(
                request.PaymentType,
                request.Amount,
                request.DateOfPayment,
                request.Orders,
                id);
        }

        public static Payment From(CreatePaymentRequest request)
        {
            return Create(
                request.PaymentType,
                request.Amount,
                request.DateOfPayment,
                request.Orders);
        }
    }
}
