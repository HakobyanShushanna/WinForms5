using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UpdateStatus(ToolStripItem item)
        {
            if (item != null)
            {
                if (item.Text == "Խնդիր")
                {
                    Task task = new Task();
                    task.Show();
                }
                else if (item.Text == "Օրվա խորհուրդներ")
                {
                    Advice tips = new Advice();

                    tips.Show();
                }
                else if (item.Text == "Օգնություն")
                {
                    Help help = new Help();

                    help.Show();
                }
                else if (item.Text == "Հեղինակի մասին")
                {
                    About about = new About();

                    about.Show();
                }
                else if (item.Text == "Ելք")
                {
                    if (MessageBox.Show("Դուրս գա՞լ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            UpdateStatus(e.ClickedItem);
        }
    }
}
