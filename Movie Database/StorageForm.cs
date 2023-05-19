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
            //MovieList.Rows.Add(8.9, "LOTR", "Action");
            using(StreamReader sr = new StreamReader("movies.csv"))
            {
                while(sr.Peek() >= 0)
                {
                    string movie = sr.ReadLine();
                    string[] movieProperties = movie.Split(';');

                    MovieList.Rows.Add(movieProperties[movieProperties.Length - 1].ToString(), movieProperties[2].ToString(), movieProperties[0].ToString(), movieProperties[1].ToString());
                }
            }
        }

        /*
        public void LoadPoster(string posterLink)
        {
            posterImg.SizeMode = PictureBoxSizeMode.Zoom;
            WebRequest request = WebRequest.Create(posterLink);
            using (var posterResponse = request.GetResponse())
            using (var str = posterResponse.GetResponseStream())
            {
                posterImg.Image = Bitmap.FromStream(str);
            }
        }
        */
    }
}
