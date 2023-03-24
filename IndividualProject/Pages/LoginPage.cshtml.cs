using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using IndividualProject.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace IndividualProject.Pages
{
    public class LoginPageModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        private DatabaseContext db;

        public string Message;

        public LoginPageModel(DatabaseContext _db)
        {
            db = _db;
        }


        public void OnGet()
        {
            
        }

        
        public IActionResult OnPostButton1(IFormCollection data)
        {
            
            user.Username = Request.Form["username"];
            user.Password = Request.Form["pswd"];
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.Email = Request.Form["email"];
            user.Role = "user";
            db.Users.Add(user);
            db.SaveChanges();
           
            return new RedirectToPageResult("Store");
        }


        ///if (ModelState.IsValid)
//{

//    // Sets a cookie which expires in 7 days
//    CookieOptions cOptions = new CookieOptions();
//    cOptions.Expires = DateTime.Now.AddDays(7);
//    Response.Cookies.Append("username", user.Username, cOptions);

//    return RedirectToPage("Index");
//}
//else
//{
//    return Page();
//}
public IActionResult OnPostButton2( string? returnUrl)
        {
            user.Email = Request.Form["email"];
            user.Password = Request.Form["pswd"];
            var usr = Login(user.Email, user.Password);

            if (usr == null)
            {
                Message = "Sorry, seams that this account doesn't exist";

            }
            // else {
            //    HttpContext.Session.SetString("username", user.Username);
            //    return RedirectToPage("/Store");
            //}

            //return null;

            if (usr != null)
            {
               
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, user.Email));
                //claims.Add(new Claim(ClaimTypes.Role, user.Role));
                if ("toderascuiulia@gmail.com" == user.Email || "bob@yahoo.com" == user.Email)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "admin"));
                }
                else if ("business@yahoo.com" == user.Email)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "business"));
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, "user"));
                }
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                
                if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    // return Redirect(returnUrl);
                    return RedirectToPage("Store");
                }
                else
                {
                    return RedirectToPage("Store");
                }

            }
            else
            {

                ModelState.AddModelError("InvalidCredentials", "The supplied username and/or password is invalid");
                return Page();
                //return RedirectToPage("Store");
            }
           
        }


        

        private User Login(string email, string password)
        {
            var user = db.Users.SingleOrDefault(a => a.Email.Equals(email));
            if(user != null)
            {
                if(BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    return user;
                }
                
                if(password == user.Password)
                {
                    return user;
                }
            }
            return null;
        }

        }
}
