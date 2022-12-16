namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string pathFile1 = string.Empty;
        string pathFile2 = string.Empty;
        string extension = ".txt"; //temporarily assigned here
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            //if(openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    pathFile1 = openFileDialog1.FileName;

            //}
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
        }

        private void openFile1Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathFile1 = openFileDialog1.FileName;
                //if (Path.GetExtension(pathFile1) != extension)
                //{
                //    pathFile1 = String.Empty;

                //}
                infoFile1.Text = File.Exists(pathFile1) ? Path.GetFileName(pathFile1) : "Incorrect file";
            }
        }

        private void openFile2Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pathFile2 = openFileDialog2.FileName;
                if (Path.GetExtension(pathFile2) != extension)
                {
                    pathFile2 = String.Empty;
                }
                infoFile2.Text = File.Exists(pathFile2) ? Path.GetFileName(pathFile2) : "Incorrect file";
            }        
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            openFileDialog2.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog2.Filter = "txt files (*.txt)|*.txt";
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathFile1) && File.Exists(pathFile2) && Path.GetExtension(pathFile1) == extension && Path.GetExtension(pathFile2) == extension)
            {
                this.Hide();
                Form2 comp = new Form2(pathFile1, pathFile2);
                comp.ShowDialog();
                this.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("The selected files are invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}