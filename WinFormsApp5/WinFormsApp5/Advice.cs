using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Advice : Form
    {
        string path =
   Path.Combine(
       Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
       "static files/AdviceForADay.txt"
   );
        string[] tips;
        int i = 0;
        Random rnd = new Random();

        public Advice()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = rnd.Next(0, 7);

            textBox1.Text = tips[i];
        }

        private void Advice_Load(object sender, EventArgs e)
        {
            tips = File.ReadAllLines(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = i >= tips.Length - 1 ? i = 0 : i += 1;

            textBox1.Text = tips[i];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = i <= 0 ? i = tips.Length - 1 : i -= 1;

            textBox1.Text = tips[i];
        }
    }
}
