using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Movies.Library
{
    public class Movie
    {
        private string Genre;
        private string Title;

        public Movie(string title, string genre)
        {
            Genre = genre;
            Title = title;
        }
        
        public string GetTitle()
        {
            return Title;
        }
        public string GetGenre()
        {
            return Genre;
        }
    }

}
