namespace BetterThanHome.Contracts._Payment
{
    public record CreatePaymentRequest(
        string PaymentType,
        decimal Amount,
        DateTime DateOfPayment,
        List<Order> Orders);
}
