namespace BetterThanHome.Contracts._Delivery
{
    public record UpsertDeliveryRequest(
        string DeliveryAddress,
        DateTime DateOfDelivery,
        List<Order> OrderList);
}
