namespace BetterThanHome.Contracts.Authnetication
{
    public record LoginRequest(
        string Email,
        string Password);
}
