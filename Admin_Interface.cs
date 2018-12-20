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
    public partial class Admin_Interface : Form
    {
        Log_in l;
        string email;
        public Admin_Interface()
        {
            InitializeComponent();
        }
        public Admin_Interface(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        public Admin_Interface(Log_in l,string email)
        {
            InitializeComponent();
            this.l = l;
            this.email = email;
        }

        private void Admin_Interface_Load(object sender, EventArgs e)
        {

        }

        private void see_movie_list_label_Click(object sender, EventArgs e)
        {

            Hide();
            Admin_see_movie_list see_member = new Admin_see_movie_list(email);
            see_member.Show();


        }
        

        private void see_member_req_label_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_See_Member_Request see_request = new Admin_See_Member_Request(email);
            see_request.Show();
        }

        private void dmdb_label_Click(object sender, EventArgs e)
        {

        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

  
        private void log_out_label_Click_1(object sender, EventArgs e)
        {
            Hide();
            home_Form home = new home_Form();
            home.Show();
        }

        private void see_hall_owner_label_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_see_hall_owner_list hallowner = new Admin_see_hall_owner_list(email);
            hallowner.Show();
        }

        private void see_viewers_label_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_see_viewers_list viewers = new Admin_see_viewers_list(email);
            viewers.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_see_suggested_item suggested = new Admin_see_suggested_item(email);
            suggested.Show();
        }
    }
}
