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
    public partial class Accounts : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);

        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dataTable = new DataTable();

        public Accounts()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Selction Mode
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDatabaseDataSet.LogIn' table. You can move, or remove it, as needed.
            this.logInTableAdapter.Fill(this.appDatabaseDataSet.LogIn);

        }

        //Retriveval of Data
        private void retrieve()
        {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string sql = "select * from LogIn";
            cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            dataTable = new DataTable();
            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void vendorAdd()
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into VendorProfile(UserName, FirstName, LastName) values('" + txt_userName.Text + "', '" + txt_firstName.Text + "', '" + txt_lastName.Text + "')";
            command.ExecuteNonQuery();
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
                if (MessageBox.Show("Are you sure that you want to add this account?", "Submission Confirmation" , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    command.CommandText = "insert into LogIn(FirstName, LastName, UserName, Pass, Privilege) values('" + txt_firstName.Text + "', '" + txt_lastName.Text + "', '" + txt_userName.Text + "', '" + txt_pass.Text + "', '" + txt_privilege.Text + "')";
                    command.ExecuteNonQuery();
                    if (txt_privilege.Text == "vendor")
                    {
                        vendorAdd();
                    }
                    MessageBox.Show("New Account Created");
                }
                else
                    MessageBox.Show("No Account Created");

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
        private void update(int id, string firstName, string lastName, string userName, string password, string privilege)
        {
            //Open connection, update, retrieve, DGView
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string sql = "update LogIn set FirstName='" + firstName + "',LastName='" + lastName + "',UserName='" + userName + "',Pass='" + password + "',Privilege='" + privilege + "' where ID=" + id + "";
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

        private void vendorDelete(string userName)
        {
            /*String sql = "DELETE FROM VendorProfile WHERE UserName='" + txt_userName.Text + "'";
            cmd = new OleDbCommand(sql, connection);

            //Open Connection, Execute, Delete, Close connection
            try
            {
                adapter = new OleDbDataAdapter(cmd);

                adapter.DeleteCommand = connection.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                connection.Close();
                MessageBox.Show("Deleted vendor as well");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }*/

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM VendorProfile WHERE UserName='" + txt_userName.Text + "'";
            command.ExecuteNonQuery();

        }

        //Delete from DB
        private void delete(int id, string userName)
        {
            //SQL
            String sql = "DELETE FROM LogIn WHERE ID=" + id + "";
            cmd = new OleDbCommand(sql, connection);

            //Open Connection, Execute, Delete, Close connection
            try
            {
                connection.Open();
                adapter = new OleDbDataAdapter(cmd);

                adapter.DeleteCommand = connection.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                //Prompt user Confirmation
                if (MessageBox.Show("Are you sure that you want to delete this account?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        if(txt_privilege.Text == "vendor")
                        {
                            vendorDelete(userName);         //Delete vendor profile 
                        }
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
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_userName.Text = "";
            txt_pass.Text = "";
            txt_privilege.Text = "";
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_firstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_lastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_userName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_pass.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_privilege.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        //Buttons
        private void but_add_Click(object sender, EventArgs e)
        {
            add();
        }

        private void but_update_Click(object sender, EventArgs e)
        {
            String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            update(id, txt_firstName.Text, txt_lastName.Text, txt_userName.Text, txt_pass.Text, txt_privilege.Text);
        }

        private void but_retrieve_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            string userName = selected;

            delete(id, userName);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
