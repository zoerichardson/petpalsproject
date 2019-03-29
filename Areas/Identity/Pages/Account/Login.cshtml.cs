using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PetPals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using PetPals.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;

namespace PetPals.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly ApplicationDbContext _context;

        //session variables for holding logged user data - customer
        public const string SessionKeyCustomerID = "_CustomerID";
        public  string SessionInfoCustomerID { get; private set; }
   
        public const string SessionKeySitterID = "_SitterID";
        public string SessionInfoSitterID { get; private set; }

        public const string SessionKeyProfileAccount = "_ProfileAccount";
        public string SessionInfoProfileAccount { get; private set; }

        public const string SessionKeyLoggedIn = "_LoggedIn";
        public string SessionInfo_LoggedIn { get; private set; }

        public const string SessionKeyLogIn = "_LogIn";
        public string SessionInfo_LogIn { get; private set; }

        public LoginModel(SignInManager<IdentityUser> signInManager, ILogger<LoginModel> logger, ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public Sitter Sitter { get; set; }
        public Customer Customer { get; set; }
        public IList<IdentityUser> Users { get; set; }
        
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }


        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: true);
                
                if (result.Succeeded)
                {
                   
                    if (Input.Email.Contains("@sitter.com"))//sitter login
                    {
                     
                        //getting sitter profile data for a specific user
                        var outcome = await _context.Users.FirstOrDefaultAsync(m => m.Email == Input.Email);
                        int userid = Convert.ToInt32(outcome.Id);
                        Sitter = await _context.Sitter.FirstOrDefaultAsync(m => m.ID == userid);
                      
                        //data being stored into sessions              
                        HttpContext.Session.SetString(SessionKeySitterID, Sitter.ID.ToString());

                        _logger.LogInformation("User logged in.");
                        return RedirectToPage("../Sitters/Index");
                    }
                    else
                    {
                        //getting customer profile data for a specific user
                        var outcome = await _context.Users.FirstOrDefaultAsync(m => m.Email == Input.Email);
                       int userid = Convert.ToInt32(outcome.Id);
                        Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID == userid);
                     
                        //data being stored into sessions
                        HttpContext.Session.SetString(SessionKeyCustomerID, Customer.ID.ToString());
                 
                        _logger.LogInformation("User logged in.");//customer login

                        //check to see if customer is in the process of making a booking or is just logging in
                        //based on session variables
                        if (HttpContext.Session.GetString(SessionKeyLogIn) == null)
                        {                   
                            HttpContext.Session.SetString(SessionKeyLoggedIn, "UserLoggedIn");
                            
                            return RedirectToPage("../Customers/Index");
                        }
                        else
                        {
                            HttpContext.Session.SetString(SessionKeyLoggedIn, "UserLoggedIn");
                            return RedirectToPage("../BookingReview");
                           
                        }
                        
                    }
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }



        public interface IAuthorizationService
        {

            Task<bool> AuthorizeAsync(ClaimsPrincipal user, IEnumerable<IAuthorizationRequirement> requirements);
        }
    }
}
