﻿using Microsoft.AspNetCore.Mvc;

namespace TatBlog.WebApp.Areas.Admin.Controllers
{
    public class DashboardControlles : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
