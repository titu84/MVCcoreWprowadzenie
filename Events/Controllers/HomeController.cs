using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Events.Models;
using Events.Data;

namespace Events.Controllers
{
    public class HomeController : Controller
    {
        //[Route("{name}/{age}")]
        //public ContentResult Index(string name, int age)
        //{
        //    return Content($"czesć jestem {name} mam {age} lat.");
        //}
        EventsContext context;
        public HomeController(EventsContext context)
        {
            this.context = context;
        }
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
            user.Created = DateTime.Now;
            context.Users.Add(user);
            context.SaveChanges();
            return View("Roman", context.Users);
        }
        public IActionResult Roman()
        {
            return View(context.Users);
        }
    }
}
