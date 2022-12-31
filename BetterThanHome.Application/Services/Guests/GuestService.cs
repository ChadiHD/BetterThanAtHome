using BetterThanHome.Application.Models.GuestModel;

namespace BetterThanHome.Application.Services.Guests
{
    public class GuestService : IGuestService
    {
        private static readonly Dictionary<Guid, Guest> _guests = new();

        public void CreateGuest(Guest guests)
        {
            _guests.Add(guests.Id, guests);
        }

        public void DeleteGuest(Guid id)
        {
            _guests.Remove(id);
        }

        public Guest GetGuest(Guid id)
        {
            return _guests[id];
        }

        public UpsertedGuest UpsertGuest(Guest guests)
        {
            var isNewlyCreated = !_guests.ContainsKey(guests.Id);

            _guests[guests.Id] = guests;

            return new UpsertedGuest(isNewlyCreated);
        }
    }
}
