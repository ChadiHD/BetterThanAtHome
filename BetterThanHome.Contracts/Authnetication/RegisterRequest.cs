namespace BetterThanHome.Contracts.Authnetication
{
    public record RegisterRequest(
        string FirstName,
        string LastName,
        string Email,
        string Password);
}
