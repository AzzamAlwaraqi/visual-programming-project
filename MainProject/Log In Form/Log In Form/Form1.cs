using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Student_Interface;
using Admin_Interface;

namespace Log_In_Form
{
    public partial class Form1 : Form
    {
        StreamReader StudentCourses;
        int count;
        public Form1()
        {
            InitializeComponent();
            InitializeAdditionalComponents();
        }
        
        private void InitializeAdditionalComponents()
        {
            // Handle the KeyUp event for the password TextBox
            this.passwordtextBox.KeyUp += new KeyEventHandler(this.passwordtextBox_KeyUp);

            // Check the initial state of Caps Lock
            UpdateCapsLockIndicator();
        }

        private void passwordtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateCapsLockIndicator();
        }

        private void UpdateCapsLockIndicator()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                capIndicatorlabel.Text = "Caps Lock is ON";
                capIndicatorlabel.ForeColor = Color.White;
                capIndicatorlabel.BackColor = Color.Red;

            }
            else
            {
                capIndicatorlabel.Text = "";            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
   

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPasswordLBL_Click(object sender, EventArgs e)
        {
            ShowPasswordLBL.Text = passwordtextBox.Text;
        }
        private void HidePasswordLBL_Click(object sender, EventArgs e)
        {
            ShowPasswordLBL.Text = "";

        }

        private bool ValidateCredentials(string username, string password)
        {
            string[] lines = File.ReadAllLines("credentials.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string storedUsername = parts[0];
                    string storedPassword = parts[1];
                    if (storedUsername.Equals(username, StringComparison.OrdinalIgnoreCase) && storedPassword == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void logInBTN_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = passwordtextBox.Text;
           

            if (ValidateCredentials(username, password))
            {
               

                if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    FormAdmin adminForm = new FormAdmin();
                    adminForm.ShowDialog ();
                    
                    
                }
                else
                {
                    StreamWriter Curent_User = File.CreateText("Current_Student.txt");
                    Curent_User.WriteLine(username);
                    Curent_User.Close();

                    try 
                    {
                       
                        StudentCourses = File.OpenText($"{username}_courses.txt");
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.ShowDialog();
                        this.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("the student didnt choose his  courses , please choose");
                    }
                    FormStuden studentForm = new FormStuden();
                    studentForm.ShowDialog();
                    
                    StudentCourses.Close();
                }
               
                this.Close(); 
                

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                UsernameTextBox.Text = "";
                passwordtextBox.Text = "";
                UsernameTextBox.Focus();
                count++;
            }
        if(count==3)
            {
                MessageBox.Show("warning: you have another try if  the enterd data is inavalid you will be locked out");
            }
        if (count==4)
            {
                this.Close();
            }
    }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignin SignIn=new FormSignin();
            SignIn.ShowDialog();
            this.Close();
            
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
