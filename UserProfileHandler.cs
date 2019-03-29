using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetPals
{
    public class UserProfileHandler :AuthorizationHandler<UserProfile>
    {

        protected override Task HandleRequirementAsync( AuthorizationHandlerContext context, UserProfile requirement)
        {
            // Save User object to access claims
            var email = context.User.Identity.Name;

            //if email contains @sitter.com then it is a sitter logging in and the requirement has succeeded
            if (email.Contains("@sitter.com"))
            {
                context.Succeed(requirement);
            }
            //else if (!email.Contains("@sitter.com"))
            //{
            //    context.Succeed(requirement);
            //}
            else
            {
                context.Fail();
            }
           
            return Task.CompletedTask;
        }

        

    }
}
