namespace HashChecker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.HashButton = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.checkBoxUseFileOrHash = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOpen2ndFile = new System.Windows.Forms.Button();
            this.output_textBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(601, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // textBoxPath
            // 
            this.textBoxPath.AllowDrop = true;
            this.textBoxPath.Location = new System.Drawing.Point(13, 13);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(458, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // HashButton
            // 
            this.HashButton.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.HashButton.Location = new System.Drawing.Point(350, 43);
            this.HashButton.Name = "HashButton";
            this.HashButton.Size = new System.Drawing.Size(121, 28);
            this.HashButton.TabIndex = 2;
            this.HashButton.Text = "COMPARE HASH";
            this.HashButton.UseVisualStyleBackColor = true;
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOpen.Location = new System.Drawing.Point(477, 8);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(121, 28);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "OPEN";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // checkBoxUseFileOrHash
            // 
            this.checkBoxUseFileOrHash.AutoSize = true;
            this.checkBoxUseFileOrHash.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseFileOrHash.Location = new System.Drawing.Point(477, 42);
            this.checkBoxUseFileOrHash.Name = "checkBoxUseFileOrHash";
            this.checkBoxUseFileOrHash.Size = new System.Drawing.Size(90, 28);
            this.checkBoxUseFileOrHash.TabIndex = 4;
            this.checkBoxUseFileOrHash.Text = "Use File";
            this.checkBoxUseFileOrHash.UseVisualStyleBackColor = true;
            this.checkBoxUseFileOrHash.CheckStateChanged += new System.EventHandler(this.checkBoxUseFileOrHash_CheckStateChanged);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(13, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonOpen2ndFile
            // 
            this.buttonOpen2ndFile.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen2ndFile.Location = new System.Drawing.Point(477, 78);
            this.buttonOpen2ndFile.Name = "buttonOpen2ndFile";
            this.buttonOpen2ndFile.Size = new System.Drawing.Size(121, 28);
            this.buttonOpen2ndFile.TabIndex = 6;
            this.buttonOpen2ndFile.Text = "OPEN";
            this.buttonOpen2ndFile.UseVisualStyleBackColor = true;
            this.buttonOpen2ndFile.Click += new System.EventHandler(this.buttonOpen2ndFile_Click);
            // 
            // output_textBox
            // 
            this.output_textBox.Location = new System.Drawing.Point(13, 110);
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.Size = new System.Drawing.Size(585, 71);
            this.output_textBox.TabIndex = 7;
            this.output_textBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 211);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.buttonOpen2ndFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxUseFileOrHash);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.HashButton);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Hash Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button HashButton;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.CheckBox checkBoxUseFileOrHash;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOpen2ndFile;
        private System.Windows.Forms.RichTextBox output_textBox;
    }
}

