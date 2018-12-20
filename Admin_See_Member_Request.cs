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
    public partial class Admin_See_Member_Request : Form
    {
        string email;
        Dhaka_Movie_DatabaseDataContext d = new Dhaka_Movie_DatabaseDataContext("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        public Admin_See_Member_Request()
        {
            InitializeComponent();
        }
        public Admin_See_Member_Request(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void Admin_See_Member_Request_Load(object sender, EventArgs e)
        {




            dataGridView.Rows.Clear();
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlDataAdapter sd;

            if (search_Box.Text == "")
            {
                sd = new SqlDataAdapter("SELECT * FROM Member_Request", con);
            }
            else
            {
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

                dataGridView.Rows[n].Cells[0].Value = item["Name"].ToString();
                dataGridView.Rows[n].Cells[1].Value = item["Email"].ToString();
                dataGridView.Rows[n].Cells[2].Value = item["Status"].ToString();
                dataGridView.Rows[n].Cells[3].Value = "Confirm";

            }
        }
        private void search_Box_TextChanged_1(object sender, EventArgs e)
        {
            Admin_See_Member_Request_Load(sender, e);
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dataGridView.Rows[e.RowIndex].Cells[1].Value;
            con.Open();
            string query1 = "SELECT Email from Viewers_Info where Email = '" + item + "'";
            string query2 = "SELECT Email from Hall_Owner where Email = '" + item + "'";
            string query3 = "SELECT Email from User_Info where Email = '" + item + "'";
            SqlCommand cmd1 = new SqlCommand(query1,con);
            SqlCommand cmd2 = new SqlCommand(query2,con);
            SqlCommand cmd3 = new SqlCommand(query3,con);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            string result1 = (string)cmd1.ExecuteScalar();
            string result2 = (string)cmd2.ExecuteScalar();
            string result3 = (string)cmd3.ExecuteScalar();

            if(result3==item.ToString())
            {
                success_label.Visible = true;
                success_label.Text = "Already Added";
            }
            else if(result1==item.ToString())
            {
                //MessageBox.Show("Viewers_Info");
                string query4 = "SELECT Password from Viewers_Info where Email = '" + item + "'";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                cmd4.ExecuteNonQuery();
                string pass_result = (string)cmd4.ExecuteScalar();
                string query5 = "insert into User_Info  values ('" + result1 + "','" + pass_result + "','User')";
                SqlDataAdapter sda = new SqlDataAdapter(query5, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                success_label.Visible = true;
                var x = from g in d.Member_Requests
                        where g.Email == item.ToString()
                        select g;
                x.First().Status = "Accept";
                d.SubmitChanges();
            }
            else if(result2==item.ToString())
            {
                MessageBox.Show("Hall_Owner");
                string query4 = "SELECT Password from Hall_Owner where Email = '" + item + "'";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                cmd4.ExecuteNonQuery();
                string pass_result = (string)cmd4.ExecuteScalar();
                string query5 = "insert into User_Info  values ('" + result2 + "','" + pass_result + "','Hall Owner')";
                SqlDataAdapter sda = new SqlDataAdapter(query5, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                success_label.Visible = true;
                var x = from g in d.Member_Requests
                        where g.Email == item.ToString()
                        select g;
                x.First().Status= "Accept";
                d.SubmitChanges();
            }
            else
                success_label.Visible = false;
            con.Close();
            Admin_See_Member_Request_Load(sender,e);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
