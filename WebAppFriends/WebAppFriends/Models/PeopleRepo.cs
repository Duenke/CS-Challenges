using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFriends.Models;

namespace WebAppFriends.Models
{
    public class PeopleRepo
    {
        private static PeopleRepo originalRepo = new PeopleRepo();

        public static PeopleRepo updatableRepo => originalRepo;
        public IEnumerable<Person> People => peopleDict.Values;

        private Dictionary<string, Person> peopleDict = new Dictionary<string, Person>();

        public PeopleRepo()
        {
            var initialFriends = new[]
            {
                new Person { FirstName = "Jacob", LastName = "Duenke", Gender = "Male", Age = 26},
                new Person { FirstName = "Kindra", LastName = "Bilodeau", Gender = "Fluid", Age = 89},
                new Person { FirstName = "Malachi", LastName = "Evans", Gender = "Male", Age = 28}
            };
            foreach (var p in initialFriends)
            {
                AddFriend(p);
            }
        }

        public void AddFriend(Person p)
        {
            peopleDict.Add(p.FirstName, p);
        }
    }
}
