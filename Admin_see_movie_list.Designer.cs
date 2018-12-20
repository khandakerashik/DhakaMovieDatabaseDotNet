namespace Dhaka_Movie_Database
{
    partial class Admin_see_movie_list
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Hall_Box = new System.Windows.Forms.ComboBox();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.category_Box = new System.Windows.Forms.ComboBox();
            this.back_button = new System.Windows.Forms.Button();
            this.log_out_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.dmdb_label = new System.Windows.Forms.Label();
            this.search_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(45, 234);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(800, 475);
            this.dataGridView.TabIndex = 55;
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
            this.Hall_Box.Location = new System.Drawing.Point(684, 137);
            this.Hall_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hall_Box.Name = "Hall_Box";
            this.Hall_Box.Size = new System.Drawing.Size(160, 24);
            this.Hall_Box.TabIndex = 61;
            this.Hall_Box.Text = "Hall";
            this.Hall_Box.SelectedIndexChanged += new System.EventHandler(this.Hall_Box_SelectedIndexChanged_1);
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(265, 138);
            this.search_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(367, 22);
            this.search_Box.TabIndex = 60;
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
            this.category_Box.Location = new System.Drawing.Point(44, 137);
            this.category_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.category_Box.Name = "category_Box";
            this.category_Box.Size = new System.Drawing.Size(160, 24);
            this.category_Box.TabIndex = 59;
            this.category_Box.Text = "Category";
            this.category_Box.SelectedIndexChanged += new System.EventHandler(this.category_Box_SelectedIndexChanged_1);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(745, 738);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(100, 28);
            this.back_button.TabIndex = 66;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // log_out_label
            // 
            this.log_out_label.AutoSize = true;
            this.log_out_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_label.ForeColor = System.Drawing.Color.Navy;
            this.log_out_label.Location = new System.Drawing.Point(764, 50);
            this.log_out_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.log_out_label.Name = "log_out_label";
            this.log_out_label.Size = new System.Drawing.Size(84, 24);
            this.log_out_label.TabIndex = 65;
            this.log_out_label.Text = "Log Out";
            this.log_out_label.Click += new System.EventHandler(this.log_out_label_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.Navy;
            this.email_label.Location = new System.Drawing.Point(681, 50);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(70, 24);
            this.email_label.TabIndex = 64;
            this.email_label.Text = "Admin";
            // 
            // dmdb_label
            // 
            this.dmdb_label.AutoSize = true;
            this.dmdb_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmdb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmdb_label.Location = new System.Drawing.Point(29, 18);
            this.dmdb_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dmdb_label.Name = "dmdb_label";
            this.dmdb_label.Size = new System.Drawing.Size(279, 91);
            this.dmdb_label.TabIndex = 63;
            this.dmdb_label.Text = "DMDB";
            // 
            // search_pictureBox
            // 
            this.search_pictureBox.Image = global::Dhaka_Movie_Database.Properties.Resources.musica_searcher;
            this.search_pictureBox.Location = new System.Drawing.Point(605, 138);
            this.search_pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_pictureBox.Name = "search_pictureBox";
            this.search_pictureBox.Size = new System.Drawing.Size(28, 26);
            this.search_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_pictureBox.TabIndex = 62;
            this.search_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(364, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Viewers List";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // Admin_see_movie_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 778);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.log_out_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.dmdb_label);
            this.Controls.Add(this.search_pictureBox);
            this.Controls.Add(this.Hall_Box);
            this.Controls.Add(this.search_Box);
            this.Controls.Add(this.category_Box);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_see_movie_list";
            this.Text = "Admin_see_movie_list";
            this.Load += new System.EventHandler(this.Admin_see_member_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox search_pictureBox;
        private System.Windows.Forms.ComboBox Hall_Box;
        public System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.ComboBox category_Box;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label log_out_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label dmdb_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}