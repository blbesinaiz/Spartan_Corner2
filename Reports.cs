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
    public partial class Reports : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);
        public Reports()
        {
            InitializeComponent();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

               if (MessageBox.Show("Are you sure you would like to submit this inquiry?", "Submission Confirmation" ,MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
               {
                   command.CommandText = "insert into ContactUs(CurrentDate, IssueDate, FullName, EmailAddress, Problem) values('" + txt_currentDate.Text + "', '" + txt_issueDate.Text + "','" + txt_fullName.Text + "','" + txt_email.Text + "','" + txt_report.Text + "')";
                   command.ExecuteNonQuery();
                   MessageBox.Show("Submitted Successfully");
               }
               else
                   MessageBox.Show("Inquiry Not Submitted");

               connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            this.Hide();
            LogIn f3 = new LogIn();
            f3.ShowDialog();
        }

        private void txt_fullName_MouseClick(object sender, MouseEventArgs e)
        {
            txt_fullName.Text = "";
        }

        private void txt_currentDate_MouseClick(object sender, MouseEventArgs e)
        {
            txt_currentDate.Text = "";
        }

        private void txt_issueDate_MouseClick(object sender, MouseEventArgs e)
        {
            txt_issueDate.Text = "";
        }

        private void txt_email_MouseClick(object sender, MouseEventArgs e)
        {
            txt_email.Text = "";
        }

        private void txt_report_MouseClick(object sender, MouseEventArgs e)
        {
            txt_report.Text = "";
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
