using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database
{
    internal class Movie
    {
        string name;
        string rating;
        string year;
        string genre;
        string posterLink;

        public Movie(string name, string rating, string year, string genre, string posterLink)
        {
            this.name = name;
            this.rating = rating;
            this.year = year;
            this.genre = genre;
            this.posterLink = posterLink;
        }

        public void OutputMovie()
        {
            MessageBox.Show($"{name}, {rating}, {year}, {genre}\nPoster link: {posterLink}");
        }
    }
}
