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
    public partial class home_Form : Form
    {
        public home_Form()
        {
            InitializeComponent();
            //Hall_Box.Items.Add("etwrw");
        }
        //SqlDataAdapter sd;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlDataAdapter sd;
            DataTable dt1 = new DataTable();
            string nameq = "Select Name from Hall_Owner";
            sd = new SqlDataAdapter(nameq, con);
            sd.Fill(dt1);

            List<String> hallnames= new List<String>();
            for (int a = 0; a < dt1.Rows.Count; a++)
            {
                hallnames.Add(dt1.Rows[a]["Name"].ToString());
            }
            string[] array = hallnames.ToArray();
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

            if (search_Box.Text == "")
            {
                sd = new SqlDataAdapter("SELECT * FROM Movie_Information", con);
            }
            else
            {
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
            //int pageNumber = 1;
            //IPagedList<> list;
           // dataGridView.DataSource = GetDataValue();
        }


        private void add_movie_pictureBox_Click(object sender, EventArgs e)
        {
            Log_in login = new Log_in();
            Hide();
            login.Show();
        }

        private void search_pictureBox_Click(object sender, EventArgs e)
        {
            //Form1_Load(sender, e);

        }

        private void search_Box_TextChanged(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void category_Box_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Hall_Box_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dmdb_label_Click(object sender, EventArgs e)
        {
            search_Box.Text = "";
            Form1_Load(sender, e);
        }

        private void suggest_movie_label_Click(object sender, EventArgs e)
        {
            Log_in login = new Log_in();
            Hide();
            login.Show();
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            Log_in login = new Log_in();
            Hide();
            login.Show();
        }

        private void signup_label_Click(object sender, EventArgs e)
        {
            
            Sign_up signup = new Sign_up();
            Hide();
            signup.ShowDialog();
        }

        private void see_member_request_label_Click(object sender, EventArgs e)
        {
            Hide();
            See_Member_Request request = new See_Member_Request();
            request.Show();
        }
    }
}
