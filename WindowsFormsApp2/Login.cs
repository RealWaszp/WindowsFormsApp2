using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Going to game page now!";
            Task.Delay(1000).Wait();
            gamepage f1 = new gamepage();
            f1.ShowDialog();
            button3.Text = "Login Button";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
