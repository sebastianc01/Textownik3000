using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
        List<Difference> differences;
        public Form2(string f1, string f2)
        {
            differences = new List<Difference>();
            path1 = f1;
            path2 = f2;
            InitializeComponent();
            richTextBox1.Text = File.ReadAllText(f1);
            richTextBox2.Text = File.ReadAllText(f2);
            differences.Add(new Difference(10, 10, 20, 10, true));      // tests
            differences.Add(new Difference(50, 6, 70, 3, true));        // tests
            differences.Add(new Difference(40, 2, 79, 3, true));        // tests
            differences.Add(new Difference(73, 6, 43, 8, false));       // tests
            differences.Add(new Difference(1000, 6, 1000, 6, false));   // tests
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void previousDifferenceButton_Click(object sender, EventArgs e)
        {
            totalDifferencesLabel.Text = totalDifferences.ToString();
            if (currentDifference > 1)
            {
                setToWhite(currentDifference - 1);
                --currentDifference;
                currentDifferenceTextBox.Text = currentDifference.ToString();
                highlightString(currentDifference - 1);
            }
            else
            {
                MessageBox.Show("Current difference has to be over 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextDifferenceButton_Click(object sender, EventArgs e)
        {
            totalDifferencesLabel.Text = totalDifferences.ToString();
            if (currentDifference < totalDifferences)
            {
                setToWhite(currentDifference - 1);
                ++currentDifference;
                currentDifferenceTextBox.Text = currentDifference.ToString();
                highlightString(currentDifference - 1);
            }
            else
            {
                MessageBox.Show("Current difference cannot be greater than total number of differences.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void file1TextButton_Click(object sender, EventArgs e)
        {
            if(currentDifference - 1 < differences.Count())
            {
                differences.ElementAt(currentDifference - 1).setDifference1(true);
                highlightString(currentDifference - 1);
            }
        }

        private void file2TextButton_Click(object sender, EventArgs e)
        {
            if (currentDifference - 1 < differences.Count())
            {
                differences.ElementAt(currentDifference - 1).setDifference1(false);
                highlightString(currentDifference - 1);
            }
        }

        private void setToWhite(int index)
        {
            try
            {
                if (differences.ElementAt(currentDifference - 1) != null)
                {
                    richTextBox1.SelectionStart = (int)differences.ElementAt(index).getIndex1();
                    richTextBox1.SelectionLength = (int)differences.ElementAt(index).getSize1();
                    richTextBox1.SelectionBackColor = Color.White;
                    richTextBox2.SelectionStart = (int)differences.ElementAt(index).getIndex2();
                    richTextBox2.SelectionLength = (int)differences.ElementAt(index).getSize2();
                    richTextBox2.SelectionBackColor = Color.White;
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
        private void highlightString(int index)
        {
            try
            {
                if (differences.ElementAt(currentDifference - 1) != null)
                {
                    richTextBox1.SelectionStart = (int)differences.ElementAt(index).getIndex1();
                    richTextBox1.SelectionLength = (int)differences.ElementAt(index).getSize1();
                    richTextBox1.SelectionBackColor = differences.ElementAt(index).getDifference1() == true ? Color.DeepSkyBlue : Color.Gold;
                    richTextBox2.SelectionStart = (int)differences.ElementAt(index).getIndex2();
                    richTextBox2.SelectionLength = (int)differences.ElementAt(index).getSize2();
                    richTextBox2.SelectionBackColor = differences.ElementAt(index).getDifference1() == false ? Color.DeepSkyBlue : Color.Gold;
                    richTextBox1.ScrollToCaret();   // scrolls to highlighted text
                    richTextBox2.ScrollToCaret();   // scrolls to highlighted text
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
    }
}
