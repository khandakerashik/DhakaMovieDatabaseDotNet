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
    public partial class See_Member_Request : Form
    {
        public See_Member_Request()
        {
            InitializeComponent();
        }

        private void signup_label_Click(object sender, EventArgs e)
        {
            Sign_up signup = new Sign_up();
            Hide();
            signup.ShowDialog();
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            Log_in login = new Log_in();
            Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            home_Form home = new home_Form();
            home.Show();
        }

        private void See_Member_Request_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlDataAdapter sd;

            if (search_Box.Text == "")
            {
                sd = new SqlDataAdapter("SELECT * FROM Member_Request", con);
            }
            else
            {

                //var x = from a in b.Members
                //    where a.id == int.Parse(id.Text)
                //    select a;

                //LIKE '%Smi%' AND FirstName LIKE '%A%'
                //"Select * from Movie_Information where Name LIKE '%" + ab +"%'"
                string query = "Select * from Member_Request where Name LIKE '%" + search_Box.Text + "%'";

                sd = new SqlDataAdapter(query, con);
                //MessageBox.Show(query);
            }
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView.Rows.Add();

                var button = new DataGridViewButtonColumn();
                //button = MessageBox.Show();

                dataGridView.Rows[n].Cells[0].Value = item["Name"].ToString();
                dataGridView.Rows[n].Cells[1].Value = item["Email"].ToString();
                dataGridView.Rows[n].Cells[2].Value = item["Status"].ToString();

            }
        }

        private void search_Box_TextChanged(object sender, EventArgs e)
        {
            See_Member_Request_Load(sender, e);
        }
    }
}
