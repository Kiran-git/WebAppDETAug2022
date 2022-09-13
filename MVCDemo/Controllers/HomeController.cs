﻿using Microsoft.AspNetCore.Mvc;
using MVCDemo.Filters;
using MVCDemo.Models;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Helocshtml(string name, string Location, string contact)
        {
           // string myname = "Kiran"
            ViewBag.UserName = name;
            ViewBag.Location = Location;
            ViewBag.Contact = contact;
            return View();
        }
        [MyLog]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}