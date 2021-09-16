using System;

namespace Dependency_inversion
{
    public class GoogleAuthenticator : IAuthenticator
    {
        public void Authenticate()
        {
            Console.WriteLine("Google auth..");
        }
    }
}