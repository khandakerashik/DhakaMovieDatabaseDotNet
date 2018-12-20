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
    public partial class Hall_Interface : Form
    {
        String email;
        Log_in l;
        Dhaka_Movie_DatabaseDataContext d = new Dhaka_Movie_DatabaseDataContext("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        public Hall_Interface()
        {
            InitializeComponent();
        }
        public Hall_Interface(Log_in l, string email)
        {
            InitializeComponent();
            this.l = l;
            this.email = email;

        }
        public Hall_Interface(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        private void Hall_Interface_Load(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlDataAdapter sd2;
            DataTable dt1 = new DataTable();
            string nameq = "Select Name from Hall_Owner";
            sd2 = new SqlDataAdapter(nameq, con2);
            sd2.Fill(dt1);

            List<String> stringArr = new List<String>();
            for (int a = 0; a < dt1.Rows.Count; a++)
            {
                stringArr.Add(dt1.Rows[a]["Name"].ToString());
            }
            string[] array = stringArr.ToArray();
            Hall_Box.Items.AddRange(array);

            SqlDataAdapter sd3;
            string catq = "Select DISTINCT Category from Movie_Information";
            sd2 = new SqlDataAdapter(catq, con2);
            DataTable dt2 = new DataTable();
            sd2.Fill(dt2);

            List<String> categories = new List<String>();
            for (int a = 0; a < dt2.Rows.Count; a++)
            {
                categories.Add(dt2.Rows[a]["Category"].ToString());
            }
            string[] categoriesarr = categories.ToArray();
            category_Box.Items.AddRange(categoriesarr);
            var x = from g in d.Hall_Owners
                    where g.Email == email
                    select g;

            email_label.Text = x.FirstOrDefault().Email;
            hall_name_label.Text = x.FirstOrDefault().Name;
            contact_label.Text = x.FirstOrDefault().Contact;
            seat_label.Text = x.FirstOrDefault().Seat.ToString();
            location_label.Text = x.FirstOrDefault().Location;

            dataGridView.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
            SqlDataAdapter sd;
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
            Hall_Interface_Load(sender, e);
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

        private void dmdb_label_Click(object sender, EventArgs e)
        {

        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name_edit_label.Visible = true;
            name_edit_textBox.Visible = true;
            contact_edit_label.Visible = true;
            contact_edit_textBox.Visible = true;
            locationedit_label.Visible = true;
            location_edit_textBox.Visible = true;
            seat_edit_label.Visible = true;
            seat_edit_textBox.Visible = true;
            update_button.Visible = true;

            name_edit_textBox.Text = "";
            contact_edit_textBox.Text = "";
            seat_edit_textBox.Text = "";
            location_edit_textBox.Text = "";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if(name_edit_textBox.Text!=string.Empty && contact_edit_textBox.Text!=string.Empty && seat_edit_textBox.Text!=string.Empty && location_edit_textBox.Text!=string.Empty)
                {
                    var x = from g in d.Hall_Owners
                            where g.Email == email
                            select g;

                    x.First().Name = name_edit_textBox.Text;
                    x.First().Contact = contact_edit_textBox.Text;
                    x.First().Seat = int.Parse(seat_edit_textBox.Text);
                    x.First().Location = locationedit_label.Text;

                    d.SubmitChanges();

                    hall_name_label.Text = name_edit_textBox.Text;
                    contact_label.Text = contact_edit_textBox.Text;
                    seat_label.Text = seat_edit_textBox.Text;
                    location_label.Text = location_edit_textBox.Text;

                    name_edit_label.Visible = false;
                    name_edit_textBox.Visible = false;
                    contact_edit_label.Visible = false;
                    contact_edit_textBox.Visible = false;
                    locationedit_label.Visible = false;
                    location_edit_textBox.Visible = false;
                    seat_edit_label.Visible = false;
                    seat_edit_textBox.Visible = false;
                    update_button.Visible = false;
                }else
                    MessageBox.Show("Please Provode al update information", "Inpur Wrror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 
            }
            catch(Exception ee)
            {
                MessageBox.Show("Check Validity","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void suggest_movie_label_Click(object sender, EventArgs e)
        {
            Hide();
            Add_Movies add = new Add_Movies(this,email);
            add.Show();
        }

        private void add_mpvie_pictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            Add_Movies add = new Add_Movies(this, email);
            add.Show();
        }

        private void log_out_label_Click(object sender, EventArgs e)
        {
            Hide();
            home_Form home = new home_Form();
            home.Show();
        }
    }
}
