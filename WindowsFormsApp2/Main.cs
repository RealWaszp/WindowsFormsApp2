using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Going to sign up page now!";
            Task.Delay(1000).Wait();
            Signup f3 = new Signup();
            f3.ShowDialog();
            button1.Text = "Sign Up";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Going to login page now!";
            Task.Delay(1000).Wait();
            Login f2 = new Login();
            f2.ShowDialog();
            button2.Text = "Login";
        }
    }
}
