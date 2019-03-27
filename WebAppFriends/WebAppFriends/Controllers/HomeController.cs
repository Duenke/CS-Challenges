using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppFriends.Models;

namespace WebAppFriends.Controllers
{
    public class HomeController : Controller
    {
        public PeopleRepo controllerRepo = PeopleRepo.updatableRepo;

        public IActionResult Index() => View(controllerRepo.People);

        [HttpGet]
        public IActionResult AddFriend() => View(new Person());

        [HttpPost]
        public IActionResult AddFriend(Person p)
        {
            controllerRepo.AddFriend(p);
            return RedirectToAction("Index");
        }
    }
}
