using BetterThanHome.Application.Common.Interfaces.Authentication;
using System.Runtime.CompilerServices;

namespace BetterThanHome.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IJWTokenGenerator _jWTokenGenerator;

        public AuthenticationService(IJWTokenGenerator jWTokenGenerator)
        {
            _jWTokenGenerator = jWTokenGenerator;
        }
        public AuthenticationResult Login(string email, string password)
        {
            // Check if user already exists

            // Create user (generate unique ID)

            // Create Token
            //Guid userId= Guid.NewGuid();

            // var token = _jWTokenGenerator.GenerateToken(userId, firstName, lastName);

            return new AuthenticationResult(
                Guid.NewGuid(),
                "firstName",
                "lastName",
                email,
                "token");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            // Check if user already exists

            // Create user (generate unique ID)

            // Create Token
            Guid userId = Guid.NewGuid();

            var token = _jWTokenGenerator.GenerateToken(userId, firstName, lastName);

            return new AuthenticationResult(
                Guid.NewGuid(),
                firstName,
                lastName,
                email,
                "token");
        }
    }
}

