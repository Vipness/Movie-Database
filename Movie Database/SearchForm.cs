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

        public void GetMovie(object sender, EventArgs e)
        {
            string movieName = movieNameTxt.Text;
            string apiKey = "e7450749";

            // Create an instance of HttpClient and set the BaseAddress and default request headers
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.omdbapi.com/");

            // Make a request to the API and get the response
            HttpResponseMessage response = client.GetAsync($"?t={movieName}&apikey={apiKey}").Result;

            // Parse the JSON response content
            string json = response.Content.ReadAsStringAsync().Result;
            dynamic movieResult = JsonConvert.DeserializeObject(json);

            Movie movie = new Movie(movieResult["Title"].ToString(), movieResult["imdbRating"].ToString(), movieResult["Year"].ToString(), movieResult["Genre"].ToString());

            // Display the movie title in a label control
            movieHeading.Text = movieResult["Title"];
            ratingTxt.Text = movieResult["imdbRating"];
            yearTxt.Text = movieResult["Year"];

            string genre = movieResult["Genre"];
            string[] genres = genre.Split(',');
            genreTxt1.Text = genres[0];
            genreTxt2.Text = genres[1];
            genreTxt3.Text = genres[2];

            LoadPoster(movieResult["Poster"].ToString());
            MovieLayout.Visible = true;
            movieNameTxt.Text = "";
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
    }
}
