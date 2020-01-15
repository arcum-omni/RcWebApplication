using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RcWebApplication.Models;

namespace RcWebApplication.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] // user clicks submit & sends for data, ie post data to server
        public IActionResult Index(IFormCollection data)
        {
            // Validate all form data

            // map validated form data to c# object
            Vehicle v = new Vehicle();
            v.Make = data["vehicle-make"];
            v.Model = data["vehicle-model"];
            v.BatterySize = Convert.ToInt32(data["battery-size"]);
            v.MotorSize = Convert.ToDouble(data["motor-size"]);
            v.BuildDate = Convert.ToDateTime(data["build - date"]);

            // Add to DataBase, ADO.net

            ViewData["Message"] = "Vehicle Added Successfully";

            return View();
        }
    }
}