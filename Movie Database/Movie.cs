using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Movie_Database
{
    internal class Movie
    {
        string name;
        string rating;
        string year;
        string genre;

        public Movie(string name, string rating, string year, string genre)
        {
            this.name = name;
            this.rating = rating;
            this.year = year;
            this.genre = genre;
        }

        public void Izpis()
        {
            MessageBox.Show($"{name}, {rating}, {year}, {genre}");
        }
    }
}
