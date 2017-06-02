using System;
using System.Collections.Generic;
using System.Linq;

namespace differed_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie> {  new Movie { Name = "Baahubali 2", Year = 2017 }, new Movie { Name = "Avenger 3", Year = 2015 }, new Movie { Name = "3 Idiots", Year = 2010 } };

            var q = movies.Filter(m => m.Year >= 2015).Take(1);

            foreach (var item in q)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("---------------------");

            var q1 = movies.DifferedFilter(m => m.Year >= 2015).Take(1);
            foreach (var item in q1)
            {
                Console.WriteLine(item.Name);
            }

            Console.Read();
        }
    }
}
