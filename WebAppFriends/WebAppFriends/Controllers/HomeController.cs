using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAppFriends.Models;

namespace WebAppFriends.Controllers
{
    public class HomeController : Controller
    {
        // Instantiates repository.
        public PeopleRepo controllerRepo = PeopleRepo.updatableRepo;
        // Index View with all people in the repo.
        public IActionResult Index() => View(controllerRepo.People.OrderBy(p => p.FirstName));
        // Get AddFriend View passing new person to add details to.
        [HttpGet]
        public IActionResult AddFriend() => View(new Person());
        // Post from AddFriend View. Adds new person to peopleDict, which updates People property, then redirects to Index View with updated repo. 
        [HttpPost]
        public IActionResult AddFriend(Person p)
        {
            controllerRepo.AddFriend(p);
            return RedirectToAction("Index");
        }
        // Get SearchFriends View without passing anything to the View.
        [HttpGet]
        public IActionResult SearchFriends() => View();
        // Post from SearchFriends View. Finds a person with a matching property, and passes the person to the FriendsFound View. Displays the persons in the FriendsFound View.
        [HttpPost] // For some reason, "FirstName" is critical and cannot be called anything else.
        public IActionResult SearchFriends(string FirstName)
        {
            IEnumerable<Person> found = controllerRepo.People.Select(p => p).Where(p => p.FirstName == FirstName || p.LastName == FirstName || p.Gender == FirstName || p.Age.ToString() == FirstName);
            return View("FriendsFound", found);
        }
    }
}
