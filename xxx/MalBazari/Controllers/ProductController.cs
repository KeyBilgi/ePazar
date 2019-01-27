using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MalBazari.Models;
using System.Net.Http;
using Newtonsoft.Json;
using DataAccess.Congrete;
namespace MalBazari.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Products([FromForm]Product product)
        {
            return View("Products", product);
        }
        [HttpGet]
        public IActionResult SingleView()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Products2()
        {
            DataAccess.Congrete.Products products = new DataAccess.Congrete.Products();
            Models.ViewModels.VProduct vProduct = new Models.ViewModels.VProduct();
            var list = products.GetListFromServer("http://localhost:52474/api/values", null);
            foreach(Entities.Congrete.Product p in list.Result)
            {
                vProduct.productList.Add(p);
            }
            return View(vProduct);
        }

        
    }
}
