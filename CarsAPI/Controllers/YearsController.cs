﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarsAPI.Controllers
{
    public class YearsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}