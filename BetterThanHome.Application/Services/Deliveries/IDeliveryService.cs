using BetterThanHome.Application.Models.DeliveryModel;

namespace BetterThanHome.Application.Services.Deliveries
{
    public interface IDeliveryService
    {
        void CreateDelivery(Delivery delivery);
        void DeleteDelivery(Guid id);
        Delivery GetDelivery(Guid id);
        UpsertedDelivery UpsertDelivery(Delivery delivery);
    }
}
