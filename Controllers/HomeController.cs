﻿using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Opdracht_ASP.NET_Core.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Opdracht_ASP.NET_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData.Model = new test();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public test dinktest { get; set; }

        /*public async Task OnPost()
        {
            var itemtest = new test();
            dinktest = test.dinkArray;
        }*/



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
