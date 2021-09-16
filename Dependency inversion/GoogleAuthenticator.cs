using System;

namespace Dependency_inversion
{
    public class GoogleAuthenticator : IAuthenticator
    {
        public bool Authenticate()
        {
            Console.WriteLine("Google auth..");
        }
    }
}