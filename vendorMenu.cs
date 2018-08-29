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
    public partial class vendorMenu : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString.ToString();
        private OleDbConnection connection = new OleDbConnection(ConnectionString);
        public string userName2 { get; private set; }     //passing user name to edit profile

        LogIn _f1;      //Declare instance of LogIn form to pass userName variable
        //vendorMenu _f2;      //Declare instance of LogIn form to pass userName variable
        public vendorMenu(LogIn f1_)
        {
            InitializeComponent();
            this._f1 = f1_;
            lab_name.Text = this._f1.userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userName2 = lab_name.Text;     //Pass username to next form
            //this.Hide();            //Hides Form 1/ Login screen
            Edit_Profile  f8 = new Edit_Profile(this);     //Create form2 object
            f8.ShowDialog();
        }

        private void vendorMenu_Load(object sender, EventArgs e)
        {

        }

        private void but_contactUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports f1 = new Reports();
            f1.ShowDialog();
        }

        private void but_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn f1 = new LogIn();
            f1.ShowDialog();
        }
    }
}
