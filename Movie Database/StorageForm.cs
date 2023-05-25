using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Movie_Database
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }

        public void UpdateMovieList(object sender, EventArgs e)
        {
            using(StreamReader sr = new StreamReader("movies.csv"))
            {
                while(sr.Peek() >= 0)
                {
                    string movie = sr.ReadLine();
                    string[] movieProperties = movie.Split(';');

                    string movieTitle = movieProperties[2].ToString();
                    string userRating = movieProperties[0].ToString();
                    string userNote = movieProperties[1].ToString();

                    MovieList.Rows.Add(movieTitle, userRating, userNote);
                }
            }
        }
    }
}
