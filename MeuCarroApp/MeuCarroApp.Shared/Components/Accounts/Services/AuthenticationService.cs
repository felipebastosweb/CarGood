using MeuCarroApp.Shared.Components.Accounts.Records;
using MeuCarroApp.Shared.Components.Core.Entities;

namespace MeuCarroApp.Shared.Components.Accounts.Services
{
    public class AuthenticationService
    {
        public LoginOutput? currentUser { get; set; }

        public void Login(LoginOutput user)
        {
            currentUser = user;
        }

        public void Logout()
        {
            currentUser = null;
        }

        public bool IsAuthenticated()
        {
            return currentUser != null;
        }
    }

}
