using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Assignment_1.Controllers
{
    public class Event : Controller
    {
        //public IActionResult Index()
        //{
        //    return View("/Views/Event/Home.cshtml");
        //}

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult MyEvents()
        {
            return View();
        }
    }
}
