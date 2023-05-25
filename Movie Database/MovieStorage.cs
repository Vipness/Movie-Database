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
        static int nextMovieIndex = 0;

        public MovieStorage()
        {
            movieStorage = new Movie[1];
        }

        public void AddMovie(Movie m)
        {
            movieStorage = IncreaseStorageSize(movieStorage);
            movieStorage[numOfMovies++] = m;
            nextMovieIndex++;
        }

        public void MovieCount()
        {
            MessageBox.Show((nextMovieIndex + 1).ToString(), "Current number of movies in storage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Movie[] IncreaseStorageSize(Movie[] movieStorage)
        {
            Movie[] newStorage = new Movie[movieStorage.Length + 1];

            for(int i = 0; i < movieStorage.Length; i++)
                newStorage[i] = movieStorage[i];

            return newStorage;
        }
    }
}
