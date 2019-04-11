using System.Collections.Generic;

namespace WebAppFriends.Models
{
    public class PeopleRepo
    {
        // Initial instance of the repository that will not change, for reference.
        private static PeopleRepo originalRepo = new PeopleRepo();
        // Dictionary that will hold the "persons".
        private Dictionary<string, Person> peopleDict = new Dictionary<string, Person>();

        // Property that acts as an updateable repository. Can add to/remove from.
        public static PeopleRepo updatableRepo => originalRepo;
        // Property that holds "people" can be enumerated through.
        public IEnumerable<Person> People => peopleDict.Values;

        // Class constructor; Initializes and adds beginning set of people.
        public PeopleRepo()
        {
            Person[] initialFriends = new[]
            {
                new Person { FirstName = "Jacob", LastName = "Duenke", Gender = "Male", Age = 26},
                new Person { FirstName = "Kindra", LastName = "Bilodeau", Gender = "Female", Age = 26},
                new Person { FirstName = "Malachi", LastName = "Evans", Gender = "Male", Age = 26},
                new Person { FirstName = "Dina", LastName = "Janicki", Gender = "Female", Age = 29},
                new Person { FirstName = "Sam", LastName = "Duenke", Gender = "Male", Age = 22},
                new Person { FirstName = "Hannah", LastName = "Duenke", Gender = "Female", Age = 27},
                new Person { FirstName = "Katie", LastName = "Garrett", Gender = "Female", Age = 25},
                new Person { FirstName = "Grayson", LastName = "Drew", Gender = "Male", Age = 25},
                new Person { FirstName = "Evan", LastName = "Drew", Gender = "Male", Age = 23},
            };
            foreach (Person p in initialFriends)
            {
                AddFriend(p);
            }
        }

        public void AddFriend(Person p)
        {
            // Concatenated FirstName & LastName as the Key to prevent duplicate people.
            peopleDict.Add(p.FirstName + p.LastName, p);
        }
    }
}
