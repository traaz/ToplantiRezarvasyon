using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarAppMVC.Models;

namespace CalendarAppMVC.Controllers
{
    public class FirstPageController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {

            return RedirectToAction("FirstPage"); 

            
        }
        public IActionResult FirstPage()
        {



            return View();
        }
    }
}
