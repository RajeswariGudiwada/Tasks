using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        public static void Main(string[] args)
        {

            IEnumerable<India> cities = new List<India>()
            {
                new  India{ Id=101, Name = "chennai" },
                new  India{ Id=102, Name = "mumbai" },
                new  India{ Id=102, Name = "hyderabad" },
                new  India{ Id=102, Name = "Delhi" },
                new  India{ Id=102, Name = "bangalore" }
            };

            IEnumerable<India> villages = new List<India>()
            {
                new  India{ Id=201, Name = "Diskit" },
                 new  India{ Id=201, Name = "Landour" },
                 new  India{ Id=201, Name = "Malana" },
                 new  India{ Id=201, Name = "Nako" },
                 new  India{ Id=201, Name = "Majuli" }
            };

            Console.WriteLine("no of cities = {0}", cities.Count());
            Console.WriteLine("***cities are***");
            foreach (var i in cities)
            {
                Console.WriteLine(i.Name);

            }
            foreach (var india in cities.Where(
              c => c.Name.StartsWith("D")
              ))
            {
                Console.WriteLine("***city name starts with D is***");
                Console.WriteLine(india.Name);

            }

            Console.WriteLine("no of villages = {0}", villages.Count());
            Console.WriteLine("***villages are***");
            foreach (var i in villages)
            {
                Console.WriteLine(i.Name);

            }
            foreach (var india in villages.Where(
              c => c.Name.StartsWith("D")
              ))
            {
                Console.WriteLine("***city name starts with D is***");
                Console.WriteLine(india.Name);

            }
        }


    }


}

