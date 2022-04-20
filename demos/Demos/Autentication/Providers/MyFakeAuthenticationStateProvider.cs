using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace Autentication.Providers;

class MyFakeAuthenticationStateProvider : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    { // Hard-coded logged-out user
        var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity());
        return Task.FromResult(new AuthenticationState(claimsPrincipal));
    }
    //public override Task<AuthenticationState> GetAuthenticationStateAsync()
    //{ // Hard-coded logged-in user
    //    var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, "Bert") }, "fake"));
    //    return Task.FromResult(new AuthenticationState(claimsPrincipal));
    //}

    //public override Task<AuthenticationState> GetAuthenticationStateAsync()
    //{    // Hard-coded logged-in user with super admin
    //    var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, "Bert"), new Claim(ClaimTypes.Role, "superadmin") }, "fake"));
    //    return Task.FromResult(new AuthenticationState(claimsPrincipal));
    //}    

}