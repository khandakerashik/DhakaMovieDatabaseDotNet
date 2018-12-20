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
    public partial class Suggest_movie : Form
    {
        Viewers_Interface v;
        string email;
        Dhaka_Movie_DatabaseDataContext d = new Dhaka_Movie_DatabaseDataContext("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        SqlDataAdapter sd;
        public Suggest_movie()
        {
            InitializeComponent();
        }
        public Suggest_movie(Viewers_Interface v, string email)
        {
            InitializeComponent();
            this.v = v;
            this.email = email;

        }
        private void Suggest_movie_Load(object sender, EventArgs e)
        {
            var x = from g in d.Viewers_Infos
                    where g.Email == email
                    select g;

            name_label.Text = x.FirstOrDefault().Email;
            hall_name_label.Text = x.FirstOrDefault().Name;
            contact_label.Text = x.FirstOrDefault().Contact;
        }

        private void log_out_label_Click(object sender, EventArgs e)
        {
            Hide();
            home_Form home = new home_Form();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name_edit_label.Visible = true;
            name_edit_textBox.Visible = true;
            contact_edit_label.Visible = true;
            contact_edit_textBox.Visible = true;
            update_button.Visible = true;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            var x = from g in d.Viewers_Infos
                    where g.Email == email
                    select g;

            x.First().Name = name_edit_textBox.Text;
            x.First().Contact = contact_edit_textBox.Text;

            d.SubmitChanges();

            hall_name_label.Text = name_edit_textBox.Text;
            contact_label.Text = contact_edit_textBox.Text;

            name_edit_label.Visible = false;
            name_edit_textBox.Visible = false;
            contact_edit_label.Visible = false;
            contact_edit_textBox.Visible = false;
            update_button.Visible = false;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            Viewers_Interface viewerss = new Viewers_Interface(email);
            viewerss.Show();
        }

        private void suggest_button_Click(object sender, EventArgs e)
        {
            if (movie_name_textBox.Text != string.Empty)
            {
                Suggested_Movie m = new Suggested_Movie();
                var x = from g in d.Suggested_Movies
                        where g.Movie_Name == movie_name_textBox.Text
                        select g;

                con.Open();
                string query = "SELECT Movie_Name FROM Suggested_Movie";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                string type = (string)cmd.ExecuteScalar();
                con.Close();
                if (movie_name_textBox.Text == type)
                {

                    MessageBox.Show("Already Suggested");

                }

                else if (movie_name_textBox.Text != type)
                {
                    string query2 = "insert into Suggested_Movie  values ('" + email + "','" + movie_name_textBox.Text.ToString() + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    movie_name_textBox.Text = "";
                    s_added.Visible = true;
                    s_added.Text = "Successfully Added";
                }
                else
                    MessageBox.Show("Please provide a movie name", "Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Enter a movie name","Input Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
        }
    }
}
