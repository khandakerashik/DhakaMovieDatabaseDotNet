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
    public partial class Admin_see_movie_list : Form
    {
        string email;
        public Admin_see_movie_list()
        {
            InitializeComponent();
        }
        public Admin_see_movie_list(string email)
        {
            InitializeComponent();
            this.email=email;
        }

        private void Admin_see_member_list_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlDataAdapter sd;
            DataTable dt1 = new DataTable();
            string nameq = "Select Name from Hall_Owner";
            sd = new SqlDataAdapter(nameq, con);
            sd.Fill(dt1);

            List<String> stringArr = new List<String>();
            for (int a = 0; a < dt1.Rows.Count; a++)
            {
                stringArr.Add(dt1.Rows[a]["Name"].ToString());
            }
            string[] array = stringArr.ToArray();
            Hall_Box.Items.AddRange(array);

            SqlDataAdapter sd2;
            string catq = "Select DISTINCT Category from Movie_Information";
            sd2 = new SqlDataAdapter(catq, con);
            DataTable dt2 = new DataTable();
            sd2.Fill(dt2);

            List<String> categories = new List<String>();
            for (int a = 0; a < dt2.Rows.Count; a++)
            {
                categories.Add(dt2.Rows[a]["Category"].ToString());
            }
            string[] categoriesarr = categories.ToArray();
            category_Box.Items.AddRange(categoriesarr);

            if (search_Box.Text == string.Empty)
            {
                sd = new SqlDataAdapter("SELECT * FROM Movie_Information", con);

            }
            else
            {

                //var x = from a in b.Members
                //    where a.id == int.Parse(id.Text)
                //    select a;

                //LIKE '%Smi%' AND FirstName LIKE '%A%'
                //"Select * from Movie_Information where Name LIKE '%" + ab +"%'"
                string query = "Select * from Movie_Information where Name LIKE '%" + search_Box.Text + "%'";

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
                dataGridView.Rows[n].Cells[1].Value = item["Rating"].ToString();
                dataGridView.Rows[n].Cells[2].Value = item["Category"].ToString();
                dataGridView.Rows[n].Cells[3].Value = item["Duration"].ToString();
                dataGridView.Rows[n].Cells[4].Value = item["ReleaseYear"].ToString();
                dataGridView.Rows[n].Cells[5].Value = item["Hall"].ToString();

            }
        }
        private void search_Box_TextChanged(object sender, EventArgs e)
        {
            Admin_see_member_list_Load(sender, e);
        }
        private void category_Box_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlDataAdapter sd;
            string selectedcat = category_Box.Text.ToString();
            string query = "SELECT * FROM Movie_Information where Category = '" + selectedcat + "'";

            sd = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView.Rows.Add();
                var button = new DataGridViewButtonColumn();
                dataGridView.Rows[n].Cells[0].Value = item["Name"].ToString();
                dataGridView.Rows[n].Cells[1].Value = item["Rating"].ToString();
                dataGridView.Rows[n].Cells[2].Value = item["Category"].ToString();
                dataGridView.Rows[n].Cells[3].Value = item["Duration"].ToString();
                dataGridView.Rows[n].Cells[4].Value = item["ReleaseYear"].ToString();
                dataGridView.Rows[n].Cells[5].Value = item["Hall"].ToString();

            }

        }

        private void Hall_Box_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlDataAdapter sd;
            string selectedtype = Hall_Box.Text.ToString();
            string query = "SELECT * FROM Movie_Information where Hall = '" + selectedtype + "'";

            sd = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView.Rows.Add();
                var button = new DataGridViewButtonColumn();
                dataGridView.Rows[n].Cells[0].Value = item["Name"].ToString();
                dataGridView.Rows[n].Cells[1].Value = item["Rating"].ToString();
                dataGridView.Rows[n].Cells[2].Value = item["Category"].ToString();
                dataGridView.Rows[n].Cells[3].Value = item["Duration"].ToString();
                dataGridView.Rows[n].Cells[4].Value = item["ReleaseYear"].ToString();
                dataGridView.Rows[n].Cells[5].Value = item["Hall"].ToString();
            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_Interface admin =new Admin_Interface(email);
            admin.Show();
        }

        private void log_out_label_Click(object sender, EventArgs e)
        {
            Hide();
            home_Form home = new home_Form();
            home.Show();
        }
    }
}
