using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Entities.Congrete;
using Core;
using Entities.Maneger;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BulutWebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public JsonResult GetAllUsers()
        {
            DataBaseContext context = new DataBaseContext();
            return Json(context.Blt0101Users);
        }
        [HttpGet]
        public JsonResult GetUser(string username)
        {
            DataBaseContext context = new DataBaseContext();
            return Json(context.Blt0101Users.First(x => x.Kod == username));
        }
        public void Get()
        {
            string sqlconnectionstring = "Server=localhost\\SQLEXPRESS;Database=malpazari;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select * from blt_01_01_product a";
            con.Open();
            SqlDataReader dr = cmm.ExecuteReader();
            //Product product = null;
            //List<Product> productList = new List<Product>();
            //while (dr.Read())
            //{
            //    product = new Product();
            //    product.productid = dr.GetInt32(0);
            //    product.productName = dr.GetString(1);
            //    product.productPrice = dr.GetDecimal(2);
            //    productList.Add(product);
            //}
            //con.Close();
            return  ;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
