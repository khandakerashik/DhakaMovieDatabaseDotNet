namespace Dhaka_Movie_Database
{
    partial class See_Member_Request
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
            this.signup_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.dmdb_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_label.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_label.ForeColor = System.Drawing.Color.Navy;
            this.signup_label.Location = new System.Drawing.Point(500, 45);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(59, 18);
            this.signup_label.TabIndex = 9;
            this.signup_label.Text = "Sign Up";
            this.signup_label.Click += new System.EventHandler(this.signup_label_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_label.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.Navy;
            this.login_label.Location = new System.Drawing.Point(438, 45);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(49, 18);
            this.login_label.TabIndex = 8;
            this.login_label.Text = "Log In";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // dmdb_label
            // 
            this.dmdb_label.AutoSize = true;
            this.dmdb_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmdb_label.Font = new System.Drawing.Font("20th Century Font", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmdb_label.Location = new System.Drawing.Point(12, 25);
            this.dmdb_label.Name = "dmdb_label";
            this.dmdb_label.Size = new System.Drawing.Size(194, 67);
            this.dmdb_label.TabIndex = 7;
            this.dmdb_label.Text = "DMDB";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(484, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 22;
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
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Location = new System.Drawing.Point(38, 226);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(422, 403);
            this.dataGridView.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(102, 138);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(270, 20);
            this.search_Box.TabIndex = 24;
            this.search_Box.TextChanged += new System.EventHandler(this.search_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(177, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 106;
            this.label2.Text = "Member Request";
            // 
            // search_pictureBox
            // 
            this.search_pictureBox.Image = global::Dhaka_Movie_Database.Properties.Resources.musica_searcher;
            this.search_pictureBox.Location = new System.Drawing.Point(369, 138);
            this.search_pictureBox.Name = "search_pictureBox";
            this.search_pictureBox.Size = new System.Drawing.Size(21, 21);
            this.search_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_pictureBox.TabIndex = 25;
            this.search_pictureBox.TabStop = false;
            // 
            // See_Member_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 641);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_pictureBox);
            this.Controls.Add(this.search_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signup_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.dmdb_label);
            this.Controls.Add(this.dataGridView);
            this.Name = "See_Member_Request";
            this.Text = "See_Member_Request";
            this.Load += new System.EventHandler(this.See_Member_Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signup_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label dmdb_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.PictureBox search_pictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
    }
}