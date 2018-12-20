namespace Dhaka_Movie_Database
{
    partial class Viewers_Interface
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
            this.hall_name_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_label = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.suggest_movie_label = new System.Windows.Forms.Label();
            this.Hall_Box = new System.Windows.Forms.ComboBox();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.category_Box = new System.Windows.Forms.ComboBox();
            this.dmdb_label = new System.Windows.Forms.Label();
            this.name_edit_textBox = new System.Windows.Forms.TextBox();
            this.contact_edit_textBox = new System.Windows.Forms.TextBox();
            this.name_edit_label = new System.Windows.Forms.Label();
            this.contact_edit_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.log_out_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.suggest_movie_pictureBox = new System.Windows.Forms.PictureBox();
            this.search_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggest_movie_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hall_name_label
            // 
            this.hall_name_label.AutoSize = true;
            this.hall_name_label.Location = new System.Drawing.Point(575, 300);
            this.hall_name_label.Name = "hall_name_label";
            this.hall_name_label.Size = new System.Drawing.Size(56, 13);
            this.hall_name_label.TabIndex = 71;
            this.hall_name_label.Text = "Hall Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Name :";
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
            this.dataGridView.Location = new System.Drawing.Point(6, 204);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(452, 411);
            this.dataGridView.TabIndex = 69;
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
            this.Column5.HeaderText = "Release year";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hall";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.Navy;
            this.email_label.Location = new System.Drawing.Point(480, 51);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(45, 18);
            this.email_label.TabIndex = 67;
            this.email_label.Text = "Email";
            this.email_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Location = new System.Drawing.Point(574, 329);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(61, 13);
            this.contact_label.TabIndex = 58;
            this.contact_label.Text = "192879123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Contact :";
            // 
            // suggest_movie_label
            // 
            this.suggest_movie_label.AutoSize = true;
            this.suggest_movie_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suggest_movie_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggest_movie_label.Location = new System.Drawing.Point(513, 208);
            this.suggest_movie_label.Name = "suggest_movie_label";
            this.suggest_movie_label.Size = new System.Drawing.Size(108, 15);
            this.suggest_movie_label.TabIndex = 56;
            this.suggest_movie_label.Text = "Suggest Movies";
            this.suggest_movie_label.Click += new System.EventHandler(this.suggest_movie_label_Click);
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
            this.Hall_Box.Location = new System.Drawing.Point(485, 112);
            this.Hall_Box.Name = "Hall_Box";
            this.Hall_Box.Size = new System.Drawing.Size(121, 21);
            this.Hall_Box.TabIndex = 54;
            this.Hall_Box.Text = "Hall";
            this.Hall_Box.SelectedIndexChanged += new System.EventHandler(this.Hall_Box_SelectedIndexChanged);
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(171, 113);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(276, 20);
            this.search_Box.TabIndex = 52;
            this.search_Box.TextChanged += new System.EventHandler(this.search_Box_TextChanged_1);
            // 
            // category_Box
            // 
            this.category_Box.FormattingEnabled = true;
            this.category_Box.Items.AddRange(new object[] {
            "War",
            "Action",
            "Drama",
            "Hrror"});
            this.category_Box.Location = new System.Drawing.Point(5, 112);
            this.category_Box.Name = "category_Box";
            this.category_Box.Size = new System.Drawing.Size(121, 21);
            this.category_Box.TabIndex = 51;
            this.category_Box.Text = "Category";
            this.category_Box.SelectedIndexChanged += new System.EventHandler(this.category_Box_SelectedIndexChanged_1);
            // 
            // dmdb_label
            // 
            this.dmdb_label.AutoSize = true;
            this.dmdb_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmdb_label.Font = new System.Drawing.Font("20th Century Font", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmdb_label.Location = new System.Drawing.Point(-7, 25);
            this.dmdb_label.Name = "dmdb_label";
            this.dmdb_label.Size = new System.Drawing.Size(194, 67);
            this.dmdb_label.TabIndex = 50;
            this.dmdb_label.Text = "DMDB";
            // 
            // name_edit_textBox
            // 
            this.name_edit_textBox.Location = new System.Drawing.Point(537, 416);
            this.name_edit_textBox.Name = "name_edit_textBox";
            this.name_edit_textBox.Size = new System.Drawing.Size(98, 20);
            this.name_edit_textBox.TabIndex = 75;
            this.name_edit_textBox.Visible = false;
            // 
            // contact_edit_textBox
            // 
            this.contact_edit_textBox.Location = new System.Drawing.Point(537, 454);
            this.contact_edit_textBox.Name = "contact_edit_textBox";
            this.contact_edit_textBox.Size = new System.Drawing.Size(98, 20);
            this.contact_edit_textBox.TabIndex = 76;
            this.contact_edit_textBox.Visible = false;
            // 
            // name_edit_label
            // 
            this.name_edit_label.AutoSize = true;
            this.name_edit_label.Location = new System.Drawing.Point(483, 416);
            this.name_edit_label.Name = "name_edit_label";
            this.name_edit_label.Size = new System.Drawing.Size(35, 13);
            this.name_edit_label.TabIndex = 77;
            this.name_edit_label.Text = "Name";
            this.name_edit_label.Visible = false;
            // 
            // contact_edit_label
            // 
            this.contact_edit_label.AutoSize = true;
            this.contact_edit_label.Location = new System.Drawing.Point(483, 457);
            this.contact_edit_label.Name = "contact_edit_label";
            this.contact_edit_label.Size = new System.Drawing.Size(44, 13);
            this.contact_edit_label.TabIndex = 78;
            this.contact_edit_label.Text = "Contact";
            this.contact_edit_label.Visible = false;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_button.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(537, 495);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 79;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Visible = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // log_out_label
            // 
            this.log_out_label.AutoSize = true;
            this.log_out_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out_label.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_label.ForeColor = System.Drawing.Color.Navy;
            this.log_out_label.Location = new System.Drawing.Point(558, 51);
            this.log_out_label.Name = "log_out_label";
            this.log_out_label.Size = new System.Drawing.Size(62, 18);
            this.log_out_label.TabIndex = 80;
            this.log_out_label.Text = "Log Out";
            this.log_out_label.Click += new System.EventHandler(this.log_out_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(171, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 106;
            this.label2.Text = "Movie List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(484, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Edit Info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // suggest_movie_pictureBox
            // 
            this.suggest_movie_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suggest_movie_pictureBox.Image = global::Dhaka_Movie_Database.Properties.Resources.plus;
            this.suggest_movie_pictureBox.Location = new System.Drawing.Point(483, 203);
            this.suggest_movie_pictureBox.Name = "suggest_movie_pictureBox";
            this.suggest_movie_pictureBox.Size = new System.Drawing.Size(24, 25);
            this.suggest_movie_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.suggest_movie_pictureBox.TabIndex = 55;
            this.suggest_movie_pictureBox.TabStop = false;
            this.suggest_movie_pictureBox.Click += new System.EventHandler(this.suggest_movie_pictureBox_Click);
            // 
            // search_pictureBox
            // 
            this.search_pictureBox.Image = global::Dhaka_Movie_Database.Properties.Resources.musica_searcher;
            this.search_pictureBox.Location = new System.Drawing.Point(426, 112);
            this.search_pictureBox.Name = "search_pictureBox";
            this.search_pictureBox.Size = new System.Drawing.Size(21, 21);
            this.search_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_pictureBox.TabIndex = 53;
            this.search_pictureBox.TabStop = false;
            // 
            // Viewers_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log_out_label);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.contact_edit_label);
            this.Controls.Add(this.name_edit_label);
            this.Controls.Add(this.contact_edit_textBox);
            this.Controls.Add(this.name_edit_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hall_name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suggest_movie_label);
            this.Controls.Add(this.suggest_movie_pictureBox);
            this.Controls.Add(this.Hall_Box);
            this.Controls.Add(this.search_pictureBox);
            this.Controls.Add(this.search_Box);
            this.Controls.Add(this.category_Box);
            this.Controls.Add(this.dmdb_label);
            this.Name = "Viewers_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewers_Interface";
            this.Load += new System.EventHandler(this.Viewers_Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggest_movie_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hall_name_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label suggest_movie_label;
        private System.Windows.Forms.PictureBox suggest_movie_pictureBox;
        private System.Windows.Forms.ComboBox Hall_Box;
        private System.Windows.Forms.PictureBox search_pictureBox;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.ComboBox category_Box;
        private System.Windows.Forms.Label dmdb_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_edit_textBox;
        private System.Windows.Forms.TextBox contact_edit_textBox;
        private System.Windows.Forms.Label name_edit_label;
        private System.Windows.Forms.Label contact_edit_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label log_out_label;
        private System.Windows.Forms.Label label2;
    }
}