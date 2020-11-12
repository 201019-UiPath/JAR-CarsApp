using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarsAPI.Controllers
{   
    [Route("[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
