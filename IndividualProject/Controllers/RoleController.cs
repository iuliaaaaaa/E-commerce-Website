//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authorization;

//namespace IndividualProject.Controllers
//{
//    public class RoleController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult LoginPage()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult LoginPage(string email, string pswd)
//        {
//            if (!string.IsNullOrEmpty(email) && string.IsNullOrEmpty(pswd))
//            {
//                return RedirectToAction("LoginPage");
//            }

//            ClaimsIdentity identity = null;
//            bool isAuth = false;

//            if (email == "toderascuiulia@gmail.com" && pswd == "1234")
//            {
//                identity = new ClaimsIdentity(new[]
//                {
//                        new Claim(ClaimTypes.Email, email),
//                        new Claim(ClaimTypes.Role, "admin"),
//                    }, CookieAuthenticationDefaults.AuthenticationScheme);
//                isAuth = true;
//            }
//            else
//            {
//                identity = new ClaimsIdentity(new[]
//                {
//                        new Claim(ClaimTypes.Email, email),
//                        new Claim(ClaimTypes.Role, "user"),
//                    }, CookieAuthenticationDefaults.AuthenticationScheme);
//                isAuth = true;
//            }

//            if (isAuth)
//            {
//                var principal = new ClaimsPrincipal(identity);
//                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
//                return RedirectToAction("Store");
//            }
//            return View();
//        }
//    }
//}
