namespace Dhaka_Movie_Database
{
    partial class Admin_see_hall_owner_list
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // log_out_label
            // 
            this.log_out_label.AutoSize = true;
            this.log_out_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_label.ForeColor = System.Drawing.Color.Navy;
            this.log_out_label.Location = new System.Drawing.Point(637, 65);
            this.log_out_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.log_out_label.Name = "log_out_label";
            this.log_out_label.Size = new System.Drawing.Size(84, 24);
            this.log_out_label.TabIndex = 74;
            this.log_out_label.Text = "Log Out";
            this.log_out_label.Click += new System.EventHandler(this.log_out_label_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.Navy;
            this.email_label.Location = new System.Drawing.Point(555, 65);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(70, 24);
            this.email_label.TabIndex = 73;
            this.email_label.Text = "Admin";
            this.email_label.Click += new System.EventHandler(this.email_label_Click);
            // 
            // dmdb_label
            // 
            this.dmdb_label.AutoSize = true;
            this.dmdb_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmdb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmdb_label.Location = new System.Drawing.Point(29, 30);
            this.dmdb_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dmdb_label.Name = "dmdb_label";
            this.dmdb_label.Size = new System.Drawing.Size(279, 91);
            this.dmdb_label.TabIndex = 72;
            this.dmdb_label.Text = "DMDB";
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(131, 134);
            this.search_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(387, 22);
            this.search_Box.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 704);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 69;
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
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(45, 224);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(563, 514);
            this.dataGridView.TabIndex = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contact";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Location";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Seat";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(271, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 75;
            this.label1.Text = "Hall Owner";
            // 
            // Admin_see_hall_owner_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log_out_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.dmdb_label);
            this.Controls.Add(this.search_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_see_hall_owner_list";
            this.Text = "Admin_see_hall_owner_list";
            this.Load += new System.EventHandler(this.Admin_see_hall_owner_list_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
    }
}