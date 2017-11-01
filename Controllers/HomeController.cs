using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TryMVC.Models;

namespace TryMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Models.Character.GellAll());
        }

        public IActionResult Create(string CharacterName)
        {
            Models.Character.Create(CharacterName);

            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
