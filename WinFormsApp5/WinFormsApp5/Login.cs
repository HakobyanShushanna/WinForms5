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
    public partial class Login : Form
    {
        string path =
            Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                @"static files\UserNameAndPassword.txt"
            );

        string[] nameAndPassword;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameAndPassword = File.ReadAllLines(path);

            if (textBox1.Text == nameAndPassword[0] && textBox2.Text == nameAndPassword[1])
            {
                Menu menu = new Menu();
                menu.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Սխալ անուն կամ գաղտնաբառ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeNameOrPassword change = new ChangeNameOrPassword();
            change.Show();
        }
    }
}
