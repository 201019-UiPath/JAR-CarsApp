using System;
using CarsDB.Models;
using CarsLib.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsLib;

namespace CarsAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        private readonly CarServices carService;


        public CarsController(CarServices carService)
        {
            this.carService = carService;
        }

        [HttpGet("get")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
        //[FormatFilter]
        public IActionResult GetAllCar()
        {
            try
            {
                return Ok(carService.GetAllCar());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult AddCar(Cars newCar)
        {
            try
            {
                carService.AddCar(newCar);
                return CreatedAtAction("AddCar", newCar);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}