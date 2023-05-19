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
        string userRating;
        string userNote;
        string name;
        string rating;
        string year;
        string genre;
        string posterLink;

        public Movie(string userRating, string userNote, string name, string rating, string year, string genre, string posterLink)
        {
            this.userRating = userRating;
            this.userNote = userNote;
            this.name = name;
            this.rating = rating;
            this.year = year;
            this.genre = genre;
            this.posterLink = posterLink;
        }

        public void OutputMovie()
        {
            MessageBox.Show($"Rating: {userRating}\n" +
                            $"Note: {userNote}\n" +
                            $"Movie details:\n" +
                            $"{name}, {rating}, {year}, {genre}\n" +
                            $"Poster link: {posterLink}");
        }
    }
}
