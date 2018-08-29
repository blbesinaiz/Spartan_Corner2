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
    public partial class Review : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);
        public Review()
        {
            InitializeComponent();
        }

        private void txt_vendorTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void com_vendorTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void updateRate()
        {
            
            OleDbCommand command = new OleDbCommand();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            

           /* string query_rate = "select * from Rate where VendorTitle=' " + com_vendorTitle.Text + " ' ";
            command.CommandText = query_rate;
            OleDbDataReader reader = command.ExecuteReader();
            int sum = 0;
            int count = 0;
            while (reader.Read())
            {
                sum = sum + ;
                count = count + 1;
            }*/

            int average = 0; //sum / count;

            string avg = average.ToString();

            command.Connection = connection;
            string sql = "UPDATE VendorProfile SET Rating=" + avg + " WHERE Title='" + com_vendorTitle.Text + "'";
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            try
            {
              
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Rate(ScreenName, VendorTitle, Review, Rate) values('" + txt_screenName.Text + "', '" + com_vendorTitle.Text + "', '" + txt_review.Text + "' , '" + com_rate.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Rating Submitted");
                connection.Close();

                this.Hide();            //Hides Form 1/ Login screen
                studentMenu f1 = new studentMenu();     //Create form2 object
                f1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill in all fields!" , "Submission Error");
                connection.Close();
            }

            updateRate();
        }

        private void Review_Load(object sender, EventArgs e)
        {
            connection.Open();      //Opens database
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = " select * from VendorProfile";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                com_vendorTitle.Items.Add(reader["Title"].ToString());
            }
            connection.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            studentMenu f1 = new studentMenu();     //Create form2 object
            f1.ShowDialog();
        }

        private void txt_screenName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
