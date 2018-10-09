using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmsReceiver.Services;
using SmsReceiver.Models;

namespace SmsReceiver.Controllers
{
    public class HomeController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(NumberSearchViewModel model)
        {
            if (ModelState.IsValid)
            {
               
            }
            return View(model);
        }
    }
}
