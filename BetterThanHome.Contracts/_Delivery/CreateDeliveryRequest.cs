namespace BetterThanHome.Contracts._Delivery
{
    public record CreateDeliveryRequest(
        string DeliveryAddress,
        DateTime DateOfDelivery,
        List<Order> OrderList);
}
