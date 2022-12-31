namespace BetterThanHome.Contracts._Guest
{
    public record UpsertGuestRequest(
        string FirstName,
        string LastName,
        string Email,
        int PhoneNr,
        string Location);
}
