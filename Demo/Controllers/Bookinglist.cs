using Microsoft.AspNetCore.Mvc;
using Demo.Models;


namespace Demo.Controllers
{
    public class ViewData : Controller
    {
        public IActionResult Booking()
        {

            List<avise> avises = new List<avise>();
            _ = new avise();

            return View("Booking", avises);
        }
    }
}

