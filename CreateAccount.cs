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
    public partial class CreateAccount : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void but_save_Click(object sender, EventArgs e)
        {

        }

        private void vendorAdd()
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into VendorProfile(UserName, FirstName, LastName) values('" + txt_user.Text + "', '" + txt_fname.Text + "', '" + txt_last.Text + "')";
            command.ExecuteNonQuery();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                if (MessageBox.Show("Are you sure you would like to create a new account?", "Submission Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    command.CommandText = "insert into LogIn(FirstName, LastName, UserName, Pass, Privilege) values('" + txt_fname.Text + "', '" + txt_last.Text + "', '" + txt_user.Text + "' , '" + txt_pass.Text + "' , '" + com_type.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("New Account Created");

                    if (com_type.Text == "vendor")
                    {
                        vendorAdd();
                    }
                }
                else
                    MessageBox.Show("Account Not Created");
              
                connection.Close();               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            this.Hide();
            LogIn f1 = new LogIn();
            f1.ShowDialog();
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fname_MouseClick(object sender, MouseEventArgs e)
        {
            txt_fname.Text = "";
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void txt_last_MouseClick(object sender, MouseEventArgs e)
        {
            txt_last.Text = "";
        }

        private void txt_user_MouseClick(object sender, MouseEventArgs e)
        {
            txt_user.Text = "";
        }

        private void txt_pass_MouseClick(object sender, MouseEventArgs e)
        {
            txt_pass.Text = "";
        }
    }
}
