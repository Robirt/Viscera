using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Viscera.WebUI.Services;

public class AuthenticationStateService : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
    }
}
