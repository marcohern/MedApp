using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MedApp.Filters
{
    public class Secure : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Contains("Token")) {
                string token = actionContext.Request.Headers.GetValues("Token").First();
                
            }
            base.OnActionExecuting(actionContext);
        }
    }
}