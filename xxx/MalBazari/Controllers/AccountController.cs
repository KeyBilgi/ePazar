using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entities.Congrete;
using DataAccess.Congrete;

namespace MalBazari.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult LogIn()
        {
            Users users = new Users();
            var user = users.GetFromServer("http://localhost:52474/api/user", null);
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(Entities.Congrete.Blt0101Users user)
        {
            return View(user);
        }
    }
}
