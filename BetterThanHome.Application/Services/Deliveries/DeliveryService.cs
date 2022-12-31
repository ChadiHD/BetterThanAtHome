using BetterThanHome.Application.Models.DeliveryModel;

namespace BetterThanHome.Application.Services.Deliveries
{
    public class DeliveryService : IDeliveryService
    {
        private static readonly Dictionary<Guid, Delivery> _deliveries = new();

        public void CreateDelivery(Delivery delivery)
        {
            _deliveries.Add(delivery.Id, delivery);
        }

        public void DeleteDelivery(Guid id)
        {
            _deliveries.Remove(id);
        }

        public Delivery GetDelivery(Guid id)
        {
            return _deliveries[id];
        }

        public UpsertedDelivery UpsertDelivery(Delivery delivery)
        {
            var isNewlyCreated = !_deliveries.ContainsKey(delivery.Id);
            _deliveries[delivery.Id] = delivery;
            return new UpsertedDelivery(isNewlyCreated);
        }
    }
}
