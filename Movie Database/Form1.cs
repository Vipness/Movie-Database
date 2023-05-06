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
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            tabTitle.Text = button.Text;
        }
    }
}
