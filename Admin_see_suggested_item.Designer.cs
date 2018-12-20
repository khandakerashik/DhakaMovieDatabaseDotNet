namespace Dhaka_Movie_Database
{
    partial class Admin_see_suggested_item
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
            this.log_out_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.dmdb_label = new System.Windows.Forms.Label();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_movies_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.rating_textBox = new System.Windows.Forms.TextBox();
            this.duration_textBox = new System.Windows.Forms.TextBox();
            this.release_year_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.duration_label = new System.Windows.Forms.Label();
            this.release_year_label = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.success_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Category_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // log_out_label
            // 
            this.log_out_label.AutoSize = true;
            this.log_out_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_label.ForeColor = System.Drawing.Color.Navy;
            this.log_out_label.Location = new System.Drawing.Point(653, 74);
            this.log_out_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.log_out_label.Name = "log_out_label";
            this.log_out_label.Size = new System.Drawing.Size(84, 24);
            this.log_out_label.TabIndex = 86;
            this.log_out_label.Text = "Log Out";
            this.log_out_label.Click += new System.EventHandler(this.log_out_label_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.Navy;
            this.email_label.Location = new System.Drawing.Point(571, 74);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(70, 24);
            this.email_label.TabIndex = 85;
            this.email_label.Text = "Admin";
            // 
            // dmdb_label
            // 
            this.dmdb_label.AutoSize = true;
            this.dmdb_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmdb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmdb_label.Location = new System.Drawing.Point(45, 38);
            this.dmdb_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dmdb_label.Name = "dmdb_label";
            this.dmdb_label.Size = new System.Drawing.Size(279, 91);
            this.dmdb_label.TabIndex = 84;
            this.dmdb_label.Text = "DMDB";
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(147, 143);
            this.search_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(387, 22);
            this.search_Box.TabIndex = 83;
            this.search_Box.TextChanged += new System.EventHandler(this.search_Box_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(636, 553);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 81;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dataGridView.Location = new System.Drawing.Point(61, 240);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(332, 201);
            this.dataGridView.TabIndex = 82;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 71;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Movie_Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Add_movies_button
            // 
            this.Add_movies_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_movies_button.Location = new System.Drawing.Point(269, 463);
            this.Add_movies_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_movies_button.Name = "Add_movies_button";
            this.Add_movies_button.Size = new System.Drawing.Size(124, 34);
            this.Add_movies_button.TabIndex = 87;
            this.Add_movies_button.Text = "Add Movie";
            this.Add_movies_button.UseVisualStyleBackColor = true;
            this.Add_movies_button.Click += new System.EventHandler(this.Add_movies_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(607, 233);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(132, 22);
            this.name_textBox.TabIndex = 88;
            this.name_textBox.Visible = false;
            // 
            // rating_textBox
            // 
            this.rating_textBox.Location = new System.Drawing.Point(607, 265);
            this.rating_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rating_textBox.Name = "rating_textBox";
            this.rating_textBox.Size = new System.Drawing.Size(132, 22);
            this.rating_textBox.TabIndex = 89;
            this.rating_textBox.Visible = false;
            // 
            // duration_textBox
            // 
            this.duration_textBox.Location = new System.Drawing.Point(607, 329);
            this.duration_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.duration_textBox.Name = "duration_textBox";
            this.duration_textBox.Size = new System.Drawing.Size(132, 22);
            this.duration_textBox.TabIndex = 91;
            this.duration_textBox.Visible = false;
            // 
            // release_year_textBox
            // 
            this.release_year_textBox.Location = new System.Drawing.Point(607, 361);
            this.release_year_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.release_year_textBox.Name = "release_year_textBox";
            this.release_year_textBox.Size = new System.Drawing.Size(132, 22);
            this.release_year_textBox.TabIndex = 92;
            this.release_year_textBox.Visible = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(496, 240);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(45, 17);
            this.name_label.TabIndex = 94;
            this.name_label.Text = "Name";
            this.name_label.Visible = false;
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Location = new System.Drawing.Point(497, 273);
            this.rating_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(49, 17);
            this.rating_label.TabIndex = 95;
            this.rating_label.Text = "Rating";
            this.rating_label.Visible = false;
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(497, 305);
            this.category_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(65, 17);
            this.category_label.TabIndex = 96;
            this.category_label.Text = "Category";
            this.category_label.Visible = false;
            // 
            // duration_label
            // 
            this.duration_label.AutoSize = true;
            this.duration_label.Location = new System.Drawing.Point(497, 337);
            this.duration_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.duration_label.Name = "duration_label";
            this.duration_label.Size = new System.Drawing.Size(62, 17);
            this.duration_label.TabIndex = 97;
            this.duration_label.Text = "Duration";
            this.duration_label.Visible = false;
            // 
            // release_year_label
            // 
            this.release_year_label.AutoSize = true;
            this.release_year_label.Location = new System.Drawing.Point(497, 369);
            this.release_year_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.release_year_label.Name = "release_year_label";
            this.release_year_label.Size = new System.Drawing.Size(94, 17);
            this.release_year_label.TabIndex = 98;
            this.release_year_label.Text = "Release Year";
            this.release_year_label.Visible = false;
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.Location = new System.Drawing.Point(607, 423);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(85, 34);
            this.Add_button.TabIndex = 99;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Visible = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // success_label
            // 
            this.success_label.AutoSize = true;
            this.success_label.Location = new System.Drawing.Point(500, 473);
            this.success_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.success_label.Name = "success_label";
            this.success_label.Size = new System.Drawing.Size(46, 17);
            this.success_label.TabIndex = 100;
            this.success_label.Text = "label1";
            this.success_label.Visible = false;
            this.success_label.Click += new System.EventHandler(this.success_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(143, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 102;
            this.label1.Text = "Suggested Item";
            // 
            // Category_textBox
            // 
            this.Category_textBox.Location = new System.Drawing.Point(607, 298);
            this.Category_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Category_textBox.Name = "Category_textBox";
            this.Category_textBox.Size = new System.Drawing.Size(132, 22);
            this.Category_textBox.TabIndex = 103;
            this.Category_textBox.Visible = false;
            // 
            // Admin_see_suggested_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.Category_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.success_label);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.release_year_label);
            this.Controls.Add(this.duration_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.release_year_textBox);
            this.Controls.Add(this.duration_textBox);
            this.Controls.Add(this.rating_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.Add_movies_button);
            this.Controls.Add(this.log_out_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.dmdb_label);
            this.Controls.Add(this.search_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_see_suggested_item";
            this.Text = "Admin_see_suggested_item";
            this.Load += new System.EventHandler(this.Admin_see_suggested_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label log_out_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label dmdb_label;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button Add_movies_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox rating_textBox;
        private System.Windows.Forms.TextBox duration_textBox;
        private System.Windows.Forms.TextBox release_year_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label duration_label;
        private System.Windows.Forms.Label release_year_label;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label success_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Category_textBox;
    }
}