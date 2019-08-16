﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ATM_lab.Models;

namespace ATM_lab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string cardNumber)
        {
            if (cardNumber.Length > 16)
            {
                ViewData["ErrMessage"] = "A card with this nmber does not exist";

                return RedirectToAction("Error", "Home");
            }

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
