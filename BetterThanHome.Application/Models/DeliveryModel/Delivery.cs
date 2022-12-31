using BetterThanHome.Contracts._Delivery;
using BetterThanHome.Contracts;

namespace BetterThanHome.Application.Models.DeliveryModel
{
    public class Delivery
    {
        public Guid Id { get; }
        public string DeliveryAddress { get; }
        public DateTime DateOfDelivery { get; }
        public List<Order> OrderList { get; }

        public Delivery(
            Guid id,
            string deliveryAddress,
            DateTime dateOfDelivery,
            List<Order> orderList)
        {
            Id = id;
            DeliveryAddress = deliveryAddress;
            DateOfDelivery = dateOfDelivery;
            OrderList = orderList;
        }

        private static Delivery Create(
            string deliveryAddress,
            DateTime dateOfDelivery,
            List<Order> orderList,
            Guid? id = null)
        {
            return new Delivery(
                id ?? Guid.NewGuid(),
                deliveryAddress,
                dateOfDelivery,
                orderList);
        }

        public static Delivery From(Guid id, UpsertDeliveryRequest request)
        {
            return Create(
                request.DeliveryAddress,
                request.DateOfDelivery,
                request.OrderList,
                id);
        }

        public static Delivery From(CreateDeliveryRequest request)
        {
            return Create(
                request.DeliveryAddress,
                request.DateOfDelivery,
                request.OrderList);
        }
    }
}
