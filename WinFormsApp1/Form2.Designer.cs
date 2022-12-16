namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalDifferencesLabel = new System.Windows.Forms.Label();
            this.currentDifferenceTextBox = new System.Windows.Forms.TextBox();
            this.previousDifferenceButton = new System.Windows.Forms.Button();
            this.nextDifferenceButton = new System.Windows.Forms.Button();
            this.file1TextButton = new System.Windows.Forms.Button();
            this.file2TextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(84, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(298, 404);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(388, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(290, 404);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select files again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // totalDifferencesLabel
            // 
            this.totalDifferencesLabel.AutoSize = true;
            this.totalDifferencesLabel.Location = new System.Drawing.Point(771, 121);
            this.totalDifferencesLabel.Name = "totalDifferencesLabel";
            this.totalDifferencesLabel.Size = new System.Drawing.Size(17, 20);
            this.totalDifferencesLabel.TabIndex = 4;
            this.totalDifferencesLabel.Text = "1";
            // 
            // currentDifferenceTextBox
            // 
            this.currentDifferenceTextBox.Location = new System.Drawing.Point(684, 118);
            this.currentDifferenceTextBox.Name = "currentDifferenceTextBox";
            this.currentDifferenceTextBox.Size = new System.Drawing.Size(49, 27);
            this.currentDifferenceTextBox.TabIndex = 5;
            this.currentDifferenceTextBox.Text = "1";
            // 
            // previousDifferenceButton
            // 
            this.previousDifferenceButton.Location = new System.Drawing.Point(711, 75);
            this.previousDifferenceButton.Name = "previousDifferenceButton";
            this.previousDifferenceButton.Size = new System.Drawing.Size(60, 29);
            this.previousDifferenceButton.TabIndex = 6;
            this.previousDifferenceButton.Text = "-";
            this.previousDifferenceButton.UseVisualStyleBackColor = true;
            this.previousDifferenceButton.Click += new System.EventHandler(this.previousDifferenceButton_Click);
            // 
            // nextDifferenceButton
            // 
            this.nextDifferenceButton.Location = new System.Drawing.Point(711, 161);
            this.nextDifferenceButton.Name = "nextDifferenceButton";
            this.nextDifferenceButton.Size = new System.Drawing.Size(60, 29);
            this.nextDifferenceButton.TabIndex = 7;
            this.nextDifferenceButton.Text = "+";
            this.nextDifferenceButton.UseVisualStyleBackColor = true;
            this.nextDifferenceButton.Click += new System.EventHandler(this.nextDifferenceButton_Click);
            // 
            // file1TextButton
            // 
            this.file1TextButton.Location = new System.Drawing.Point(138, 422);
            this.file1TextButton.Name = "file1TextButton";
            this.file1TextButton.Size = new System.Drawing.Size(178, 29);
            this.file1TextButton.TabIndex = 8;
            this.file1TextButton.Text = "Select text from file 1";
            this.file1TextButton.UseVisualStyleBackColor = true;
            this.file1TextButton.Click += new System.EventHandler(this.file1TextButton_Click);
            // 
            // file2TextButton
            // 
            this.file2TextButton.Location = new System.Drawing.Point(447, 422);
            this.file2TextButton.Name = "file2TextButton";
            this.file2TextButton.Size = new System.Drawing.Size(176, 29);
            this.file2TextButton.TabIndex = 9;
            this.file2TextButton.Text = "Select text from file 2";
            this.file2TextButton.UseVisualStyleBackColor = true;
            this.file2TextButton.Click += new System.EventHandler(this.file2TextButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.file2TextButton);
            this.Controls.Add(this.file1TextButton);
            this.Controls.Add(this.nextDifferenceButton);
            this.Controls.Add(this.previousDifferenceButton);
            this.Controls.Add(this.currentDifferenceTextBox);
            this.Controls.Add(this.totalDifferencesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private Label label1;
        private Label totalDifferencesLabel;
        private TextBox currentDifferenceTextBox;
        private Button previousDifferenceButton;
        private Button nextDifferenceButton;
        private Button file1TextButton;
        private Button file2TextButton;
    }
}