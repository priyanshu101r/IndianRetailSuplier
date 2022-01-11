using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier.CustomeFilter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class BaseAuthorizeAttribute : ActionFilterAttribute, IAuthorizationFilter
    {
       
       public const string NotFoundUrl = "~/Errors/401/Index.html";
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            if (user.Identity.IsAuthenticated)
            {
              
               
                return;
            }
            else 
            {
                context.Result = new UnauthorizedResult();
                context.Result = new RedirectResult(NotFoundUrl);
               
            }

        }
    }
}
