using BetterThanHome.Application.Models.OrderModel;

namespace BetterThanHome.Application.Services.Orders
{
    public interface IOrderService
    {
        void CreateOrder(Order order);
        void DeleteOrder(Guid id);
        Order GetOrder(Guid id);
        UpsertedOrder UpsertOrder(Order order);
    }
}
