using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMVC.Models;

namespace CoreMVC.Controllers
{
    public class AuthenticatedController : Controller
    {

        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Secured()
        {
            return View();
        }
    }
}
