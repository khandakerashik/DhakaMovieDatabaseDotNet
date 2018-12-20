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
    public partial class Admin_see_hall_owner_list : Form
    {
        string email;
        public Admin_see_hall_owner_list()
        {
            InitializeComponent();
        }
        public Admin_see_hall_owner_list(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void Admin_see_hall_owner_list_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlDataAdapter sd;

            if (search_Box.Text == "")
            {
                sd = new SqlDataAdapter("SELECT * FROM Hall_Owner", con);
            }
            else
            {

                //var x = from a in b.Members
                //    where a.id == int.Parse(id.Text)
                //    select a;

                //LIKE '%Smi%' AND FirstName LIKE '%A%'
                //"Select * from Movie_Information where Name LIKE '%" + ab +"%'"
                string query = "Select * from Hall_Owner where Name LIKE '%" + search_Box.Text + "%'";

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
                dataGridView.Rows[n].Cells[2].Value = item["Contact"].ToString();
                dataGridView.Rows[n].Cells[3].Value = item["Location"].ToString();
                dataGridView.Rows[n].Cells[4].Value = item["Seat"].ToString();
                

            }
        }
        private void search_Box_TextChanged_1(object sender, EventArgs e)
        {
            Admin_see_hall_owner_list_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_Interface admin = new Admin_Interface(email);
            admin.Show();
        }

        private void log_out_label_Click(object sender, EventArgs e)
        {
            Hide();
            home_Form home = new home_Form();
            home.Show();
        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }
    }
}
