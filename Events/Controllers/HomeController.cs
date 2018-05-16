using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Events.Models;

namespace Events.Controllers
{
    public class HomeController : Controller
    {
        //[Route("{name}/{age}")]
        //public ContentResult Index(string name, int age)
        //{
        //    return Content($"czesć jestem {name} mam {age} lat.");
        //}
        public IActionResult Index()
        {
            ViewBag.Message = "Roman";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Create()
        {          
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            UserRepository.AddUser(user);
            return View("Roman", user);
        }
    }
}
