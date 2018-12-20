namespace Dhaka_Movie_Database
{
    partial class Hall_Interface
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
            this.Hall_Box = new System.Windows.Forms.ComboBox();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.category_Box = new System.Windows.Forms.ComboBox();
            this.dmdb_label = new System.Windows.Forms.Label();
            this.suggest_movie_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.seat_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.location_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.movie_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.log_out_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hall_name_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.contact_edit_label = new System.Windows.Forms.Label();
            this.name_edit_label = new System.Windows.Forms.Label();
            this.contact_edit_textBox = new System.Windows.Forms.TextBox();
            this.name_edit_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.seat_edit_label = new System.Windows.Forms.Label();
            this.seat_edit_textBox = new System.Windows.Forms.TextBox();
            this.locationedit_label = new System.Windows.Forms.Label();
            this.location_edit_textBox = new System.Windows.Forms.TextBox();
            this.add_mpvie_pictureBox = new System.Windows.Forms.PictureBox();
            this.search_pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_mpvie_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.Hall_Box.Location = new System.Drawing.Point(508, 107);
            this.Hall_Box.Name = "Hall_Box";
            this.Hall_Box.Size = new System.Drawing.Size(121, 21);
            this.Hall_Box.TabIndex = 31;
            this.Hall_Box.Text = "Hall";
            this.Hall_Box.SelectedIndexChanged += new System.EventHandler(this.Hall_Box_SelectedIndexChanged_1);
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(194, 108);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(276, 20);
            this.search_Box.TabIndex = 29;
            this.search_Box.TextChanged += new System.EventHandler(this.search_Box_TextChanged);
            // 
            // category_Box
            // 
            this.category_Box.FormattingEnabled = true;
            this.category_Box.Items.AddRange(new object[] {
            "War",
            "Action",
            "Drama",
            "Hrror"});
            this.category_Box.Location = new System.Drawing.Point(28, 107);
            this.category_Box.Name = "category_Box";
            this.category_Box.Size = new System.Drawing.Size(121, 21);
            this.category_Box.TabIndex = 28;
            this.category_Box.Text = "Category";
            this.category_Box.SelectedIndexChanged += new System.EventHandler(this.category_Box_SelectedIndexChanged);
            // 
            // dmdb_label
            // 
            this.dmdb_label.AutoSize = true;
            this.dmdb_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmdb_label.Font = new System.Drawing.Font("20th Century Font", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmdb_label.Location = new System.Drawing.Point(16, 20);
            this.dmdb_label.Name = "dmdb_label";
            this.dmdb_label.Size = new System.Drawing.Size(194, 67);
            this.dmdb_label.TabIndex = 27;
            this.dmdb_label.Text = "DMDB";
            this.dmdb_label.Click += new System.EventHandler(this.dmdb_label_Click);
            // 
            // suggest_movie_label
            // 
            this.suggest_movie_label.AutoSize = true;
            this.suggest_movie_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suggest_movie_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggest_movie_label.Location = new System.Drawing.Point(535, 199);
            this.suggest_movie_label.Name = "suggest_movie_label";
            this.suggest_movie_label.Size = new System.Drawing.Size(80, 15);
            this.suggest_movie_label.TabIndex = 34;
            this.suggest_movie_label.Text = "Add Movies";
            this.suggest_movie_label.Click += new System.EventHandler(this.suggest_movie_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Contact :";
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Location = new System.Drawing.Point(596, 278);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(61, 13);
            this.contact_label.TabIndex = 36;
            this.contact_label.Text = "192879123";
            // 
            // seat_label
            // 
            this.seat_label.AutoSize = true;
            this.seat_label.Location = new System.Drawing.Point(596, 307);
            this.seat_label.Name = "seat_label";
            this.seat_label.Size = new System.Drawing.Size(61, 13);
            this.seat_label.TabIndex = 40;
            this.seat_label.Text = "4.5(dummy)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Seat :";
            // 
            // location_label
            // 
            this.location_label.AutoSize = true;
            this.location_label.Location = new System.Drawing.Point(597, 342);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(46, 13);
            this.location_label.TabIndex = 42;
            this.location_label.Text = "(dummy)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(503, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Location :";
            // 
            // movie_label
            // 
            this.movie_label.AutoSize = true;
            this.movie_label.Location = new System.Drawing.Point(597, 374);
            this.movie_label.Name = "movie_label";
            this.movie_label.Size = new System.Drawing.Size(46, 13);
            this.movie_label.TabIndex = 44;
            this.movie_label.Text = "(dummy)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(503, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Movie";
            // 
            // log_out_label
            // 
            this.log_out_label.AutoSize = true;
            this.log_out_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out_label.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_label.ForeColor = System.Drawing.Color.Navy;
            this.log_out_label.Location = new System.Drawing.Point(570, 50);
            this.log_out_label.Name = "log_out_label";
            this.log_out_label.Size = new System.Drawing.Size(62, 18);
            this.log_out_label.TabIndex = 46;
            this.log_out_label.Text = "Log Out";
            this.log_out_label.Click += new System.EventHandler(this.log_out_label_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.Navy;
            this.email_label.Location = new System.Drawing.Point(508, 50);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(45, 18);
            this.email_label.TabIndex = 45;
            this.email_label.Text = "Email";
            this.email_label.Click += new System.EventHandler(this.login_label_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(29, 194);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(452, 430);
            this.dataGridView.TabIndex = 47;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rating";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Duration";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Release Year";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hall";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // hall_name_label
            // 
            this.hall_name_label.AutoSize = true;
            this.hall_name_label.Location = new System.Drawing.Point(597, 249);
            this.hall_name_label.Name = "hall_name_label";
            this.hall_name_label.Size = new System.Drawing.Size(56, 13);
            this.hall_name_label.TabIndex = 49;
            this.hall_name_label.Text = "Hall Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Name :";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(554, 578);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 24);
            this.update_button.TabIndex = 99;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Visible = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // contact_edit_label
            // 
            this.contact_edit_label.AutoSize = true;
            this.contact_edit_label.Location = new System.Drawing.Point(500, 484);
            this.contact_edit_label.Name = "contact_edit_label";
            this.contact_edit_label.Size = new System.Drawing.Size(44, 13);
            this.contact_edit_label.TabIndex = 98;
            this.contact_edit_label.Text = "Contact";
            this.contact_edit_label.Visible = false;
            // 
            // name_edit_label
            // 
            this.name_edit_label.AutoSize = true;
            this.name_edit_label.Location = new System.Drawing.Point(500, 455);
            this.name_edit_label.Name = "name_edit_label";
            this.name_edit_label.Size = new System.Drawing.Size(35, 13);
            this.name_edit_label.TabIndex = 97;
            this.name_edit_label.Text = "Name";
            this.name_edit_label.Visible = false;
            // 
            // contact_edit_textBox
            // 
            this.contact_edit_textBox.Location = new System.Drawing.Point(554, 481);
            this.contact_edit_textBox.Name = "contact_edit_textBox";
            this.contact_edit_textBox.Size = new System.Drawing.Size(98, 20);
            this.contact_edit_textBox.TabIndex = 96;
            this.contact_edit_textBox.Visible = false;
            // 
            // name_edit_textBox
            // 
            this.name_edit_textBox.Location = new System.Drawing.Point(554, 455);
            this.name_edit_textBox.Name = "name_edit_textBox";
            this.name_edit_textBox.Size = new System.Drawing.Size(98, 20);
            this.name_edit_textBox.TabIndex = 95;
            this.name_edit_textBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 94;
            this.button1.Text = "Edit Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seat_edit_label
            // 
            this.seat_edit_label.AutoSize = true;
            this.seat_edit_label.Location = new System.Drawing.Point(500, 510);
            this.seat_edit_label.Name = "seat_edit_label";
            this.seat_edit_label.Size = new System.Drawing.Size(29, 13);
            this.seat_edit_label.TabIndex = 102;
            this.seat_edit_label.Text = "Seat";
            this.seat_edit_label.Visible = false;
            // 
            // seat_edit_textBox
            // 
            this.seat_edit_textBox.Location = new System.Drawing.Point(554, 507);
            this.seat_edit_textBox.Name = "seat_edit_textBox";
            this.seat_edit_textBox.Size = new System.Drawing.Size(98, 20);
            this.seat_edit_textBox.TabIndex = 101;
            this.seat_edit_textBox.Visible = false;
            // 
            // locationedit_label
            // 
            this.locationedit_label.AutoSize = true;
            this.locationedit_label.Location = new System.Drawing.Point(500, 536);
            this.locationedit_label.Name = "locationedit_label";
            this.locationedit_label.Size = new System.Drawing.Size(48, 13);
            this.locationedit_label.TabIndex = 104;
            this.locationedit_label.Text = "Location";
            this.locationedit_label.Visible = false;
            // 
            // location_edit_textBox
            // 
            this.location_edit_textBox.Location = new System.Drawing.Point(554, 533);
            this.location_edit_textBox.Name = "location_edit_textBox";
            this.location_edit_textBox.Size = new System.Drawing.Size(98, 20);
            this.location_edit_textBox.TabIndex = 103;
            this.location_edit_textBox.Visible = false;
            // 
            // add_mpvie_pictureBox
            // 
            this.add_mpvie_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_mpvie_pictureBox.Image = global::Dhaka_Movie_Database.Properties.Resources.plus;
            this.add_mpvie_pictureBox.Location = new System.Drawing.Point(505, 194);
            this.add_mpvie_pictureBox.Name = "add_mpvie_pictureBox";
            this.add_mpvie_pictureBox.Size = new System.Drawing.Size(24, 25);
            this.add_mpvie_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_mpvie_pictureBox.TabIndex = 33;
            this.add_mpvie_pictureBox.TabStop = false;
            this.add_mpvie_pictureBox.Click += new System.EventHandler(this.add_mpvie_pictureBox_Click);
            // 
            // search_pictureBox
            // 
            this.search_pictureBox.Image = global::Dhaka_Movie_Database.Properties.Resources.musica_searcher;
            this.search_pictureBox.Location = new System.Drawing.Point(449, 107);
            this.search_pictureBox.Name = "search_pictureBox";
            this.search_pictureBox.Size = new System.Drawing.Size(21, 21);
            this.search_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_pictureBox.TabIndex = 30;
            this.search_pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(204, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 105;
            this.label2.Text = "Movie List";
            // 
            // Hall_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationedit_label);
            this.Controls.Add(this.location_edit_textBox);
            this.Controls.Add(this.seat_edit_label);
            this.Controls.Add(this.seat_edit_textBox);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.contact_edit_label);
            this.Controls.Add(this.name_edit_label);
            this.Controls.Add(this.contact_edit_textBox);
            this.Controls.Add(this.name_edit_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hall_name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.log_out_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.movie_label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.location_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.seat_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suggest_movie_label);
            this.Controls.Add(this.add_mpvie_pictureBox);
            this.Controls.Add(this.Hall_Box);
            this.Controls.Add(this.search_pictureBox);
            this.Controls.Add(this.search_Box);
            this.Controls.Add(this.category_Box);
            this.Controls.Add(this.dmdb_label);
            this.Name = "Hall_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hall_Interface";
            this.Load += new System.EventHandler(this.Hall_Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_mpvie_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Hall_Box;
        private System.Windows.Forms.PictureBox search_pictureBox;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.ComboBox category_Box;
        private System.Windows.Forms.Label dmdb_label;
        private System.Windows.Forms.Label suggest_movie_label;
        private System.Windows.Forms.PictureBox add_mpvie_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Label seat_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label movie_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label log_out_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label hall_name_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label contact_edit_label;
        private System.Windows.Forms.Label name_edit_label;
        private System.Windows.Forms.TextBox contact_edit_textBox;
        private System.Windows.Forms.TextBox name_edit_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label seat_edit_label;
        private System.Windows.Forms.TextBox seat_edit_textBox;
        private System.Windows.Forms.Label locationedit_label;
        private System.Windows.Forms.TextBox location_edit_textBox;
        private System.Windows.Forms.Label label2;
    }
}