using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spartan_Corner__1._1_
{
    public partial class Administator : Form
    {
        public Administator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            Accounts f6 = new Accounts();     //Create form2 object
            f6.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            CreateAccount f7 = new CreateAccount();     //Create form2 object
            f7.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            IssueReports f8 = new IssueReports();     //Create form2 object
            f8.ShowDialog();
        }

        private void but_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();            //Hides Form 1/ Login screen
            LogIn f3 = new LogIn();     //Create form2 object
            f3.ShowDialog();
        }
    }
}
