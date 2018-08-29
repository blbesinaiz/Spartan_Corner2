using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;         //allows use of App.config
using System.Data.OleDb;

namespace Spartan_Corner__1._1_
{
    public partial class Edit_Profile : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);
        public string userName { get; private set; }     //passing user name
        //public string passedName { get; private set ; }     //passing user name
        vendorMenu _f1;
        public Edit_Profile(vendorMenu f1_)
        {
            InitializeComponent();
            this._f1 = f1_;
            lab_name2.Text = this._f1.userName2;        //Passed username from vendor menu to edit profile
        }
        
        private void but_back_Click(object sender, EventArgs e)
        {

        }

        private void but_Menu_Click_1(object sender, EventArgs e)
        {

        }

        private void com_vendors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_location_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Promo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ratings_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_service_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      //Opens database
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from VendorProfile where UserName='" + lab_name2.Text + "'";   //From label
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txt_title.Text = reader["Title"].ToString();
                    txt_service.Text = reader["Services"].ToString();
                    txt_Name.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    txt_contact.Text = reader["Contact"].ToString();
                    txt_Description.Text = reader["Description"].ToString();
                    txt_location.Text = reader["Address"].ToString();
                    txt_Promo.Text = reader["PROMO"].ToString();
                    txt_Availability.Text = reader["Availability"].ToString();
                    com_category.Text = reader["Category"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            try
            {
                connection.Open();      //Opens database
                OleDbCommand command_review = new OleDbCommand();
                command_review.Connection = connection;
                string query_review = " select * from Rate where VendorTitle='" + txt_title.Text + "'";
                command_review.CommandText = query_review;

                OleDbDataReader reader_review = command_review.ExecuteReader();
                while (reader_review.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(reader_review["ScreenName"].ToString());
                    item.SubItems.Add(reader_review["Rate"].ToString());
                    item.SubItems.Add(reader_review["Review"].ToString());
                    listView1.Items.Add(item);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            try
            {
                connection.Open();      //Opens database
                OleDbCommand command_rate = new OleDbCommand();
                command_rate.Connection = connection;
                string query_rate = "select * from AverageRating where VendorTitle= '" + txt_title.Text + "'";
                command_rate.CommandText = query_rate;

                OleDbDataReader reader_rate = command_rate.ExecuteReader();
                while (reader_rate.Read())
                {
                    txt_ratings.Text = reader_rate["AvgOfRate"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update vendorProfile set Category= '" + com_category.Text + "', Title= '" + txt_title.Text + "' , Services= '" + txt_service.Text + "' , PROMO= '" + txt_Promo.Text + "' , Description= '" + txt_Description.Text + "' , Contact= '" + txt_contact.Text + "' , Availability= '" + txt_Availability.Text + "' , Address= '" + txt_location.Text + "' where userName='" + lab_name2.Text + "'";
                
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Changes Saved Succesfully");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void lab_vendor_Click(object sender, EventArgs e)
        {

        }

        private void but_back_Click_1(object sender, EventArgs e)
        {
            userName = lab_name2.Text;     //Pass username to next form
            this.Hide();            //Hides Form 1/ Login screen
            //vendorMenu f9 = new vendorMenu(LogIn);     //Create form2 object
        }

        private void but_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            LogIn f2 = new LogIn();     //Create form2 object
            f2.ShowDialog();
        }

        private void lab_name2_Click(object sender, EventArgs e)
        {

        }

        private void but_back_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void but_Menu_Click_2(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            LogIn f2 = new LogIn();     //Create form2 object
            f2.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_title_MouseClick(object sender, MouseEventArgs e)
        {
            txt_title.Text = "";
        }

        private void txt_service_MouseClick(object sender, MouseEventArgs e)
        {
            txt_service.Text = "";
        }

        private void txt_Promo_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Promo.Text = "";
        }

        private void txt_Name_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_Name_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Name.Text = "";
        }

        private void txt_contact_MouseClick(object sender, MouseEventArgs e)
        {
            txt_contact.Text = "";
        }

        private void txt_location_MouseClick(object sender, MouseEventArgs e)
        {
            txt_location.Text = "";
        }

        private void txt_Availability_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Availability.Text = "";
        }

        private void txt_location_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
