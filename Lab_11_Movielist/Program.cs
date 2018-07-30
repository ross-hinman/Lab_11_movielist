using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Movies.Library;

namespace Lab_11_Movielist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie> { };
            movieList.Add(new Movie("Up", "animated"));
            movieList.Add(new Movie("Shrek", "animated"));
            movieList.Add(new Movie("Tangled", "animated"));
            movieList.Add(new Movie("Titanic", "drama"));
            movieList.Add(new Movie("The Princess Bride", "drama"));
            movieList.Add(new Movie("Saw", "horror"));
            movieList.Add(new Movie("The Babadook", "horror"));
            movieList.Add(new Movie("Pacific Rim", "scifi"));
            movieList.Add(new Movie("Star Wars Episode I: The Phantom of the Opera", "scifi"));
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Enter a movie genre:\nAnimated\nDrama\nHorror\nSciFi");
                string genre = Console.ReadLine().ToLower();
                switch (genre)
                {
                    case "animated":
                        foreach (Movie movie in movieList)
                        {
                            if (movie.GetGenre() == "animated")
                            {
                                Console.WriteLine(movie.GetTitle());
                            }
                        }
                        break;
                    case "drama":
                        foreach (Movie movie in movieList)
                        {
                            if (movie.GetGenre() == "drama")
                            {
                                Console.WriteLine(movie.GetTitle());
                            }
                        }
                        break;
                    case "horror":
                        foreach (Movie movie in movieList)
                        {
                            if (movie.GetGenre() == "horror")
                            {
                                Console.WriteLine(movie.GetTitle());
                            }
                        }
                        break;
                    case "scifi":
                        foreach (Movie movie in movieList)
                        {
                            if (movie.GetGenre() == "scifi")
                            {
                                Console.WriteLine(movie.GetTitle());
                            }
                        }
                        break;
                        
                }
                Console.WriteLine("Would you like to continue? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    repeat = true;
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Thank you!");
                    repeat = false;
                }
            }                
            
        }      
    }
}
