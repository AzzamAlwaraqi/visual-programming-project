using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Log_In_Form
{
    public partial class FormSignin : Form
    {
        String Password;
        public FormSignin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text =="" || textBoxMajor.Text == "" || Password_Box.Text == "" || textBoxID.Text == "")
            {
                MessageBox.Show("Please fill all the requirments ");
            }
            else
            {
                try
                {
                    string[] lines = File.ReadAllLines("credentials.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(':');
                        if (parts.Length == 2)
                        {
                            string storedUsername = parts[0];
                            string storedPassword = parts[1];
                            if (UserName.Text == storedUsername)
                            {
                                MessageBox.Show("UserName already used please choose another Name");
                                UserName.Text = "";
                                UserName.Focus();
                            }

                        }
                    }
                }
                catch 
                {
                    MessageBox.Show("Error has happened");
                }
                Password = Password_Box.Text;
                Password_Box.Text = "";
                Password_Box.Focus();
                label1.Text = "please confirm your password";
                buttonConfirm.Visible = true;
            }
           
        }
        /*this confirm your password and after confirmation it save the user name and password 
       to credintals txtfile and the other information into a txt file nammed (student name) .txt  */
        private void button2_Click(object sender, EventArgs e)
        {
            if (Password == Password_Box.Text)
            {
                StreamWriter SignIn;
                SignIn = File.AppendText($"{UserName.Text}.txt");
                SignIn.WriteLine(UserName.Text);
                SignIn.WriteLine(textBoxMajor.Text);
                SignIn.WriteLine(textBoxID.Text);
                SignIn.Close();
                SignIn = File.AppendText("credentials.txt");
                SignIn.WriteLine(UserName.Text+":"+Password_Box.Text);
                SignIn.Close() ;
                this.Hide();
                Form1 login = new Form1();
                login.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error: incorrect Password");
                    }
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormSignin_Load(object sender, EventArgs e)
        {

        }

        private void LogopictureBox_Click(object sender, EventArgs e)
        {

        }
        // close the project completely
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }
// this return to login page and close this page
        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login= new Form1();
            login.ShowDialog();
            this.Close();
        }
    }
}
