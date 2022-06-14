using Microsoft.AspNetCore.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class ViewData : Controller
    {
        public IActionResult Booking()
        {

            List<avise> avises = new List<avise>();
            avise.Add(new avise(0, "xyz", "eg1", "offen"));
            avise.Add(new avise(1, "xy", "eg2", "offen"));
            avise.Add(new avise(2, "x", "eg3", "offen"));


            return View("Booking", avises);
        }
    }
}

