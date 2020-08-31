using System;
using System.Collections;
using System.Collections.Generic;
// TODO: Add LINQ reference

namespace TechElevator.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Movie> movies = MovieProvider.BuildMovieDatabase();

            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.Title);
            }

            // TODO: Filter movies using Where

            // TODO: Order movies using OrderBy

            // TODO: Use Select to Transform Values

            // TODO: Use FirstOrDefault

            // TODO: Use Min / Max

            // TODO: Use Any

            /* JavaScript Array Methods you may be familiar with
                
                const activeItems = myArray.filter(i => i.isActive);
                

             */
        }
    }
}
