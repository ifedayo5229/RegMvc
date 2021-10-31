using System.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using  Registermvc.Models;
using Registermvc.Services;
using Microsoft.AspNetCore.Authorization;

namespace  Registermvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRegister _register;

        public HomeController(ILogger<HomeController> logger, IRegister register)
        {
            _logger = logger;
            _register = register;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Index(RegisterViewModel model)
        {
            if(!ModelState.IsValid){ return View();}

         var result =   _register.RegisterNewUser(model);
         if (result==1)
         {
             return LocalRedirect("~/Home/Privacy");
         }
         else
         {
             return View();
         }


           
        }
    }
}
