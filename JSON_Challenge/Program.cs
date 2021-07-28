using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Phil";
            person.LastName = "Smith";
            person.DOB = new DateTime(1994, 5, 13);
            person.FavoriteIceCreamFlavors = new List<string>
            {"Strawberry", "Cookie Dough"};

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
