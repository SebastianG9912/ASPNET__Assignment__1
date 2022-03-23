using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Assignment_1.Controllers
{
    public class Event : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Event/Home.cshtml");
        }

        public IActionResult Events()
        {
            return View("/Views/Event/Events.cshtml");
        }

        public IActionResult MyEvents()
        {
            return View("/Views/Event/MyEvents.cshtml");
        }
    }
}
