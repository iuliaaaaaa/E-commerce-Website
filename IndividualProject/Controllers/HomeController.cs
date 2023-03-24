//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using MySql.Data.MySqlClient;
//using System.Data;

//namespace IndividualProject.Controllers
//{
//    public class HomeController : Controller
//    {
//        [Authorize(Roles = "admin,user")]
//        public IActionResult Index()
//        {
//            return View();
//        }

//        [Authorize(Roles= "admin")]
//        public IActionResult AdminView()
//        {
//            ViewData["Message"] = "Only admin has access to this page";
//            return View();
//        }

//        [Authorize(Roles = "admin,user,business")]
//        public IActionResult Store()
//        {
//            //ViewData["Store"] = "Store page";
//            return View();
//        }

//        public IActionResult Cart()
//        {
//            MySqlConnection con = new MySqlConnection();
//            string path = "Server=studmysql01;Database=dbi475741;uid=dbi475741;password=1234;";
//            con.ConnectionString = path;
//            DataTable dt = new DataTable();

//            try
//            {
//                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from cart", con);
//                adapter.Fill(dt);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//            return View(dt);

//        }
//    }
//}
