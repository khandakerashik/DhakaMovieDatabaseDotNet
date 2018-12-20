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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void sign_up_label_Click(object sender, EventArgs e)
        {
            Sign_up signup = new Sign_up();
            Hide();
            signup.Show();
        }

        private void dmdb_label_Click(object sender, EventArgs e)
        {
            home_Form homepage = new home_Form();
            Hide();
            homepage.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-6F9HU70;Initial Catalog=Dhaka Movie Database;Integrated Security=True");
            //SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM User_Info", con);
            //DataTable dt = new DataTable();
            //sd.Fill(dt);

            Dhaka_Movie_DatabaseDataContext d = new Dhaka_Movie_DatabaseDataContext("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            try
            {
                var x = from g in d.User_Infos
                        where g.Email == email_textBox.Text
                        select g;
                if (x.FirstOrDefault().Password.Equals(password_textBox.Text))
                {
                    
                    if (x.First().Type.Equals("User"))
                    {
                        
                        Hide();
                        Viewers_Interface viewers = new Viewers_Interface(this, email_textBox.Text);
                        viewers.Show();
                    }
                    else if (x.First().Type.Equals("Hall Owner"))
                    {
                        Hide();
                        Hall_Interface hall = new Hall_Interface(this, email_textBox.Text);
                        hall.Show();
                    }
                    else if (x.First().Type.Equals("Admin"))
                    {
                        Hide();
                        Admin_Interface admin = new Admin_Interface(this, email_textBox.Text);
                        admin.Show();
                    }
                    else if (x.First().Type.Equals("Block"))
                    {
                        MessageBox.Show("Sorry You are a Block User","Block User",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Wrong UserId");
            }
            catch (Exception)
            {
                MessageBox.Show("Fill your UserId and Password");
            }
            d.Dispose();

            //if (query1)
            //{

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            home_Form home = new home_Form();
            home.Show();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
