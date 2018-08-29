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
    public partial class studentMenu : Form
    {
        int searchCount = 1;
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);
        public studentMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    //Opens Form 2*/
        }

        private void but_rate_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            Review f4 = new Review();     //Create form2 object
            f4.ShowDialog();            //Opens Form 2*/
        }

        private void but_contact_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            Reports f5 = new Reports();     //Create form2 object
            f5.ShowDialog();
        }

        private void but_load_Click(object sender, EventArgs e)
        {

            try
            {
                int count =0;
                connection.Open();      //Opens database
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select Title, Category, Services from VendorProfile where (Category like '" + txt_search.Text + "')" +
                    " or (Services like '" + txt_search.Text + "') or (Title like '" + txt_search.Text + "')";
                command.CommandText = query;
                command.ExecuteNonQuery();

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridView1.DataSource = dt;
                connection.Close();

                if (count == 0)
                {
                    MessageBox.Show("No Results Found");
                }
;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "View More";
                btn.Text = "Search" + searchCount;
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                searchCount++;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentMenu_Load(object sender, EventArgs e)
        {
            connection.Open();      //Opens database
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select Title, Category, Services from VendorProfile ";
            command.CommandText = query;
            command.ExecuteNonQuery();

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            connection.Close();

            /*******Excecuted during search*************/
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "View More";
            btn.Text = "View";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string vendorTitle;
            if (e.ColumnIndex >= 3)
            {
                string PinInGrid = dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex - 3)].Value.ToString();      //Gets column title
                vendorTitle = PinInGrid;

                this.Hide();
                Search f3 = new Search(vendorTitle);     //Create form2 object
                f3.ShowDialog();
            }
            else return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            LogIn f3 = new LogIn();     //Create form2 object
            f3.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
