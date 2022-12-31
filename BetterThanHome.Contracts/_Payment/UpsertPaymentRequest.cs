namespace BetterThanHome.Contracts._Payment
{
    public record UpsertPaymentRequest(
        string PaymentType,
        decimal Amount,
        DateTime DateOfPayment,
        List<Order> Orders);
}
