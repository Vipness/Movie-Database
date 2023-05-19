using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database
{
    internal class MovieStorage
    {
        Movie[] movieStorage;
        int numOfMovies = 0;

        public MovieStorage(int amount)
        {
            movieStorage = new Movie[amount];
        }

        public void AddMovie(Movie m)
        {
            movieStorage[numOfMovies++] = m;
        }

        public int MovieCount()
        {
            return numOfMovies;
        }

        // delete later
        public void Izpis()
        {
            for (int i = 0; i < numOfMovies; i++) 
                movieStorage[i].OutputMovie();
        }
    }
}
