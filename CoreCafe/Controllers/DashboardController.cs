﻿using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
