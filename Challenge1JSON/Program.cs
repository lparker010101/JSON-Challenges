using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1JSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Event outing = new Event();

            outing.StartDate = new DateTime(2021, 11, 06);
            outing.EndDate = new DateTime(2021, 11, 10);
            outing.EventTitle = "Kids Camp";
            outing.EventCapacity = 50;
            outing.PriceOfAdmission = 100.50m;

            string json = JsonConvert.SerializeObject(outing);

            Console.WriteLine(json);

            Console.ReadKey();  
        }
    }
}
