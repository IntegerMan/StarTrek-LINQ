using System;
using System.Collections;
using System.Collections.Generic;

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
            // TODO: Transform movies using Select

            // TODO: Find a movie using FirstOrDefault

            // TODO: Get the maximum number of space battles in a movie
        }
    }
}
