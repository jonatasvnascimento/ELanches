﻿using Microsoft.AspNetCore.Mvc;

namespace ELanches.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
