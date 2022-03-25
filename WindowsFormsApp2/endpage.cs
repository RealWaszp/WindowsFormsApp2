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
    public partial class endpage : Form
    {
        public endpage(string testingNum)
        {
            InitializeComponent();
            textBox1.Text = "You scored (" + testingNum + ") out of 15";
            if (Convert.ToInt32(testingNum) >= 7)
            {
                textBox2.Text = "You have won!";
            }
            else if (Convert.ToInt32(testingNum) < 7)
            {
                textBox2.Text = "You have lost!";
            }
        }
    }
}
