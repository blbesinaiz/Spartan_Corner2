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
using System.Data.OleDb;            //OleDB connection

namespace Spartan_Corner__1._1_
{
    public partial class LogIn : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);
        public string userName { get; private set; }     //passing user name
        public LogIn()
        {
            InitializeComponent();
        }

        private void Log_In2_Load(object sender, EventArgs e)
        {

        }

        private void but_login_Click(object sender, EventArgs e)
        {
            //Student Login
             connection.Open();
             //Create command to validate database
             OleDbCommand command = new OleDbCommand();

             command.Connection = connection;   //Give "command" the conncection 
                                                //Create a query

            command.CommandText = "select * from LogIn where Username= '" + txt_userName.Text + "' and Pass= '" + txt_password.Text + "' and Privilege = 'student'";

            //Excecute query
            command.ExecuteNonQuery();     //Do non-query when want to get data from database (Don't want a return)


             OleDbDataReader reader = command.ExecuteReader();        //Read data from a dabase
             int count = 0;      //Variable to count values in command
             while (reader.Read())
             {
                 count++;        //Finds number of found results for the query executed
             }
             if (count == 1)
             {
                 //MessageBox.Show("Username and Password is correct for student");
                 connection.Close();     //Close database
                 connection.Dispose();   //Releases memory*/
                this.Hide();            //Hides Form 1/ Login screen
                studentMenu f2 = new studentMenu();     //Create form2 object
                f2.ShowDialog();            //Opens Form 2
            
            }

            else if (count > 1)      //Finds duplicate entry
            {
                MessageBox.Show("Duplicate Username and Password ");
            }

            else
            {
                MessageBox.Show("Username and Password NOT correct");
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vendor Login
            connection.Open();
            //Create command to validate database
            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;   //Give "command" the conncection 
            //Create a query
            command.CommandText = "select * from LogIn where Username= '" + txt_userName.Text + "' and Pass= '" + txt_password.Text + "' and Privilege = 'vendor'";
            //Excecute query
            command.ExecuteNonQuery();     //Do non-query when want to get data from database (Don't want a return)


            OleDbDataReader reader = command.ExecuteReader();        //Read data from a dabase
            int count = 0;      //Variable to count values in command
            while (reader.Read())
            {
                count++;        //Finds number of found results for the query executed
            }
            if (count == 1)
            {
                //MessageBox.Show("Username and Password is correct for vendor");
                connection.Close();     //Close database
                connection.Dispose();   //Releases memory */
                userName = txt_userName.Text;     //Pass username to next form
                this.Hide();            //Hides Form 1/ Login screen
                vendorMenu f9 = new vendorMenu(this);     //Create form2 object
                f9.ShowDialog();            //Opens Form 2*/
            }

            else if (count > 1)      //Finds duplicate entry
            {
                MessageBox.Show("Duplicate Username and Password ");
            }

            else
            {
                MessageBox.Show("Username and Password NOT correct");
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Admin Login
            connection.Open();
            //Create command to validate database
            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;   //Give "command" the conncection 
            //Create a query
            command.CommandText = "select * from LogIn where Username= '" + txt_userName.Text + "' and Pass= '" + txt_password.Text + "' and Privilege = 'administrator'";
            //Excecute query
            command.ExecuteNonQuery();     //Do non-query when want to get data from database (Don't want a return)


            OleDbDataReader reader = command.ExecuteReader();        //Read data from a dabase
            int count = 0;      //Variable to count values in command
            while (reader.Read())
            {
                count++;        //Finds number of found results for the query executed
            }
            if (count == 1)
            {
                //MessageBox.Show("Username and Password is correct for admin");
                connection.Close();     //Close database
                connection.Dispose();   //Releases memory*/
                this.Hide();            //Hides Form 1/ Login screen
                Administator f5 = new Administator();     //Create form2 object
                f5.ShowDialog();            //Opens Form 2
         }

            else if (count > 1)      //Finds duplicate entry
            {
                MessageBox.Show("Duplicate Username and Password ");
            }

            else
            {
                MessageBox.Show("Username and Password NOT correct");
            }
            connection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            CreateAccount f8 = new CreateAccount();     //Create form2 object
            f8.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            Reports f8 = new Reports();     //Create form2 object
            f8.ShowDialog();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
