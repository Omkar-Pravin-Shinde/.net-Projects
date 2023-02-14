using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;


namespace TextToSpeechConverter
{
    public partial class loginusingfirebase : Form
    {
        public loginusingfirebase()
        {
            InitializeComponent();
        }


        public async void DataFromCloud()
        {
            Cursor.Current = Cursors.WaitCursor;
            var fb = new FirebaseClient(fbconfig.url);
            RegisterPojo obj = new RegisterPojo();

            obj.Username = textBox1.Text;
            obj.Password = textBox2.Text;
            var fbdata = await fb.Child("RegisterPojo").OnceAsync<RegisterPojo>();
            int id = 0;

            foreach(var data in fbdata)
            {
                RegisterPojo rg = new RegisterPojo();
                rg.Username = data.Object.Username;
                rg.Password = data.Object.Password;

                if(rg.Username == textBox1.Text && rg.Password == textBox2.Text)
                {
                    id = 1;
                   // MessageBox.Show("Login Done !");
                    Form1 fm1 = new Form1();
                    fm1.Show();
                    this.Hide();

                    return;
                }

            }
            if(id == 0) {
                MessageBox.Show("Invalid user");
            }

        }
        
            
            
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataFromCloud();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FireBaseConnection fbc1 = new FireBaseConnection();
            fbc1.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;

        }
    }
}
