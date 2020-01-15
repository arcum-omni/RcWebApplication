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
                // Add to database
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Model state is invalid
                // let user view errors
                return View();
            }
        }
    }
}