namespace Dependency_inversion
{
    public class AuthenticatorManager
    {
        private readonly IAuthenticator _authenticator;

        public AuthenticatorManager(IAuthenticator authenticator)
        {
            _authenticator = authenticator;
        }

        public void TryAuthenticate()
        {
            _authenticator.Authenticate();
        }
    }
}