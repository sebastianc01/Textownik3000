using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        string path1;
        string path2;
        int totalDifferences = 10;
        int currentDifference = 1;
        public Form2(string f1, string f2)
        {
            path1 = f1;
            path2 = f2;
            InitializeComponent();
            richTextBox1.Text = File.ReadAllText(f1);
            richTextBox2.Text = File.ReadAllText(f2);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void previousDifferenceButton_Click(object sender, EventArgs e)
        {
            if(currentDifference > 1)
            {
                --currentDifference;
                currentDifferenceTextBox.Text = currentDifference.ToString();
            }
            else
            {
                MessageBox.Show("Current difference has to be over 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextDifferenceButton_Click(object sender, EventArgs e)
        {
            if(currentDifference < totalDifferences)
            {
                ++currentDifference;
                currentDifferenceTextBox.Text =  currentDifference.ToString();
            }
            else
            {
                MessageBox.Show("Current difference cannot be greater than total number of differences.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void file1TextButton_Click(object sender, EventArgs e)
        {

        }

        private void file2TextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
