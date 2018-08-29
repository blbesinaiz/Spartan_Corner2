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
    public partial class IssueReports : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);

        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dataTable = new DataTable();   

        public IssueReports()
        {
            InitializeComponent();
            dgv_contactUs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Selction Mode
            dgv_contactUs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_contactUs.MultiSelect = false;
        }
               
        //Retriveval of Data
        private void retrieve()
        {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string sql = "select * from ContactUs";
            cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            dataTable = new DataTable();
            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            dgv_contactUs.DataSource = dataTable;
            connection.Close();
        }

        private void IssueReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDatabaseDataSet3.ContactUs' table. You can move, or remove it, as needed.
            this.contactUsTableAdapter1.Fill(this.appDatabaseDataSet3.ContactUs);
            retrieve();
        }

        //Add Account
        private void add()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                //Prompt user Confirmation
                if (MessageBox.Show("Are you sure that you want to add this report?", "Add Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    command.CommandText = "insert into ContactUs(CurrentDate, IssueDate, FullName, EmailAddress, Problem, Resolved) values('" + txt_currentDate.Text + "', '" + txt_issueDate.Text + "', '" + txt_fullName.Text + "' , '" + txt_email.Text + "' , '" + txt_issue.Text + "' , ' " + txt_resolved.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("New Report Created");
                }
                else
                    MessageBox.Show("No Report Created");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            //Refresh
            retrieve();
        }

        //Update DB
        private void update(int id, string currentDate, string issueDate, string fullName, string email, string issue, string resolved)
        {
            //Open connection, update, retrieve, DGView
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string sql = "update ContactUs set CurrentDate='" + currentDate + "',issueDate='" + issueDate + "',FullName='" + fullName + "',EmailAddress='" + email + "',Problem='" + issue + "', Resolved= '" + resolved + "' where ID=" + id + "";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    connection.Close();
                    retrieve();
                    MessageBox.Show("Successfully Updated");
                }



                //Refresh
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        //Delete from DB
        private void delete(int id)
        {
            //SQL
            String sql = "DELETE FROM ContactUs WHERE ID=" + id + "";
            cmd = new OleDbCommand(sql, connection);

            //Open Connection, Execute, Delete, Close connection
            try
            {
                connection.Open();
                adapter = new OleDbDataAdapter(cmd);

                adapter.DeleteCommand = connection.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                //Prompt user Confirmation
                if (MessageBox.Show("Are you sure that you want to delete this account?", "DELETE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successfully Deleted");
                    }
                }

                connection.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        //Clear txt boxes
        private void clearTxts()
        {
            txt_currentDate.Text = "";
            txt_issueDate.Text = "";
            txt_fullName.Text = "";
            txt_email.Text = "";
            txt_issue.Text = "";
            txt_resolved.Text = "";
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            add();
        }

        private void but_update_Click(object sender, EventArgs e)
        {
            String selected = dgv_contactUs.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            update(id, txt_currentDate.Text, txt_issueDate.Text, txt_fullName.Text, txt_email.Text, txt_issue.Text, txt_resolved.Text);
        }

        private void but_retrieve_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            string selected = dgv_contactUs.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            delete(id);
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            clearTxts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            Administator f2 = new Administator();     //Create form2 object
            f2.ShowDialog();
        }

        private void but_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            LogIn f1 = new LogIn();     //Create form2 object
            f1.ShowDialog();
        }

        private void dgv_contactUs_MouseClick(object sender, MouseEventArgs e)
        {
            txt_currentDate.Text = dgv_contactUs.SelectedRows[0].Cells[1].Value.ToString();
            txt_issueDate.Text = dgv_contactUs.SelectedRows[0].Cells[2].Value.ToString();
            if (dgv_contactUs.SelectedRows[0].Cells[3].Value == null)
            {
                txt_fullName.Text = "";
            }
            else
                txt_fullName.Text = dgv_contactUs.SelectedRows[0].Cells[3].Value.ToString();
            txt_email.Text = dgv_contactUs.SelectedRows[0].Cells[4].Value.ToString();
            txt_issue.Text = dgv_contactUs.SelectedRows[0].Cells[5].Value.ToString();
            if (dgv_contactUs.SelectedRows[0].Cells[6].Value == null)
            {
                txt_resolved.Text = "";
            }
            else
                txt_resolved.Text = dgv_contactUs.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
