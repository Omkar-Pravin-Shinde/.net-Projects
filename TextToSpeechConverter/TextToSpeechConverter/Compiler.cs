using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextToSpeechConverter
{
    public partial class Compiler : Form
    {
        public Compiler()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "py|*.py";
            DialogResult dr = op.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string path = op.FileName;
                StreamReader sr = new StreamReader(path);
                string data = sr.ReadToEnd();
                richTextBox1.Text = data;
                sr.Close();

                textBox1.Text = Path.GetFileName(path);
                textBox2.Text = path;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\hp\Documents\Python\one.py";
            File.WriteAllText(path, richTextBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // string pythonPath = @"C:\Users\sahil\AppData\Local\Programs\Python\Python311\python.exe"; // Path to the Python interpreter
            string pythonPath = @"C:\Users\hp\AppData\Local\Programs\Python\Python39\python.exe";
            //  string scriptPath = @"C:\Users\sahil\Documents\Python\smg.py"; // Path to the Python script to run
            string scriptPath = @"C:\Users\hp\Documents\Python\one.py"; // Path to the Python script to run

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pythonPath;
            start.Arguments = scriptPath;

            // Redirect the output of the Python script to the C# console
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {



                string output = process.StandardOutput.ReadToEnd();
                richTextBox2.Text = output;

                if (output != "")
                {
                    richTextBox2.Text = output;

                }
                else
                {
                    MessageBox.Show("Invalid ");

                }


            }
        }


        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fnt.Font;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Navigation fm1 = new Navigation();
            fm1.Show();
            this.Hide();
        }
    }
    }

