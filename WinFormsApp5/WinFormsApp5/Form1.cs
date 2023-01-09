using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        Timer myTimer = new Timer();
        int x, y;
        bool isRight = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;

            if (y >= 0)
            {
                y -= 5;
                x = isRight == true ? x += 20 : x -= 20;

                if (x >= Width)
                {
                    isRight = false;
                }
            }
            else
            {
                myTimer.Stop();
                Hide();

                Login login = new Login();
                login.Show();
            }

            pictureBox1.Location = new Point(x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            label2.Text = $"{now.Day}.{now.Month}.{now.Year}";

            myTimer.Interval = 200;
            myTimer.Tick += new EventHandler(timer1_Tick);
            myTimer.Start();
        }
    }
}
