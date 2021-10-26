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
                new  India{ Id=103, Name = "hyderabad" },
                new  India{ Id=104, Name = "delhi" },
                new  India{ Id=105, Name = "bangalore" }
            };

            IEnumerable<India> villages = new List<India>()
            {
                 new  India{ Id=201, Name = "Diskit" },
                 new  India{ Id=202, Name = "Landour" },
                 new  India{ Id=203, Name = "Malana" },
                 new  India{ Id=204, Name = "Nako" },
                 new  India{ Id=205, Name = "Majuli" }
            };
           
            Console.WriteLine("***Number of cities in List = {0}", cities.Count());
            Console.WriteLine("Cities are:");
            foreach (var c in cities)
            {
                Console.WriteLine(c.Name);

            }
            Console.WriteLine("\n***order by length=9:");
            foreach (var c in cities.Where(e=>e.Name.Length==9)
                                     .OrderByDescending(e=>e.Name))
            {

                Console.WriteLine(c.Name);

            }
            foreach (var c in cities.Where(
              c => c.Name.StartsWith("b")
              ))
            {
                Console.WriteLine("\n***City name starts with b is:");
                Console.WriteLine(c.Name);

            }

            Console.WriteLine("\n***Number of villages = {0}", villages.Count());
            Console.WriteLine("villages are:");
            foreach (var v in villages)
            {
                Console.WriteLine(v.Name);

            }
            var query = from village in villages
                        where village.Name.Length == 4
                        orderby village.Name ascending
                        select village;
            foreach( var i in query)
            {
                Console.WriteLine("\n***Order by length=4:");
                Console.WriteLine( i.Name);
            }
            foreach (var india in villages.Where(
              c => c.Name.StartsWith("N")
              ))
            {
                Console.WriteLine("\n***City name starts with N is:");
                Console.WriteLine(india.Name);

            }
            Console.WriteLine("\n*** Usingfunc");
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(square(add(5, 2))); 
            Console.WriteLine("\n");
            Console.WriteLine("***Using filter:");
            var query1 = cities.Filter(m => m.Id > 102);
           
            foreach (var p in query1)
            {

                Console.WriteLine(p.Name);
            }
            Console.WriteLine("\n**Using Where:");
            var query2 = cities.Where(m => m.Id > 102);
         
            foreach (var p in query1)
            {

                Console.WriteLine(p.Name);
            }
        }


    }


}

