using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database
{
    public partial class AddMovieDialog : Form
    {
        dynamic movieResult;
        MovieStorage movieStorage = new MovieStorage(100);

        public AddMovieDialog(dynamic movieResult)
        {
            InitializeComponent();
            this.movieResult = movieResult;
        }

        public void AddMovie(object sender, EventArgs e)
        {
            string userRating = userRatingTxt.Text;
            string userNote = userNoteTxt.Text;

            movieStorage.AddMovie(new Movie(userRating, userNote, movieResult["Title"].ToString(), movieResult["imdbRating"].ToString(), movieResult["Year"].ToString(), movieResult["Genre"].ToString(), movieResult["Poster"].ToString()));

            this.DialogResult = DialogResult.OK;

            MessageBox.Show("Number of all movies: " + movieStorage.MovieCount().ToString());
            movieStorage.Izpis(); // comment/delete later
        }
    }
}
