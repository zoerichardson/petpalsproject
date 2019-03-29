using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;


namespace PetPals.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LogoutModel> _logger;


        public const string SessionKeyProfileAccount = "_ProfileAccount";
        public string SessionInfo_ProfileAccount { get; private set; }

        public const string SessionKeyLoggedIn = "_LoggedIn";
        public string SessionInfo_LoggedIn { get; private set; }

        public const string SessionKeyLogIn = "_LogIn";
        public string SessionInfo_LogIn { get; private set; }

        public const string SessionKeyCustomerID = "_CustomerID";
        public string SessionInfoCustomerID { get; private set; }

        public const string SessionKeySitterID = "_SitterID";
        public string SessionInfoSitterID { get; private set; }

        public LogoutModel(SignInManager<IdentityUser> signInManager, ILogger<LogoutModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {

            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");

            if (returnUrl != null)
            {
                HttpContext.Session.Remove(SessionKeyLoggedIn);
                HttpContext.Session.Remove(SessionKeyLogIn);
                HttpContext.Session.Remove(SessionKeyProfileAccount);
                HttpContext.Session.Remove(SessionKeyCustomerID);
                HttpContext.Session.Remove(SessionKeySitterID);
                return LocalRedirect(returnUrl);
            }
            else
            {
                HttpContext.Session.Remove(SessionKeyLoggedIn);
                HttpContext.Session.Remove(SessionKeyLogIn);
                HttpContext.Session.Remove(SessionKeyProfileAccount);
                HttpContext.Session.Remove(SessionKeyCustomerID);
                HttpContext.Session.Remove(SessionKeySitterID);
                return Page();
                
            }
        }
    }
}