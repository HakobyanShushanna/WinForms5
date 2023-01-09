using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Task : Form
    {
        string[] words;
        public Task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            if (text.Length == 0)
            {
                MessageBox.Show("Մուտքագրեք տեքստ։ ");
                return;
            }

            label3.Text = LongestWord(text);
        }

        string LongestWord(string text)
        {
            words = text.Split(' ');

            string maxLength = words[0];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength.Length)
                {
                    maxLength = words[i];
                }
            }

            return maxLength;
        }
    }
}
