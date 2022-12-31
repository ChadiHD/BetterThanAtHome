namespace BetterThanHome.Contracts._Guest
{
    public record GuestResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        int phoneNr,
        string Location);
}
