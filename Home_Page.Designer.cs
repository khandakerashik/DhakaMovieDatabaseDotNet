namespace Dhaka_Movie_Database
{
    partial class home_Form
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
            this.dmdb_label = new System.Windows.Forms.Label();
            this.category_Box = new System.Windows.Forms.ComboBox();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.Hall_Box = new System.Windows.Forms.ComboBox();
            this.login_label = new System.Windows.Forms.Label();
            this.signup_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suggest_movie_label = new System.Windows.Forms.Label();
            this.see_member_request_label = new System.Windows.Forms.Label();
            this.add_movie_pictureBox = new System.Windows.Forms.PictureBox();
            this.search_pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_movie_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dmdb_label
            // 
            this.dmdb_label.AutoSize = true;
            this.dmdb_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmdb_label.Font = new System.Drawing.Font("20th Century Font", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmdb_label.Location = new System.Drawing.Point(10, 9);
            this.dmdb_label.Name = "dmdb_label";
            this.dmdb_label.Size = new System.Drawing.Size(194, 67);
            this.dmdb_label.TabIndex = 0;
            this.dmdb_label.Text = "DMDB";
            this.dmdb_label.Click += new System.EventHandler(this.dmdb_label_Click);
            // 
            // category_Box
            // 
            this.category_Box.FormattingEnabled = true;
            this.category_Box.Items.AddRange(new object[] {
            "War",
            "Action",
            "Drama",
            "Hrror"});
            this.category_Box.Location = new System.Drawing.Point(22, 96);
            this.category_Box.Name = "category_Box";
            this.category_Box.Size = new System.Drawing.Size(121, 21);
            this.category_Box.TabIndex = 1;
            this.category_Box.Text = "Category";
            this.category_Box.SelectedIndexChanged += new System.EventHandler(this.category_Box_SelectedIndexChanged);
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(182, 97);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(288, 20);
            this.search_Box.TabIndex = 2;
            this.search_Box.TextChanged += new System.EventHandler(this.search_Box_TextChanged);
            // 
            // Hall_Box
            // 
            this.Hall_Box.FormattingEnabled = true;
            this.Hall_Box.Items.AddRange(new object[] {
            "Star Cineplex",
            "Balaka Cinema",
            "Blockbuster Cinemas",
            "Shyamoli Cinema",
            "Madhumita Cinema"});
            this.Hall_Box.Location = new System.Drawing.Point(502, 96);
            this.Hall_Box.Name = "Hall_Box";
            this.Hall_Box.Size = new System.Drawing.Size(121, 21);
            this.Hall_Box.TabIndex = 4;
            this.Hall_Box.Text = "Hall";
            this.Hall_Box.SelectedIndexChanged += new System.EventHandler(this.Hall_Box_SelectedIndexChanged);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_label.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.Navy;
            this.login_label.Location = new System.Drawing.Point(502, 27);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(49, 18);
            this.login_label.TabIndex = 5;
            this.login_label.Text = "Log In";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_label.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_label.ForeColor = System.Drawing.Color.Navy;
            this.signup_label.Location = new System.Drawing.Point(564, 27);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(59, 18);
            this.signup_label.TabIndex = 6;
            this.signup_label.Text = "Sign Up";
            this.signup_label.Click += new System.EventHandler(this.signup_label_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView.Location = new System.Drawing.Point(22, 173);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(436, 418);
            this.dataGridView.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.ToolTipText = "Name";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rating";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.ToolTipText = "Rating";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.ToolTipText = "Category";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Duration";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.ToolTipText = "Duration";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Release Year";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.ToolTipText = "Release Year";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hall";
            this.Column6.Name = "Column6";
            // 
            // suggest_movie_label
            // 
            this.suggest_movie_label.AutoSize = true;
            this.suggest_movie_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suggest_movie_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggest_movie_label.Location = new System.Drawing.Point(532, 175);
            this.suggest_movie_label.Name = "suggest_movie_label";
            this.suggest_movie_label.Size = new System.Drawing.Size(101, 15);
            this.suggest_movie_label.TabIndex = 12;
            this.suggest_movie_label.Text = "Suggest Movie";
            this.suggest_movie_label.Click += new System.EventHandler(this.suggest_movie_label_Click);
            // 
            // see_member_request_label
            // 
            this.see_member_request_label.AutoSize = true;
            this.see_member_request_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.see_member_request_label.Location = new System.Drawing.Point(362, 31);
            this.see_member_request_label.Name = "see_member_request_label";
            this.see_member_request_label.Size = new System.Drawing.Size(110, 13);
            this.see_member_request_label.TabIndex = 13;
            this.see_member_request_label.Text = "See Member Request";
            this.see_member_request_label.Click += new System.EventHandler(this.see_member_request_label_Click);
            // 
            // add_movie_pictureBox
            // 
            this.add_movie_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_movie_pictureBox.Image = global::Dhaka_Movie_Database.Properties.Resources.plus;
            this.add_movie_pictureBox.Location = new System.Drawing.Point(502, 170);
            this.add_movie_pictureBox.Name = "add_movie_pictureBox";
            this.add_movie_pictureBox.Size = new System.Drawing.Size(24, 25);
            this.add_movie_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_movie_pictureBox.TabIndex = 11;
            this.add_movie_pictureBox.TabStop = false;
            this.add_movie_pictureBox.Click += new System.EventHandler(this.add_movie_pictureBox_Click);
            // 
            // search_pictureBox
            // 
            this.search_pictureBox.Image = global::Dhaka_Movie_Database.Properties.Resources.musica_searcher;
            this.search_pictureBox.Location = new System.Drawing.Point(449, 96);
            this.search_pictureBox.Name = "search_pictureBox";
            this.search_pictureBox.Size = new System.Drawing.Size(21, 21);
            this.search_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_pictureBox.TabIndex = 3;
            this.search_pictureBox.TabStop = false;
            this.search_pictureBox.Click += new System.EventHandler(this.search_pictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(190, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 106;
            this.label2.Text = "Movie List";
            // 
            // home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.see_member_request_label);
            this.Controls.Add(this.suggest_movie_label);
            this.Controls.Add(this.add_movie_pictureBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.signup_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.Hall_Box);
            this.Controls.Add(this.search_pictureBox);
            this.Controls.Add(this.search_Box);
            this.Controls.Add(this.category_Box);
            this.Controls.Add(this.dmdb_label);
            this.Name = "home_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_movie_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dmdb_label;
        private System.Windows.Forms.ComboBox category_Box;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.PictureBox search_pictureBox;
        private System.Windows.Forms.ComboBox Hall_Box;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label signup_label;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox add_movie_pictureBox;
        private System.Windows.Forms.Label suggest_movie_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label see_member_request_label;
        private System.Windows.Forms.Label label2;
    }
}

