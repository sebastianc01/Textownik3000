namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFile1 = new System.Windows.Forms.Button();
            this.openFile2Button = new System.Windows.Forms.Button();
            this.infoFile1 = new System.Windows.Forms.Label();
            this.infoFile2 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.compareButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFile1
            // 
            this.openFile1.Location = new System.Drawing.Point(137, 247);
            this.openFile1.Name = "openFile1";
            this.openFile1.Size = new System.Drawing.Size(149, 29);
            this.openFile1.TabIndex = 0;
            this.openFile1.Text = "Select first file";
            this.openFile1.UseVisualStyleBackColor = true;
            this.openFile1.Click += new System.EventHandler(this.openFile1Button_Click);
            // 
            // openFile2Button
            // 
            this.openFile2Button.Location = new System.Drawing.Point(523, 247);
            this.openFile2Button.Name = "openFile2Button";
            this.openFile2Button.Size = new System.Drawing.Size(149, 29);
            this.openFile2Button.TabIndex = 1;
            this.openFile2Button.Text = "Select second file";
            this.openFile2Button.UseVisualStyleBackColor = true;
            this.openFile2Button.Click += new System.EventHandler(this.openFile2Button_Click);
            // 
            // infoFile1
            // 
            this.infoFile1.AutoSize = true;
            this.infoFile1.CausesValidation = false;
            this.infoFile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(250)))));
            this.infoFile1.Location = new System.Drawing.Point(164, 299);
            this.infoFile1.Name = "infoFile1";
            this.infoFile1.Size = new System.Drawing.Size(113, 20);
            this.infoFile1.TabIndex = 2;
            this.infoFile1.Text = "No file selected";
            this.infoFile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoFile2
            // 
            this.infoFile2.AutoSize = true;
            this.infoFile2.CausesValidation = false;
            this.infoFile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(250)))));
            this.infoFile2.Location = new System.Drawing.Point(540, 299);
            this.infoFile2.Name = "infoFile2";
            this.infoFile2.Size = new System.Drawing.Size(113, 20);
            this.infoFile2.TabIndex = 3;
            this.infoFile2.Text = "No file selected";
            this.infoFile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(357, 342);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(94, 29);
            this.compareButton.TabIndex = 4;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(180, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 89);
            this.label1.TabIndex = 5;
            this.label1.Text = "Textownik3000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.infoFile2);
            this.Controls.Add(this.infoFile1);
            this.Controls.Add(this.openFile2Button);
            this.Controls.Add(this.openFile1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button openFile1;
        private Button openFile2Button;
        private Label infoFile1;
        private Label infoFile2;
        private OpenFileDialog openFileDialog2;
        private Button compareButton;
        private Label label1;
    }
}