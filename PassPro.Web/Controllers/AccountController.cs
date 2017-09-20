using PassPro.Business;
using PassPro.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassPro.Entities;

namespace PassPro.Web.Controllers
{
    public class AccountController : Controller
    {
        BllAccount _logic;
        ValidateCode _validate;
        public AccountController()
        {
            _logic = new BllAccount();
            _validate = new ValidateCode();
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        public JsonResult LoginForUser(string username, string pwd)
        {
            OperateStatus status;
            var userdata = _logic.Login(username, pwd, out status);
            if (userdata != null)
            {
                //登录用户写入session
                Session["user"] = userdata;
                string ip;
                if (HttpContext.Request.ServerVariables["HTTP_VIA"] != null)
                {
                    ip = HttpContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
                }
                else
                {
                    ip = HttpContext.Request.ServerVariables["REMOTE_ADDR"].ToString();
                }
                //登录次数cookie
                HttpCookie times = this.HttpContext.Request.Cookies["logtimes"];
                HttpCookie time = this.HttpContext.Request.Cookies["logtime"];
                HttpCookie ipcookie = this.HttpContext.Request.Cookies["logip"];
                if (times == null)
                {
                    times = new HttpCookie("logtimes", "0");
                }
                if (time == null)
                {
                    time = new HttpCookie("logtime", DateTime.Now.ToString());
                }
                if (ipcookie == null)
                {
                    ipcookie = new HttpCookie("logip", ip);
                }
                time.Expires = DateTime.Now.AddYears(1);
                ipcookie.Expires = DateTime.Now.AddYears(1);
                time.Value = DateTime.Now.ToString();
                ipcookie.Value = ip;
                times.Expires = DateTime.Now.AddYears(1);
                times.Value = (int.Parse(times.Value) + 1).ToString();
                this.HttpContext.Response.Cookies.Add(time);
                this.HttpContext.Response.Cookies.Add(ipcookie);
                this.HttpContext.Response.Cookies.Add(times);
            }
            return Json(status);
        }
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <returns></returns>
        public ActionResult GetValidateCode()
        {
            string code = _validate.CreateValidateCode(4);
            Session["ValidateCode"] = code;
            byte[] bytes = _validate.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }

        public JsonResult ResisterUser(user user)
        {
            OperateStatus status = new OperateStatus();
            //获取session验证码
            var code = Session["ValidateCode"].ToString();
            //比较用户输入验证码是否和session验证码一致
            if (code != user.ValidateCode)
            {
                status.Message = "验证码不一致";
                status.Success = false;
            }
            else
            {
                _logic.Registe(user, out status);
            }
            //如果不一致，需要提示，一致则调用BLL层方法
            return Json(status);
        }

        public RedirectToRouteResult LoginOut()
        {

            if (HttpContext.Session["user"] != null)
            {
                HttpContext.Session.Remove("user");
            }
            return RedirectToAction("Login");
        }
    }
}