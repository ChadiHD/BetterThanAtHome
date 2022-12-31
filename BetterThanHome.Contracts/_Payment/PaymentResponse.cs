namespace BetterThanHome.Contracts._Payment
{
    public record PaymentResponse(
        Guid Id,
        string PaymentType,
        decimal Amount,
        DateTime DateOfPayment,
        List<Order> Orders);
}
