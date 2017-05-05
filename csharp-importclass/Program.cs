using System;
using System.IO;

namespace csharp_importclass
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] states = { "New York", "Virginia", "California", "Florida", "Hawaii" };
            string[] states2 = { "Durango", "Puebla", "Guerrero", "Quintana Roo" };
            City c1 = new City { name = "Los Angeles", population = "4 million" };
            City c2 = new City { name = "Cancun", population = "700,000" };
			Country[] countries = {
                new Country{
                    name="USA",
                    population="350 million",
                    states=states,
                    best_city=c1
                },
                new Country{
                    name="Mexico",
                    population="127 million",
                    states=states2,
                    best_city=c2
                }
			};

            using (var file = File.CreateText("../log.txt"))
            {
                file.WriteLine();
                foreach (Country c in countries)
                {
                    file.WriteLine("Name: {0}", c.name);
                    file.WriteLine("Population: {0}", c.population);
                    var result = string.Join(", ", c.states);
                    file.WriteLine("Best States: {0}", result);
                    file.WriteLine("Top State Count: {0}", c.fav_cnt());
                    file.WriteLine("Best City: {0}", c.best_city.name);
                    file.WriteLine("{0} Population: {1}", c.best_city.name, c.best_city.population);
                    file.WriteLine();
                }
            }
            Console.WriteLine("Done.");
        }
    }
}
