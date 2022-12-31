using BetterThanHome.Application.Models.GuestModel;

namespace BetterThanHome.Application.Services.Guests
{
    public interface IGuestService
    {
        void CreateGuest(Guest guests);
        void DeleteGuest(Guid id);
        Guest GetGuest(Guid id);
        UpsertedGuest UpsertGuest(Guest guests);
    }
}
