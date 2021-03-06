﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab21.Models;

namespace Lab21.Controllers
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
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = UserList.userList.Count + 1;
                UserList.userList.Add(user);
                return RedirectToAction("details", new { Id = user.Id });
            }
            return View();
        }

        public ViewResult Welcome(int ? id)
        {
            return View(UserList.userList.FirstOrDefault(e => e.Id == id));
        }
        public ViewResult Details(int? id)
        {
            ViewBag.PageTitle = "User Details";
            return View(UserList.userList.FirstOrDefault(e => e.Id == id));
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
