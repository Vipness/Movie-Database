using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Movie_Database
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ChangeActiveWindow("Storage");
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            tabTitle.Text = button.Text;

            ChangeActiveWindow(button.Text);
        }

        public void ChangeActiveWindow(string button)
        {
            this.FormLoader.Controls.Clear();
            switch(button)
            {
                case "Storage":
                    StorageForm storageForm = new StorageForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    storageForm.FormBorderStyle = FormBorderStyle.None;
                    this.FormLoader.Controls.Add(storageForm);
                    storageForm.Show();
                    break;
                case "Statistics":
                    StatisticsForm statsForm = new StatisticsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    statsForm.FormBorderStyle = FormBorderStyle.None;
                    this.FormLoader.Controls.Add(statsForm);
                    statsForm.Show();
                    break;
                //case "Settings": MessageBox.Show("Settings active"); break;
                default:
                    ErrorForm errorForm = new ErrorForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    errorForm.FormBorderStyle = FormBorderStyle.None;
                    this.FormLoader.Controls.Add(errorForm);
                    errorForm.Show();
                    break;
            }
        }

        public void GetMovie(object sender, EventArgs e)
        {
            // Create an instance of HttpClient and set the BaseAddress and default request headers
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.omdbapi.com/");

            // Make a request to the API and get the response
            HttpResponseMessage response = client.GetAsync("?t=Nobody&apikey=e7450749").Result;

            // Parse the JSON response content
            string json = response.Content.ReadAsStringAsync().Result;
            dynamic result = JsonConvert.DeserializeObject(json);

            // Display the movie title in a label control
            string title = result["Title"];
            MessageBox.Show($"Movie {title} was released in {result["Year"]} and is rated {result["imdbRating"]} on IMDb");
        }
    }
}
