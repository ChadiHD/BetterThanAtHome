namespace BetterThanHome.Application.Common.Interfaces.Authentication
{
    public interface IJWTokenGenerator
    {
        string GenerateToken(Guid userId,string firsName, string lastName);
    }
}
