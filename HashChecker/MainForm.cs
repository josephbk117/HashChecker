using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HashChecker
{
    public partial class MainForm : Form
    {
        string path1, path2, hash1, hash2, spath1, spath2;
        public MainForm()
        {           
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] buffer;
            int bytesRead = 0;
            long size;
            long totalBytesRead = 0;
            if (textBoxPath.Text != String.Empty)
            {
                int progress;
                using (Stream file = File.OpenRead(path1))
                {
                    size = file.Length;
                    using (HashAlgorithm hash = MD5.Create())
                    {
                        do
                        {
                            buffer = new byte[4096];
                            bytesRead = file.Read(buffer, 0, buffer.Length);
                            totalBytesRead += bytesRead;
                            hash.TransformBlock(buffer, 0, bytesRead, null, 0);
                            if(checkBoxUseFileOrHash.CheckState == CheckState.Unchecked)
                                progress = (int)(((double)totalBytesRead / size * 100)/2d);
                            else
                                progress = (int)((double)totalBytesRead / size * 100);
                            backgroundWorker1.ReportProgress(progress);
                        }
                        while (bytesRead != 0);
                        hash.TransformFinalBlock(buffer, 0, 0);                        
                        hash1 = makeHashString(hash.Hash);
                    }
                }
                if (checkBoxUseFileOrHash.CheckState == CheckState.Unchecked)
                {
                    int tempProgess = progress;
                    using (Stream file = File.OpenRead(path2))
                    {
                        size = file.Length;
                        using (HashAlgorithm hash = MD5.Create())
                        {
                            do
                            {
                                buffer = new byte[4096];
                                bytesRead = file.Read(buffer, 0, buffer.Length);
                                totalBytesRead += bytesRead;
                                hash.TransformBlock(buffer, 0, bytesRead, null, 0);
                                progress = (int)(((double)totalBytesRead / size * 100) / 2d);
                                backgroundWorker1.ReportProgress(tempProgess + progress);
                            }
                            while (bytesRead != 0);
                            hash.TransformFinalBlock(buffer, 0, 0);
                            hash2 = makeHashString(hash.Hash);
                        }
                    }
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int p = e.ProgressPercentage;
            if (p > 100)
                p = 100;
            progressBar1.Value = p;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            if (checkBoxUseFileOrHash.CheckState == CheckState.Unchecked)
            {                
                output_textBox.Text = "Hash of " + spath1 + " = " + hash1 + "\nHash of " +
                    spath2 + " = " + hash2;
                if (hash1 == hash2)                
                    MessageBox.Show("Both have same hash code");                
            }
            else
            {
                output_textBox.Text = "Hash of " + spath1 + " = " + hash1;
                if (hash1 == textBox1.Text)
                {
                    MessageBox.Show("Both hashes are the same");
                    output_textBox.Text += " is equal to " + textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Hashes are not the same");
                    output_textBox.Text += " is not equal to " + textBox1.Text;
                }
                
            }
        }

        private void HashButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void buttonOpen2ndFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                path2 = ofd.FileName;
                spath2 = ofd.SafeFileName;
            }
        }

        private static string makeHashString(byte[] hashBytes)
        {
            StringBuilder hash = new StringBuilder(32); //md5 has 32 chars
            foreach (byte b in hashBytes)
            {
                hash.Append(b.ToString("x2"));
            }
            return hash.ToString();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = ofd.FileName;
                path1 = ofd.FileName;
                spath1 = ofd.SafeFileName;
            }
        }

        private void checkBoxUseFileOrHash_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxUseFileOrHash.CheckState == CheckState.Checked)
            {
                buttonOpen2ndFile.Enabled = false;
                checkBoxUseFileOrHash.Text = "Use Hash";
            }
            else
            {
                buttonOpen2ndFile.Enabled = true;
                checkBoxUseFileOrHash.Text = "Use File";
            }
        }
    }
}
