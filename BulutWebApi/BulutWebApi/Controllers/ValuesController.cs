using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using BulutWebApi.Models;

namespace BulutWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        
        [HttpGet]
        public JsonResult Get()
        {
            string sqlconnectionstring = "Server=localhost\\SQLEXPRESS;Database=malpazari;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select * from blt_01_01_product a";
            con.Open();
            SqlDataReader dr = cmm.ExecuteReader();
            Product product = null;
            List<Product> productList = new List<Product>();
            while (dr.Read())
            {
                product = new Product();
                product.productid = dr.GetInt32(0);
                product.productName = dr.GetString(1);
                product.productPrice = dr.GetDecimal(2);
                productList.Add(product);
            }
            con.Close();
            return Json(productList); ;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
