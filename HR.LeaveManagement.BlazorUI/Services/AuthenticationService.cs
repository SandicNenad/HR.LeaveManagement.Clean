using Blazored.LocalStorage;
using HR.LeaveManagement.BlazorUI.Contracts;
using HR.LeaveManagement.BlazorUI.Services.Base;

namespace HR.LeaveManagement.BlazorUI.Services
{
    public class AuthenticationService : BaseHttpService, IAuthenticationService
    {
        public AuthenticationService(IClient client, ILocalStorageService localSotrage) : base(client, localSotrage)
        {
        }

        public Task<bool> AuthenticateAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterAsync(string firstName, string lastName, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
