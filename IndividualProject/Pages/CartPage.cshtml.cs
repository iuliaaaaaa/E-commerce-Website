using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace IndividualProject.Pages
{
    public class CartPageModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            MySqlConnection con = new MySqlConnection();
            string path = "Server=studmysql01;Database=dbi475741;uid=dbi475741;password=1234;";
            con.ConnectionString = path;
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from cart", con);
                adapter.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            //return dt;
        }
    }
}
