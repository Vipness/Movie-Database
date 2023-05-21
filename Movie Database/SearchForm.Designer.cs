namespace Movie_Database
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.movieNameTxt = new System.Windows.Forms.TextBox();
            this.btnSearchMovie = new System.Windows.Forms.Button();
            this.MovieLayout = new System.Windows.Forms.TableLayoutPanel();
            this.yearTxt = new System.Windows.Forms.Label();
            this.ratingTxt = new System.Windows.Forms.Label();
            this.posterImg = new System.Windows.Forms.PictureBox();
            this.movieHeading = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.genreTxt1 = new System.Windows.Forms.Label();
            this.genreTxt2 = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.MovieLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterImg)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search for movies or TV series: ";
            // 
            // movieNameTxt
            // 
            this.movieNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.movieNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieNameTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.movieNameTxt.Location = new System.Drawing.Point(561, 15);
            this.movieNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.movieNameTxt.Multiline = true;
            this.movieNameTxt.Name = "movieNameTxt";
            this.movieNameTxt.Size = new System.Drawing.Size(920, 46);
            this.movieNameTxt.TabIndex = 1;
            this.movieNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.movieNameTxt_KeyDown);
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSearchMovie.FlatAppearance.BorderSize = 2;
            this.btnSearchMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSearchMovie.Location = new System.Drawing.Point(1489, 15);
            this.btnSearchMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(145, 46);
            this.btnSearchMovie.TabIndex = 2;
            this.btnSearchMovie.Text = "Search";
            this.btnSearchMovie.UseVisualStyleBackColor = true;
            this.btnSearchMovie.Click += new System.EventHandler(this.btnSearchMovie_Click);
            // 
            // MovieLayout
            // 
            this.MovieLayout.ColumnCount = 2;
            this.MovieLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MovieLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.MovieLayout.Controls.Add(this.yearTxt, 1, 2);
            this.MovieLayout.Controls.Add(this.ratingTxt, 1, 1);
            this.MovieLayout.Controls.Add(this.posterImg, 0, 0);
            this.MovieLayout.Controls.Add(this.movieHeading, 1, 0);
            this.MovieLayout.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.MovieLayout.Location = new System.Drawing.Point(25, 123);
            this.MovieLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MovieLayout.Name = "MovieLayout";
            this.MovieLayout.RowCount = 3;
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MovieLayout.Size = new System.Drawing.Size(1609, 572);
            this.MovieLayout.TabIndex = 6;
            this.MovieLayout.Visible = false;
            // 
            // yearTxt
            // 
            this.yearTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearTxt.AutoSize = true;
            this.yearTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.yearTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yearTxt.Location = new System.Drawing.Point(999, 170);
            this.yearTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(92, 46);
            this.yearTxt.TabIndex = 10;
            this.yearTxt.Text = "2023";
            this.yearTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ratingTxt
            // 
            this.ratingTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ratingTxt.AutoSize = true;
            this.ratingTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ratingTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ratingTxt.Location = new System.Drawing.Point(1014, 85);
            this.ratingTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingTxt.Name = "ratingTxt";
            this.ratingTxt.Size = new System.Drawing.Size(63, 46);
            this.ratingTxt.TabIndex = 8;
            this.ratingTxt.Text = "0.0";
            this.ratingTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // posterImg
            // 
            this.posterImg.Location = new System.Drawing.Point(4, 4);
            this.posterImg.Margin = new System.Windows.Forms.Padding(4);
            this.posterImg.Name = "posterImg";
            this.MovieLayout.SetRowSpan(this.posterImg, 5);
            this.posterImg.Size = new System.Drawing.Size(474, 564);
            this.posterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.posterImg.TabIndex = 3;
            this.posterImg.TabStop = false;
            // 
            // movieHeading
            // 
            this.movieHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.movieHeading.AutoSize = true;
            this.movieHeading.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.movieHeading.Location = new System.Drawing.Point(952, 0);
            this.movieHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieHeading.Name = "movieHeading";
            this.movieHeading.Size = new System.Drawing.Size(186, 46);
            this.movieHeading.TabIndex = 8;
            this.movieHeading.Text = "Movie Title";
            this.movieHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.genreTxt1);
            this.flowLayoutPanel1.Controls.Add(this.genreTxt2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1010, 274);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(70, 46);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // genreTxt1
            // 
            this.genreTxt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genreTxt1.AutoSize = true;
            this.genreTxt1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTxt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.genreTxt1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.genreTxt1.Location = new System.Drawing.Point(4, 0);
            this.genreTxt1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreTxt1.Name = "genreTxt1";
            this.genreTxt1.Size = new System.Drawing.Size(27, 46);
            this.genreTxt1.TabIndex = 9;
            this.genreTxt1.Text = ".";
            this.genreTxt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // genreTxt2
            // 
            this.genreTxt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genreTxt2.AutoSize = true;
            this.genreTxt2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTxt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.genreTxt2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.genreTxt2.Location = new System.Drawing.Point(39, 0);
            this.genreTxt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreTxt2.Name = "genreTxt2";
            this.genreTxt2.Size = new System.Drawing.Size(27, 46);
            this.genreTxt2.TabIndex = 10;
            this.genreTxt2.Text = ".";
            this.genreTxt2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddMovie.FlatAppearance.BorderSize = 2;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAddMovie.Location = new System.Drawing.Point(0, 996);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(2075, 92);
            this.btnAddMovie.TabIndex = 3;
            this.btnAddMovie.Text = "Add Movie To Storage";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Visible = false;
            this.btnAddMovie.Click += new System.EventHandler(this.ShowAddMovieDialog);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(2075, 1088);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.MovieLayout);
            this.Controls.Add(this.btnSearchMovie);
            this.Controls.Add(this.movieNameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.MovieLayout.ResumeLayout(false);
            this.MovieLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterImg)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movieNameTxt;
        private System.Windows.Forms.PictureBox posterImg;
        private System.Windows.Forms.Button btnSearchMovie;
        private System.Windows.Forms.TableLayoutPanel MovieLayout;
        private System.Windows.Forms.Label ratingTxt;
        private System.Windows.Forms.Label movieHeading;
        private System.Windows.Forms.Label yearTxt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label genreTxt1;
        private System.Windows.Forms.Label genreTxt2;
        private System.Windows.Forms.Button btnAddMovie;
    }
}