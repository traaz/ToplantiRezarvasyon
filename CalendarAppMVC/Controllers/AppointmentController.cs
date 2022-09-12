using CalendarAppMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CalendarAppMVC.Controllers
{
    public class AppointmentController : Controller

    {
        string Baseurl = "http://korteksdev/";
        private ApplicationDbContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

    //    [HttpGet]
    //    public async Task<ActionResult> GetAppointment(int roomId = 1)
    //    {
    //        List<Appointment> eventInfo = new List<Appointment>();
    //        using (var client = new HttpClient())
    //        {
    //            client.BaseAddress = new Uri(Baseurl);
    //            client.DefaultRequestHeaders.Clear();
    //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    //            HttpResponseMessage Res = await client.GetAsync("http://korteksdev/PortalWebApi/RezervasyonListesi/Getir/1");
    //            if (Res.IsSuccessStatusCode)
    //            {
    //                //Storing the response details recieved from web api
    //                var eventResponse = Res.Content.ReadAsStringAsync().Result;
    //                //Deserializing the response recieved from web api and storing into the Employee list
    //                eventInfo = JsonConvert.DeserializeObject<List<Appointment>>(eventResponse);
    //            }
    //        }
          
    //        return View(eventInfo);
    //    }
       

    }
}
