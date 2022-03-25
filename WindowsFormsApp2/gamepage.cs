using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class gamepage : Form
    {
        static class RoundNum
        {
            public static int counter;
        }
        static class ScoreNum
        {
            public static int counter;
        }
        public class CharPos
        {
            public static int counter;
        }
        public class Displacement
        {
            public static int counter;
        }
        public class InitialVel
        {
            public static int counter;
        }
        public class FinalVel
        {
            public static int counter;
        }
        public class Acceleration
        {
            public static int counter;
        }
        public class Time
        {
            public static int counter;
        }
        public class Degrees
        {
            public static int counter;
        }
        public class HeightProj
        {
            public static int counter;
        }
        public class Hit
        {
            public static string counter;
        }
        public class Barrel
        {
            public static int counter;
        }
        public class Test
        {
            public static int counter;
        }
        public class HeightPr
        {
            public static int counter;
        }
        public gamepage()
        {
            InitializeComponent();

            textBox5.Hide();
            textBox6.Hide();
            textBox9.Hide();
            button1.Hide();
            panel1.Hide();
            textBox10.Hide();

            Hit.counter = "No";

            Acceleration.counter = Convert.ToInt32(9.81);

            RoundNum.counter = 1;
            ScoreNum.counter = 0;
            Random randomPos = new Random();
            int rPos = randomPos.Next(0, 10);
            CharPos.counter = rPos;
            Random randomNum = new Random();
            int rNum = randomNum.Next(1, 10);
            Barrel.counter = rNum;

            textBox2.Text = "Round Number: " + RoundNum.counter;
            textBox1.Text = "Total Points: " + ScoreNum.counter;
            textBox3.Text = "Barrel Height: " + Barrel.counter;
            textBox4.Text = "Characters Distance: " + CharPos.counter;
        }
        protected void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            
            RoundNum.counter = RoundNum.counter + 1;
            textBox2.Text = "Round Number: " + RoundNum.counter;

            Random randomPos2 = new Random();
            int rPos2 = randomPos2.Next(0, 100);
            CharPos.counter = rPos2;
            textBox4.Text = "Characters Distance: " + CharPos.counter;

            Random randTest = new Random();
            int rTest = randTest.Next(0, 2);
            Test.counter = rTest;

            panel1.Paint += DrawBezier;

            if (HeightPr.counter >= Barrel.counter)
            {
                Hit.counter = "Yes";
            }
            else if (HeightPr.counter < Barrel.counter)
            {
                Hit.counter = "No";
            }

            if (Hit.counter == "Yes")
            {
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox7.Hide();
                textBox8.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                button2.Hide();

                textBox6.Show();
                button1.Show();

                ScoreNum.counter = ScoreNum.counter + 1;
                textBox1.Text = "Total Points: " + ScoreNum.counter;
            }
            else if (Hit.counter == "No")
            {
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox7.Hide();
                textBox8.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                button2.Hide();

                textBox9.Show();
                button1.Show();

                ScoreNum.counter = ScoreNum.counter - 1;
                textBox1.Text = "Total Points: " + ScoreNum.counter;
            }

            if (RoundNum.counter > 15)
            {
                button2.Text = "Going to end page now!";
                Task.Delay(1000).Wait();
                var Score = ScoreNum.counter.ToString();
                textBox5.Text = Score;
                endpage f3 = new endpage(textBox5.Text);
                f3.ShowDialog();
                button2.Text = "Next Button";
            }
        }
        void DrawBezier(object sender, PaintEventArgs u)
        {
            Degrees.counter = Convert.ToInt32(textBox8.Text);
            InitialVel.counter = Convert.ToInt32(textBox7.Text);

            Displacement.counter = Convert.ToInt32(Math.Pow(InitialVel.counter, 2) * Math.Sin(2 * Degrees.counter) / Acceleration.counter);
            Time.counter = Convert.ToInt32(2 * (InitialVel.counter * Math.Sin(Degrees.counter)) / Acceleration.counter);
            HeightProj.counter = Convert.ToInt32(Math.Pow((InitialVel.counter * Math.Sin(Degrees.counter)), 2) / 2 * Acceleration.counter);

            int HeightP = 104-HeightProj.counter;
            float HeightP2 = Math.Abs(HeightP/10);

            HeightPr.counter = (int)Math.Round(HeightP2);
            
            textBox10.Text = HeightPr.counter.ToString();
            
            Point start = new Point(0, 104);
            Point control1 = new Point(182, HeightP);
            Point control2 = new Point(364, 104);
            Point end = new Point(364, 104);


            Pen rpen = new Pen(Color.Red, 3);
            u.Graphics.DrawBezier(rpen, start, control1, control2, end);
        }
        void ClearBezier(object sender, PaintEventArgs u)
        {
            u.Graphics.Clear(Color.White);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random randomPos = new Random();
            int rPos = randomPos.Next(0, 10);
            CharPos.counter = rPos;
            Random randomNum = new Random();
            int rNum = randomNum.Next(1, 10);
            Barrel.counter = rNum;

            panel1.Paint += ClearBezier;
            panel1.Hide();
            textBox7.Text = "Input Angle of Launch...";
            textBox8.Text = "Input Initial Velocity...";
            if (Hit.counter == "Yes")
            {
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox7.Show();
                textBox8.Show();
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                button2.Show();

                textBox6.Hide();
                button1.Hide();
            }
            else if (Hit.counter == "No")
            {
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox7.Show();
                textBox8.Show();
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                button2.Show();

                textBox9.Hide();
                button1.Hide();
            }
                
        }
    }
}
