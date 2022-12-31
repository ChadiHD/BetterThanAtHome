using BetterThanHome.Application.Models.OrderModel;

namespace BetterThanHome.Application.Services.Orders
{
    public class OrderService : IOrderService
    {
        private static readonly Dictionary<Guid, Order> _orders = new();

        public void CreateOrder(Order order)
        {
            _orders.Add(order.Id, order);
        }

        public void DeleteOrder(Guid id)
        {
            _orders.Remove(id);
        }

        public Order GetOrder(Guid id)
        {
            return _orders[id];
        }

        public UpsertedOrder UpsertOrder(Order order)
        {
            var isNewlyCreated = !_orders.ContainsKey(order.Id);

            _orders[order.Id] = order;

            return new UpsertedOrder(isNewlyCreated);
        }
    }
}
