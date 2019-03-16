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
            Users<Blt0101Users> users = new Users<Blt0101Users>();
            var user = Core.Utils.Api<Blt0101Users>.MakeWebRequest("http://localhost:52474/api/user", 10);
            return View(user.Result);
        }
        [HttpPost]
        public IActionResult LogIn(Entities.Congrete.Blt0101Users user)
        {
            Users<Blt0101Users> users = new Users<Blt0101Users>();

            return View(user);
        }
    }
}
