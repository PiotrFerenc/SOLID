#Dependency inversion
##odwrócona zależność

Tworzymy komponenty w takie sposób żeby klasy wyższego poziomu (```AuthenticatorManager```) nie były zależne od klas niższego poziomu (```Authenticator```). Żeby to osiągnąć użyjemy abstrakcji. 


źle
```c#
    public class AuthenticatorManager
    {
        private readonly GoogleAuthenticator _authenticator = new GoogleAuthenticator();

        public void TryAuthenticate()
        {
            _authenticator.Authenticate();
        }
    }

```

Dobrze
```c#
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

```