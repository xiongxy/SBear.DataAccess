using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using SBear.DataAccess.WebTest.Models;

namespace SBear.DataAccess.WebTest.Controllers
{
    public class HomeController : Controller
    {
        private Class _class;
        public HomeController(Class @class)
        {
            _class = @class;
        }

        public IActionResult Index()
        {
            var vava = _class.Connection();
            return View();
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
