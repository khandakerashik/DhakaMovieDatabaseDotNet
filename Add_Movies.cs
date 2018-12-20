using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dhaka_Movie_Database
{
    public partial class Add_Movies : Form
    {
        Hall_Interface h;
        string email;
        Dhaka_Movie_DatabaseDataContext d = new Dhaka_Movie_DatabaseDataContext("Data Source=DESKTOP-G3RI794\\ASHIKSSQL;Initial Catalog='Dhaka Movie Database';Integrated Security=True");
        public Add_Movies()
        {
            InitializeComponent();
        }
        public Add_Movies(Hall_Interface h, string email)
        {
            InitializeComponent();
            this.h = h;
            this.email = email;
        }

        private void Add_Movies_Load(object sender, EventArgs e)
        {
            var x = from g in d.Hall_Owners
                    where g.Email == email
                    select g;

            email_label.Text = x.FirstOrDefault().Email;
            hall_name_label.Text = x.FirstOrDefault().Name;
            contact_label.Text = x.FirstOrDefault().Contact;
            seat_label.Text = x.FirstOrDefault().Seat.ToString();
            location_label.Text = x.FirstOrDefault().Location;
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
                if (name_edit_textBox.Text != string.Empty && contact_edit_textBox.Text != string.Empty && seat_edit_textBox.Text != string.Empty && location_edit_textBox.Text != string.Empty)
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
                }
                else
                    MessageBox.Show("Please Provode al update information", "Inpur Wrror", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ee)
            {
                MessageBox.Show("Check Validity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void log_out_label_Click(object sender, EventArgs e)
        {
            Hide();
            home_Form home = new home_Form();
            home.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            Hall_Interface viewerss = new Hall_Interface(email);
            viewerss.Show();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Movie_Information m = new Movie_Information();
            if (movie_name_textBox.Text != string.Empty && rating_textBox.Text!=string.Empty && category_textBox.Text!="Select Category" && duration_textBox.Text!=string.Empty && release_year_textBox.Text!=string.Empty)
            {
                try
                {
                    m.Name = movie_name_textBox.Text;
                    m.Rating = rating_textBox.Text;
                    m.Category = category_textBox.Text;
                    m.Duration = duration_textBox.Text;
                    m.ReleaseYear = int.Parse(release_year_textBox.Text);
                    m.Hall = hall_name_label.Text;
                    d.Movie_Informations.InsertOnSubmit(m);
                    d.SubmitChanges();
                    movie_name_textBox.Text = "";
                    rating_textBox.Text = "";
                    category_textBox.Text = "";
                    duration_textBox.Text = "";
                    release_year_textBox.Text = "";

                    s_added.Visible = true;
                    s_added.Text = "Successfully Added";

                }
                catch(Exception ee)
                {
                    MessageBox.Show("Please provide Valid Release Year", "Invalid Input",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                }
               
            }
            else
                MessageBox.Show("Please provide a movie name", "Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
