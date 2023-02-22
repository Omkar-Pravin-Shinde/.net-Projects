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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginusingfirebase logfire = new loginusingfirebase();
            logfire.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Notpad npa = new Notpad();
            npa.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Compiler comp = new Compiler();
            comp.Show();
            this.Hide();
        }
    }
}
