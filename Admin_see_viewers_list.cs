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
    public partial class Admin_see_viewers_list : Form
    {
        string email;
        Dhaka_Movie_DatabaseDataContext d = new Dhaka_Movie_DatabaseDataContext("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        public Admin_see_viewers_list()
        {
            InitializeComponent();
        }
        public Admin_see_viewers_list(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void Admin_see_viewers_list_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-6F9HU70;Initial Catalog=Dhaka Movie Database;Integrated Security=True");
            SqlDataAdapter sd;

            if (search_Box.Text == "")
            {
                sd = new SqlDataAdapter("SELECT * FROM Viewers_Info", con);
            }
            else
            {

                //var x = from a in b.Members
                //    where a.id == int.Parse(id.Text)
                //    select a;

                //LIKE '%Smi%' AND FirstName LIKE '%A%'
                //"Select * from Movie_Information where Name LIKE '%" + ab +"%'"
                string query = "Select * from Viewers_Info where Name LIKE '%" + search_Box.Text + "%'";

                sd = new SqlDataAdapter(query, con);
                //MessageBox.Show(query);
            }
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView.Rows.Add();

                //var button = new DataGridViewButtonColumn();
                //button = MessageBox.Show();

                dataGridView.Rows[n].Cells[0].Value = item["Name"].ToString();
                dataGridView.Rows[n].Cells[1].Value = item["Email"].ToString();
                dataGridView.Rows[n].Cells[2].Value = item["Contact"].ToString();
                dataGridView.Rows[n].Cells[3].Value = "Block";
                dataGridView.Rows[n].Cells[4].Value = "UnBlock";
            }
        }

        private void search_Box_TextChanged(object sender, EventArgs e)
        {
            Admin_see_viewers_list_Load(sender, e);
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var item = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            var x = from g in d.User_Infos
                    where g.Email == item.ToString()
                    select g;

            x.First().Type = "Block";
            d.SubmitChanges();
            Admin_see_viewers_list_Load(sender, e);
            success_label.Visible = true;
            
    
        }


    }
}
