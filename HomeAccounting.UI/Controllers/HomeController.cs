﻿using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccounting.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccounting _accountingService;
        public HomeController(ILogger<HomeController> logger, IAccounting accountingService)
        {
            _logger = logger;
            _accountingService = accountingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Temporary
        public IActionResult CreateAccount()
        {
            _accountingService.CreateAccount(new Account()
            {
                Title = "Test",
                CreationDate = DateTime.Now
            });

            return Json(new { StatusCode = true });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
