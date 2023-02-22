using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextToSpeechConverter
{
    public partial class Notpad : Form
    {
        public Notpad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog omkar = new OpenFileDialog();
            omkar.Title = "Open";
            omkar.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";
            if (omkar.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(omkar.FileName, RichTextBoxStreamType.PlainText);
            this.Text = omkar.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog omkar = new SaveFileDialog();
            omkar.Title = "Save";
            omkar.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";
            if (omkar.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(omkar.FileName, RichTextBoxStreamType.PlainText);
            this.Text = omkar.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Navigation fm1 = new Navigation();
            fm1.Show();
            this.Hide();

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();

        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += System.DateTime.Now.ToString();

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fnt.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fnt.Color;
            }
        }
    }
}
