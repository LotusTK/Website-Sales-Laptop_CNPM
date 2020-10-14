using FinalTerm_CNPM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FinalTerm_CNPM.Controllers
{
    public class LoginController : Controller
    {
        private UserDAO userDAO = new UserDAO(new FinalTermContext());
     
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            User user = userDAO.validateUser(model.userName, model.password);
            if(user == null)
            {
                return Json(new { status = "fail", message = "Incorrect username or password" });
            }

            //cấp quyền cookie
            FormsAuthentication.SetAuthCookie(user.userName, false);
            //tạo ticket (nội dung cookie): version, tên user, ngày tạo, ngày hết, lưu trữ, dữ liệu (roles)
            var ticket = new FormsAuthenticationTicket(1, user.userName, DateTime.Now, DateTime.Now.AddDays(1), false, user.userRole) ;
            //mã hóa
            var encrypted = FormsAuthentication.Encrypt(ticket);
            //
            var authcookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
            //
            HttpContext.Response.Cookies.Add(authcookie);
            //tên của cookie được xác định trong Web.config
            return Redirect("/Home");
        }
    }
}