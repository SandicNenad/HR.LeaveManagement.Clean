using Blazored.LocalStorage;
using HR.LeaveManagement.BlazorUI.Contracts;
using HR.LeaveManagement.BlazorUI.Services.Base;

namespace HR.LeaveManagement.BlazorUI.Services
{
    public class AuthenticationService : BaseHttpService, IAuthenticationService
    {
        public AuthenticationService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
        }

        public async Task<bool> AuthenticateAsync(string email, string password)
        {
            try
            {
                AuthRequest authenticationRequest = new AuthRequest() { Email = email, Password = password };
                var authenticationResponse = await _client.LoginAsync(authenticationRequest);

                if (authenticationResponse.Token != string.Empty)
                {
                    await _localStorage.SetItemAsync("token", authenticationResponse.Token);

                    // Set claims in Blazor and login state

                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }            
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("token");
            // Remove claims in Blazor and invalidate login state
        }

        public Task<bool> RegisterAsync(string firstName, string lastName, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
