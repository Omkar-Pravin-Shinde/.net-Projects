using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Firebase.Database;
using Firebase.Database.Query;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TextToSpeechConverter
{
    public partial class FireBaseConnection : Form
    {
        public FireBaseConnection()
        {
            InitializeComponent();
        }

        public async void Reg_Pojo()
        {
            Cursor.Current = Cursors.WaitCursor;
            FirebaseClient fbc = new FirebaseClient(fbconfig.url);

            RegisterPojo obj = new RegisterPojo();
            obj.Username = textBox1.Text;
            obj.Email = textBox2.Text;
            obj.Contact = textBox3.Text;
            obj.Password = textBox4.Text;

            try
            {
                await fbc.Child("Reg_Pojo").PostAsync(obj);
                MessageBox.Show("Registration done !");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            catch (Exception ex){ MessageBox.Show("Error: " + ex); }
            Cursor.Current = Cursors.Default;
        }
        private void FireBaseConnection_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex EmailVerification = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (textBox2.Text.Trim() != string.Empty)
            {
                if (!EmailVerification.IsMatch(textBox2.Text.Trim()))
                {
                    MessageBox.Show("Email is not valid ");
                    textBox2.Focus();
                    return;
                }
            }
            

            if (textBox3.Text.Length == 10)
            {
               
            }
            else
            {
                MessageBox.Show("Enter Correct Mobile Number");
                return;
            }
            if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("confirm password not matching with passsword");
                textBox4.Focus();
                return;
            }
            
                Reg_Pojo();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allowed");
            }
        }
    }
}
