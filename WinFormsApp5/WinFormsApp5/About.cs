using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class About : Form
    {
        Timer myTimer = new Timer();
        int i = 0;
        Label[] labels;
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            labels = new Label[3] { label1, label2, label3 };

            myTimer.Interval = 1000;
            myTimer.Tick += new EventHandler(timer1_Tick);
            myTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < labels.Length; j++)
            {
                labels[j].Visible = false;
            }

            labels[i].Visible = true;
            i = i >= labels.Length - 1 ? i = 0 : i += 1;
        }
    }
}
