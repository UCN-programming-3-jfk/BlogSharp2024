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
        //tester hos API'et om login er gyldigt
        int userId = _client.TryLogin(loginInfo.Email, loginInfo.Password);
        //i givet fald laver vi cookie
        if (userId > 0) { await SignIn(loginInfo); }
        else {
            TempData["Message"] = "Invalid login";
            return View(); 
        }
        
        if (!string.IsNullOrEmpty(returnUrl)) { return Redirect(returnUrl); }
        
        return Redirect("/");
    }

    //creates the authentication cookie with claims
    private async Task SignIn(Author loginInfo)
    {

        //vi lagrer alle de informationer
        //der ville være praktiske at have om brugeren i cookien
        var claims = new List<Claim>
    {
        new Claim("id",loginInfo.Id.ToString()),
        new Claim(ClaimTypes.Email,  loginInfo.Email),
        new Claim(ClaimTypes.Role, "Author"),
    };

        //gør klar til at gemme alle vore claims i en cookie
        var claimsIdentity = new ClaimsIdentity(
            claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var authProperties = new AuthenticationProperties();

        //logger ind

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity),
            authProperties);

        //gemmer besked til brugeren til visning i _layouts.cshtml
        TempData["Message"] = $"You are logged in as {loginInfo.Email}";
    }

    //deletes the authentication cooke
    public async Task<IActionResult> LogOut()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        TempData["Message"] = "You are now logged out.";
        return RedirectToAction("Index", "");
    }

    ////displayed if an area is off-limits, based on an authenticated user's claims
    //public IActionResult AccessDenied() => View();
}
