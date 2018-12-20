using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dhaka_Movie_Database
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void dmdb_label_Click(object sender, EventArgs e)
        {
            home_Form homepage = new home_Form();
            Hide();
            homepage.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hall Owner")
            {
                full_name_label.Visible = true;
                full_name_textBox.Visible = true;
                email_label.Visible = true;
                email_textBox.Visible = true;
                password_label.Visible = true;
                password_textBox.Visible = true;
                contact_label.Visible = true;
                contact_textBox.Visible = true;
                location_label.Visible = true;
                location_textBox.Visible = true;
                seat_label.Visible = true;
                seat_textbox.Visible = true;
                submit_button.Visible = true;
                type_label.Visible = false;
            }
            else if (comboBox1.Text == "User")
            {
                full_name_label.Visible = true;
                full_name_textBox.Visible = true;
                email_label.Visible = true;
                email_textBox.Visible = true;
                password_label.Visible = true;
                password_textBox.Visible = true;
                contact_label.Visible = true;
                contact_textBox.Visible = true;
                submit_button.Visible = true;
                type_label.Visible = false;
            }
            else
                type_label.Visible = true;
            
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlCommand sd1;
            SqlCommand sd2;
            SqlCommand sd3;
            SqlCommand sd4;
            if(comboBox1.Text == "Select Type")
            {
                MessageBox.Show("Plaese provide your Information", "Sign UP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(comboBox1.Text== "Hall Owner")
            {
                seat_textbox.Visible = true;
                seat_label.Visible = true;
                if(full_name_textBox.Text != string.Empty && email_textBox.Text != string.Empty && password_textBox.Text != string.Empty && contact_textBox.Text != string.Empty && location_textBox.Text != string.Empty && seat_textbox.Text != string.Empty)
                {
                    
                    con.Open();
                    string query1 = "INSERT INTO Hall_Owner VALUES('" + full_name_textBox.Text + "','" + email_textBox.Text + "','" + password_textBox.Text + "','" + contact_textBox.Text + "','" + location_textBox.Text + "','" + comboBox1.Text + "','" + int.Parse(seat_textbox.Text) + "')";
                    //string query2 = "INSERT INTO User_Info VALUES('" + email_textBox.Text + "','" + password_textBox.Text + "','" + comboBox1.Text + "')";
                    string query3 = "INSERT INTO Member_Request VALUES('" + full_name_textBox.Text + "','" + email_textBox.Text + "','" + comboBox1.Text + "','Pending')";
                    sd1 = new SqlCommand(query1, con);
                    sd2 = new SqlCommand(query3, con);
                    
                    sd1.ExecuteNonQuery();
                    sd2.ExecuteNonQuery();
                    con.Close();
                    success_label.Visible = true;

                    full_name_textBox.Text = "";
                    email_textBox.Text = "";
                    password_textBox.Text = "";
                    contact_textBox.Text = "";
                    location_textBox.Text = "";
                    comboBox1.Text = "Select category";
                    seat_textbox.Text = "";
                }
                else
                    MessageBox.Show("Plaese provide your Information", "Sign UP", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else if (comboBox1.Text == "User")
            {
                if (full_name_textBox.Text != string.Empty && email_textBox.Text != string.Empty && password_textBox.Text != string.Empty && contact_textBox.Text != string.Empty)
                {
                    con.Open();
                    string query1 = "INSERT INTO Viewers_Info VALUES('" + full_name_textBox.Text + "','" + email_textBox.Text + "','" + password_textBox.Text + "','" + contact_textBox.Text + "','" + comboBox1.Text + "')";
                    //string query2 = "INSERT INTO User_Info VALUES('" + email_textBox.Text + "','" + password_textBox.Text + "','" + comboBox1.Text + "')";
                    string query3 = "INSERT INTO Member_Request VALUES('" + full_name_textBox.Text + "','" + email_textBox.Text + "','" + comboBox1.Text + "','Pending')";
                    sd3 = new SqlCommand(query1, con);
                    sd4 = new SqlCommand(query3, con);
   
                    sd3.ExecuteNonQuery();
                    sd4.ExecuteNonQuery();
                    con.Close();
                    success_label.Visible = true;
                    full_name_textBox.Text = "";
                    email_textBox.Text = "";
                    password_textBox.Text = "";
                    contact_textBox.Text = "";
                    comboBox1.Text = "Select category";
                }
                else
                    MessageBox.Show("Please provide your Information","Sign UP",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                

            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            Log_in login= new Log_in();
            login.Show();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            
        }
    }
}
