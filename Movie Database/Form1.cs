using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            ChangeActiveWindow("Search");
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
                case "Search":
                    SearchForm searchForm = new SearchForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    searchForm.FormBorderStyle = FormBorderStyle.None;
                    this.FormLoader.Controls.Add(searchForm);
                    searchForm.Show();
                    break;

                case "Storage":
                    StorageForm storageForm = new StorageForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    storageForm.FormBorderStyle = FormBorderStyle.None;
                    this.FormLoader.Controls.Add(storageForm);
                    storageForm.Show();
                    break;
                default:
                    ErrorForm errorForm = new ErrorForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    errorForm.FormBorderStyle = FormBorderStyle.None;
                    this.FormLoader.Controls.Add(errorForm);
                    errorForm.Show();
                    break;
            }
        }
    }
}
