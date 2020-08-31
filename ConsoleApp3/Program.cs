using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TechElevator.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Movie> movies = MovieProvider.BuildMovieDatabase();

            // Filter movies using Where
            foreach (Movie goodMovie in movies.Where(movie => movie.IsOnEarth)) // Equivalent of JS Function .filter
            {
                Console.WriteLine(goodMovie.Title);
            }

            // Use Select to Transform Values
            IEnumerable<string> castInEachMovie = movies.Select(movie => movie.Cast); // Equivalent of JS myArray.map(i => i.title);
            foreach (string cast in castInEachMovie)
            {
                Console.WriteLine(cast);
            }

            // Use FirstOrDefault           
            Movie firstMovieWithWhales = null;
            /*
            foreach (Movie movie in movies)
            {
                if (movie.NumSpaceWhales > 0)
                {
                    firstMovieWithWhales = movie;
                    break;
                }
            }
            */
            firstMovieWithWhales = movies.FirstOrDefault(movie => movie.NumSpaceWhales > 0); // JS Equivalent of myArray.find(i => i.numSpaceWhales > 0)

            if (firstMovieWithWhales != null)
            {
                Console.WriteLine(firstMovieWithWhales.Title + " has whales in it");
            } else
            {
                Console.WriteLine("No match found");
            }

            // Order movies using OrderBy
            foreach (Movie movie in movies.OrderBy(movie => movie.Title))
            {
                Console.WriteLine(movie.Title + " (" + movie.NumSpaceBattles + ")");
            }

            // Use Min / Max
            int maxBattles = movies.Max(movie => movie.NumSpaceBattles);
            int minBattles = movies.Min(movie => movie.NumSpaceBattles);
            Console.WriteLine("Num Battles ranges from " + minBattles + " to " + maxBattles);

            // Use Any
            bool isEnterpriseEverDestroyed = movies.Any(movie => movie.ShipIsDestroyed);
            Console.WriteLine("Was the ship ever destroyed? " + isEnterpriseEverDestroyed);
        }
    }
}
