using BetterThanHome.Contracts._Guest;

namespace BetterThanHome.Application.Models.GuestModel
{
    public class Guest
    {
        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public int PhoneNr { get; }
        public string Location { get; }

        public Guest(
            Guid id,
            string firstName,
            string lastName,
            string email,
            int phoneNr,
            string location)
        {
            // enfroce any logic we want
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNr = phoneNr;
            Location = location;
        }

        private static Guest Create(
            string firstName,
            string lastName,
            string email,
            int phoneNr,
            string location,
            Guid? id = null)
        {
            return new Guest(
                id ?? Guid.NewGuid(),
                firstName,
                lastName,
                email,
                phoneNr,
                location);
        }

        public static Guest From(Guid id, UpsertGuestRequest request)
        {
            return Create(
                request.FirstName,
                request.LastName,
                request.Email,
                request.PhoneNr,
                request.Location,
                id);
        }

        public static Guest From(CreateGuestRequest request)
        {
            return Create(
                request.FirstName,
                request.LastName,
                request.Email,
                request.PhoneNr,
                request.Location);
        }
    }
}
