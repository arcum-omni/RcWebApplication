using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RcWebApplication.Models;

namespace RcWebApplication.Controllers
{
    public class ModelBindingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Vehicle v)
        {
            if (ModelState.IsValid)
            {
                // VehicleDB.Add(v); // Add object to database

                // return RedirectToAction("Index", "Home"); // I didn't like this meathod, because I wouldn't know if my ADD was successful or the page crashed and reloaded.
                
                ViewData["Message"] = "Vehicle Added Successfully";
                return View();
            }
            else
            {
                // Model state is invalid, let user view errors
                return View();
            }
        }
    }
}