namespace BetterThanHome.Contracts._Delivery
{
    public record DeliveryResponse(
        Guid Id,
        string DeliveryAddress,
        DateTime DateOfDelivery,
        List<Order> OrderList);
}
