using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassPro.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["user"] == null)
            {
                filterContext.HttpContext.Response.Redirect("/Account/Login");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}