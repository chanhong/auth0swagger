using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Authentication;


public class AccountController : Controller
{
    public IActionResult Login(string returnUrl = "/")
    {
        return new ChallengeResult("Auth0", new AuthenticationProperties() { RedirectUri = returnUrl });
    }

    [Authorize]
    public IActionResult Logout()
    {
        HttpContext.Authentication.SignOutAsync("Auth0");
        HttpContext.Authentication.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        return RedirectToAction("Index", "Home");
    }
}
