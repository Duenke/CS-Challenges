using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDink.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationDink.Controllers
{
    public class HomeController : Controller
    {
        Dink JD = new Dink
        {
            Name = "Jacob",
            Age = 26,
            Job = "Medic",
            FavColor = "Purple"
        };

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(JD);
        }
    }
}
