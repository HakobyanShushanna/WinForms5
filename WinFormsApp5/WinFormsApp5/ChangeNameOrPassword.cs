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
    public partial class ChangeNameOrPassword : Form
    {
        string path =
           Path.Combine(
               Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
               @"static files\UserNameAndPassword.txt"
           );

        string[] nameAndPassword;
        public ChangeNameOrPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameAndPassword = File.ReadAllLines(path);

            if (textBox1.Text == nameAndPassword[0])
            {
                if (textBox2.Text.Length > 0)
                {
                    if (textBox2.Text == nameAndPassword[0])
                    {
                        MessageBox.Show("Հին և նոր անունները համընկնում են");
                    }
                    if (textBox3.Text == nameAndPassword[1])
                    {
                        MessageBox.Show("Հին և նոր գաղտնաբառերը համընկնում են");
                    }
                    nameAndPassword[0] = textBox2.Text;
                }

                nameAndPassword[1] = textBox3.Text;
            }

            File.WriteAllLines(path, nameAndPassword);

            MessageBox.Show("Ձեր անունն ու գաղտնաբառը փոխված են");
        }
    }
}
