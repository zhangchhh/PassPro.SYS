using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassPro.Web.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            string loginTimes ="";
            string loginTime = "";
            string loginip = "";
            HttpCookie times = this.HttpContext.Request.Cookies["logtimes"];
            HttpCookie time = this.HttpContext.Request.Cookies["logtime"];
            HttpCookie ipcookie = this.HttpContext.Request.Cookies["logip"];
            if (times != null)
            {
                loginTimes = times.Value;
            }
            if (time != null)
            {
                loginTime = time.Value;
            }
            if (ipcookie != null)
            {
                loginip = ipcookie.Value;
            }
            ViewData["logtimes"] = loginTimes;
            ViewData["logtime"] = loginTime;
            ViewData["loginip"] = loginip;
            return View();
        }
    }
}