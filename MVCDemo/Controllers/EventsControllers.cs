using MVCDemo.Models;
using Microsoft.AspNetCore.Mvc;
namespace MVCDemo.Controllers
{
    
    public class EventsController : Controller
    {
        public List<Booking> events { get; set; }
        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Tittle = "ask CEO", EventDate = DateTime.Today, Qty = 10 });
            return View(events);
        }
    }
}
