using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public dynamic GetMovie()
        {
            string movieName = movieNameTxt.Text;
            string apiKey = "e7450749";

            // Create an instance of HttpClient and set the BaseAddress and default request headers
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.omdbapi.com/");

            // Make a request to the API and get the response
            HttpResponseMessage response = client.GetAsync($"?t={WebUtility.UrlEncode(movieName)}&apikey={apiKey}").Result;

            // Parse the JSON response content
            string json = response.Content.ReadAsStringAsync().Result;
            dynamic movieResult = JsonConvert.DeserializeObject(json);

            return movieResult;
        }

        public void UpdateMovieDetails()
        {
            dynamic movieResult = GetMovie();

            movieHeading.Text = movieResult["Title"];
            ratingTxt.Text = movieResult["imdbRating"];
            yearTxt.Text = movieResult["Year"];

            string genre = movieResult["Genre"];
            string[] genres = genre.Split(',');
            genreTxt1.Text = genres[0];
            genreTxt2.Text = genres[1];

            LoadPoster(movieResult["Poster"].ToString());
            MovieLayout.Visible = true;
            btnAddMovie.Visible = true;
        }

        private void movieNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ValidateMovieName();
        }

        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            ValidateMovieName();
        }

        public void ShowAddMovieDialog(object sender, EventArgs e)
        {
            AddMovieDialog movieDialog = new AddMovieDialog(GetMovie());
            movieDialog.ShowDialog();
        }

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

        public void ValidateMovieName()
        {
            try
            {
                if (!(String.IsNullOrWhiteSpace(movieNameTxt.Text)))
                    UpdateMovieDetails();
                else
                    MessageBox.Show("Please enter movie name!");
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show("Movie not found in the database!\nPlease try again.");
            }
        }
    }
}
