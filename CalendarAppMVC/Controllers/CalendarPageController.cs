using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarAppMVC.Controllers
{
    public class CalendarPageController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalendarView(string id)
        {

            ViewBag.deger1 = "2";

            return View();
        }


      
    }
}
