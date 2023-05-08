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
        
    }
}
