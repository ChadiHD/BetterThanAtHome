namespace BetterThanHome.Contracts._Guest
{
    public record CreateGuestRequest(
        string FirstName,
        string LastName,
        string Email,
        int PhoneNr,
        string Location);
}
