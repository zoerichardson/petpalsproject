using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PetPals
{
    public class UserProfile : IAuthorizationRequirement
    {
        public UserProfile()
        {         
            
        }
    }
}
