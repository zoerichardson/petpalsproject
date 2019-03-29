using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

namespace PetPals.Pages
{
    public class WeatherModel : PageModel
    {
        public const string SessionKeyMain = "_Main";
        public string SessionInfoMain { get; private set; }

        public const string SessionKeyDescription = "_Description";
        public string SessionInfoDescription { get; private set; }

        public const string SessionKeyTemp = "_Temp";
        public string SessionInfoTemp { get; private set; }

        public const string SessionKeyError = "_Error";
        public string SessionInfoError { get; private set; }

        public JArray array = new JArray();
        public int cod { get; set; }

        public string city { get; set; }

        public const string SessionKeyCity = "_City";
        public string SessionInfoCity { get; private set; }

        [BindProperty]
        public UserInput Input { get; set; }       

        public class UserInput
        {
            public string SelectedCity { get; set; }
        }

        public IActionResult OnGet()
        {
          
            return Page();
        }

        public IActionResult OnPost()
        {
            city = Input.SelectedCity;
            HttpContext.Session.SetString(SessionKeyCity, city);


            return Page();
        }



    }
}