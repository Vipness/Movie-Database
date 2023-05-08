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
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }

        public void AddMovie(object sender, EventArgs e)
        {
            movieList.Rows.Add(movieRatingTxt.Text, movieNameTxt.Text, movieGenreTxt.Text);
        }
    }
}
