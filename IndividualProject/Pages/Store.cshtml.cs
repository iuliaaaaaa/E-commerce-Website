using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using IndividualProject.Models;

namespace IndividualProject.Pages
{
    [Authorize(Roles = "admin, business, user")]
    public class StoreModel : PageModel
    {
        [BindProperty]
        public Products Product { get; set; }
        

        private DatabaseContext db;

        public StoreModel(DatabaseContext _db)
        {
            db = _db;
        }
        

    public string UsernameFromSession;
        public string UsernameFromCookie;
        public void OnGet()
        {
            //    if (Request.Cookies.ContainsKey("username"))
            //    { UsernameFromCookie = Request.Cookies["username"]; }
            //    else
            //    { UsernameFromCookie = "Guest"; }


            //    HttpContext.Session.Remove("key"); // Removes specific session
            //    HttpContext.Session.Clear(); // Removes all sessions

            //    if (Request.Cookies.ContainsKey("username"))
            //    { UsernameFromCookie = Request.Cookies["username"]; }
            //    else
            //    { UsernameFromCookie = "Guest"; }

            //    if (HttpContext.Session.Get("username") != null)
            //    { UsernameFromSession = HttpContext.Session.GetString("username"); }
            //    else
            //    { UsernameFromSession = "Guest"; }


            //}

        }
        
       
        public IActionResult OnPostAddToCart1(IFormCollection data)
        {
            IDictionary<string, int> productDetails = new Dictionary<string, int>();
            productDetails.Add("Silk scarf", 15);
            productDetails.Add("Stone cup holders", 6);
            productDetails.Add("Statue flower vase", 25);
            productDetails.Add("Traditional romanian pattern puzzle", 17);
            productDetails.Add("Stone clock", 50);
            productDetails.Add("Green statue vase", 27);
            productDetails.Add("Drawing book with illustrations", 45);
            productDetails.Add("Green and gold tea set", 99);
            productDetails.Add("Golden Vase", 25);

            cartPage cartPage = new cartPage();
            cartPage.Name = productDetails.ElementAt(1).Key;
            cartPage.Price = productDetails.ElementAt(1).Value;

            db.CartPage.Add(cartPage);

            return RedirectToPage("Store");
        }
               
        public IActionResult OnPostAddToCart2(IFormCollection data)
        {
            IDictionary<string, int> productDetails = new Dictionary<string, int>();
            productDetails.Add("Silk scarf", 15);
            productDetails.Add("Stone cup holders", 6);
            productDetails.Add("Statue flower vase", 25);
            productDetails.Add("Traditional romanian pattern puzzle", 17);
            productDetails.Add("Stone clock", 50);
            productDetails.Add("Green statue vase", 27);
            productDetails.Add("Drawing book with illustrations", 45);
            productDetails.Add("Green and gold tea set", 99);
            productDetails.Add("Golden Vase", 25);

            cartPage cartPage = new cartPage();
            cartPage.Name = productDetails.ElementAt(2).Key;
            cartPage.Price = productDetails.ElementAt(2).Value;

            db.CartPage.Add(cartPage);

            return RedirectToPage("Store");
        }

        public IActionResult OnPostAddToCart3(IFormCollection data)
        {
            IDictionary<string, int> productDetails = new Dictionary<string, int>();
            productDetails.Add("Silk scarf", 15);
            productDetails.Add("Stone cup holders", 6);
            productDetails.Add("Statue flower vase", 25);
            productDetails.Add("Traditional romanian pattern puzzle", 17);
            productDetails.Add("Stone clock", 50);
            productDetails.Add("Green statue vase", 27);
            productDetails.Add("Drawing book with illustrations", 45);
            productDetails.Add("Green and gold tea set", 99);
            productDetails.Add("Golden Vase", 25);

            cartPage cartPage = new cartPage();
            cartPage.Name = productDetails.ElementAt(3).Key;
            cartPage.Price = productDetails.ElementAt(3).Value;

            db.CartPage.Add(cartPage);

            return RedirectToPage("Store");
        }
    }
}
