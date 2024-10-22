using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using BlogSharp2024.WebSite.ApiClient;
using BlogSharp2024.WebSite.ApiClient.DTO;

namespace BlogSharp2024.WebSite.Controllers;

public class AccountController : Controller
{

    IRestClient _client;

    public AccountController(IRestClient client)
    {
        _client = client;
    }




    //shows the login form
    [HttpGet]
    public IActionResult Login() => View();

   // receives the login form on submit
    [HttpPost]
    public async Task<IActionResult> Login([FromForm] Author loginInfo, [FromQuery] string returnUrl)
    {
        int userId = _client.TryLogin(loginInfo.Email, loginInfo.Password);
        
        if (userId > 0) { await SignIn(loginInfo); }
        if (string.IsNullOrEmpty(returnUrl)) { return RedirectToAction(); }
        return View();
    }

    //creates the authentication cookie with claims
    private async Task SignIn(Author loginInfo)
    {
        var claims = new List<Claim>
    {
        new Claim("id",user.Id.ToString()),
        new Claim(ClaimTypes.Name, user.UserName),
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.Role, user.Role.ToString()),
    };

        var claimsIdentity = new ClaimsIdentity(
            claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var authProperties = new AuthenticationProperties
        {
            #region often used options - to consider including in cookie
            //AllowRefresh = <bool>,
            // Refreshing the authentication session should be allowed.

            //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
            // The time at which the authentication ticket expires. A 
            // value set here overrides the ExpireTimeSpan option of 
            // CookieAuthenticationOptions set with AddCookie.

            //IsPersistent = true,
            // Whether the authentication session is persisted across 
            // multiple requests. When used with cookies, controls
            // whether the cookie's lifetime is absolute (matching the
            // lifetime of the authentication ticket) or session-based.

            //IssuedUtc = <DateTimeOffset>,
            // The time at which the authentication ticket was issued.

            //RedirectUri = <string>
            // The full path or absolute URI to be used as an http 
            // redirect response value. 
            #endregion
        };

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity),
            authProperties);

        TempData["Message"] = $"You are logged in as {claimsIdentity.Name}";
    }

    ////deletes the authentication cooke
    //public async Task<IActionResult> LogOut()
    //{
    //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    //    TempData["Message"] = "You are now logged out.";
    //    return RedirectToAction("Index", "");
    //}

    ////displayed if an area is off-limits, based on an authenticated user's claims
    //public IActionResult AccessDenied() => View();
}
