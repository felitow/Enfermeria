using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;


namespace Enfer.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            await Task.Delay(3000);
            var anonimous = new ClaimsIdentity();
            var oapUser = new ClaimsIdentity(new List<Claim>
            {
            new Claim(ClaimTypes.Name, "Carlos"),
            new Claim("LastName", "O"),
            new Claim(ClaimTypes.Email, "oap@yopmail.com"),
            new Claim(ClaimTypes.Role, "Admin"),

            new Claim(ClaimTypes.Name, "Juan Felipe"),
            new Claim("LastName", "Blanco Orrego"),
            new Claim(ClaimTypes.Email, "juanfelipeblancoorrego@gmail.com"),
            new Claim(ClaimTypes.Role, "Admin")
            },
            authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(oapUser)));
        }


    }
}
