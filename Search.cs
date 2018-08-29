using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Spartan_Corner__1._1_
{
    public partial class Search : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);
        public Search(string title)
        {
            InitializeComponent();
            lab_passTitle.Text = title;
        }
        private void Search_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      //Opens database
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from VendorProfile where Title= '" + lab_passTitle.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txt_service.Text = reader["Services"].ToString();
                    txt_Name.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    txt_contact.Text = reader["Contact"].ToString();
                    txt_Description.Text = reader["Description"].ToString();
                    txt_location.Text = reader["Address"].ToString();
                    txt_Promo.Text = reader["PROMO"].ToString();
                    txt_Availability.Text = reader["Availability"].ToString();
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
                string query_rate = "select * from AverageRating where VendorTitle= '" + lab_passTitle.Text + "'";
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

            try
            {
                connection.Open();      //Opens database
                OleDbCommand command_review = new OleDbCommand();
                command_review.Connection = connection;
                string query_review = " select * from Rate where VendorTitle='" + lab_passTitle.Text + "'";
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
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void but_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            LogIn f1 = new LogIn();     //Create form2 object
            f1.ShowDialog();
        }

        private void but_back_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            studentMenu f2 = new studentMenu();     //Create form2 object
            f2.ShowDialog();
        }

        private void but_Menu_Click_1(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            LogIn f1 = new LogIn();     //Create form2 object
            f1.ShowDialog();
        }

        private void lab_title_Click(object sender, EventArgs e)
        {

        }

        private void txt_location_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
