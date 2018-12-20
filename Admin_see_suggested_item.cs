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
using System.Timers;

namespace Dhaka_Movie_Database
{
    public partial class Admin_see_suggested_item : Form
    {
        string email;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        Dhaka_Movie_DatabaseDataContext d = new Dhaka_Movie_DatabaseDataContext("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        public Admin_see_suggested_item()
        {
            InitializeComponent();
        }
        public Admin_see_suggested_item(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void Admin_see_suggested_item_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-6F9HU70;Initial Catalog=Dhaka Movie Database;Integrated Security=True");
            SqlDataAdapter sd;

            if (search_Box.Text == "")
            {
                sd = new SqlDataAdapter("SELECT * FROM Suggested_Movie", con);
            }
            else
            {

                //var x = from a in b.Members
                //    where a.id == int.Parse(id.Text)
                //    select a;

                //LIKE '%Smi%' AND FirstName LIKE '%A%'
                //"Select * from Movie_Information where Name LIKE '%" + ab +"%'"
                string query = "Select * from Suggested_Movie where Email LIKE '%" + search_Box.Text + "%'";

                sd = new SqlDataAdapter(query, con);
                //MessageBox.Show(query);
            }
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView.Rows.Add();

                dataGridView.Rows[n].Cells[0].Value = item["Email"].ToString();
                dataGridView.Rows[n].Cells[1].Value = item["Movie_Name"].ToString();
            }
        }

        private void search_Box_TextChanged(object sender, EventArgs e)
        {
            Admin_see_suggested_item_Load(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_Interface admin = new Admin_Interface(email);
            admin.Show();
        }

        private void Add_movies_button_Click(object sender, EventArgs e)
        {
            name_label.Visible = true;
            name_textBox.Visible = true;
            rating_label.Visible = true;
            rating_textBox.Visible = true;
            category_label.Visible = true;
            Category_textBox.Visible = true;
            duration_label.Visible = true;
            duration_textBox.Visible = true;
            release_year_label.Visible = true;
            release_year_textBox.Visible = true;
            success_label.Visible = false;
            Add_button.Visible = true;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text != string.Empty && rating_textBox.Text != string.Empty && Category_textBox.Text != string.Empty && duration_textBox.Text != string.Empty && release_year_textBox.Text != string.Empty )
            {
                string query5 = "insert into Movie_Information(Name,Rating,Category,Duration,ReleaseYear) values ('" + name_textBox.Text + "','" + rating_textBox.Text + "','" + Category_textBox.Text + "','" + duration_textBox.Text + "','" + release_year_textBox.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query5, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                success_label.Visible = true;
               
                //success_label.Text = timer1_Tick() + name_textBox.Text;
            }
            else
            {
                MessageBox.Show("Fill all the Blanks");
            }

            success_label.Visible = true;
            if (success_label.Visible == true)
            {
                
            }
            name_textBox.Text = "";
            rating_textBox.Text = "";
            Category_textBox.Text = "";
            duration_textBox.Text = "";
            release_year_textBox.Text = "";
            

        }

        private void success_label_Click(object sender, EventArgs e)
        {
            success_label.Visible = false;
        }
        private void success_labell1()
        {
            success_label.Text = "This action is for administrator only.";
            System.Threading.Thread.Sleep(35000);
        }
            private void success_labell(object source, ElapsedEventArgs e)
        {
            
            //success_label.Hide();
        }

        private void log_out_label_Click(object sender, EventArgs e)
        {
            Hide();
            home_Form home = new home_Form();
            home.Show();
        }

    }
}
