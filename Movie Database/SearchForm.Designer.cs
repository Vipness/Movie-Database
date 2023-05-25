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
            this.posterImg = new System.Windows.Forms.PictureBox();
            this.movieHeading = new System.Windows.Forms.Label();
            this.ratingTxt = new System.Windows.Forms.Label();
            this.genrePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.MovieLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search for movies or TV series: ";
            // 
            // movieNameTxt
            // 
            this.movieNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.movieNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieNameTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.movieNameTxt.Location = new System.Drawing.Point(401, 15);
            this.movieNameTxt.Name = "movieNameTxt";
            this.movieNameTxt.Size = new System.Drawing.Size(690, 28);
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
            this.btnSearchMovie.Location = new System.Drawing.Point(1117, 12);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(109, 37);
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
            this.MovieLayout.Controls.Add(this.posterImg, 0, 0);
            this.MovieLayout.Controls.Add(this.movieHeading, 1, 0);
            this.MovieLayout.Controls.Add(this.ratingTxt, 1, 1);
            this.MovieLayout.Controls.Add(this.genrePanel, 1, 3);
            this.MovieLayout.Location = new System.Drawing.Point(19, 100);
            this.MovieLayout.Name = "MovieLayout";
            this.MovieLayout.RowCount = 3;
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MovieLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MovieLayout.Size = new System.Drawing.Size(1207, 465);
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
            this.yearTxt.Location = new System.Drawing.Point(746, 138);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(77, 37);
            this.yearTxt.TabIndex = 10;
            this.yearTxt.Text = "2023";
            this.yearTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // posterImg
            // 
            this.posterImg.Location = new System.Drawing.Point(3, 3);
            this.posterImg.Name = "posterImg";
            this.MovieLayout.SetRowSpan(this.posterImg, 5);
            this.posterImg.Size = new System.Drawing.Size(356, 458);
            this.posterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.posterImg.TabIndex = 3;
            this.posterImg.TabStop = false;
            // 
            // movieHeading
            // 
            this.movieHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.movieHeading.AutoSize = true;
            this.movieHeading.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.movieHeading.Location = new System.Drawing.Point(667, 0);
            this.movieHeading.Name = "movieHeading";
            this.movieHeading.Size = new System.Drawing.Size(234, 59);
            this.movieHeading.TabIndex = 8;
            this.movieHeading.Text = "Movie Title";
            this.movieHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ratingTxt
            // 
            this.ratingTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ratingTxt.AutoSize = true;
            this.ratingTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ratingTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ratingTxt.Location = new System.Drawing.Point(758, 69);
            this.ratingTxt.Name = "ratingTxt";
            this.ratingTxt.Size = new System.Drawing.Size(53, 37);
            this.ratingTxt.TabIndex = 8;
            this.ratingTxt.Text = "0.0";
            this.ratingTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // genrePanel
            // 
            this.genrePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.genrePanel.AutoSize = true;
            this.genrePanel.Location = new System.Drawing.Point(749, 210);
            this.genrePanel.MinimumSize = new System.Drawing.Size(70, 40);
            this.genrePanel.Name = "genrePanel";
            this.genrePanel.Size = new System.Drawing.Size(70, 40);
            this.genrePanel.TabIndex = 11;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddMovie.FlatAppearance.BorderSize = 2;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAddMovie.Location = new System.Drawing.Point(0, 809);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(1556, 75);
            this.btnAddMovie.TabIndex = 3;
            this.btnAddMovie.Text = "Add Movie To Storage";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Visible = false;
            this.btnAddMovie.Click += new System.EventHandler(this.ShowAddMovieDialog);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.MovieLayout);
            this.Controls.Add(this.btnSearchMovie);
            this.Controls.Add(this.movieNameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.MovieLayout.ResumeLayout(false);
            this.MovieLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterImg)).EndInit();
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
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.FlowLayoutPanel genrePanel;
    }
}