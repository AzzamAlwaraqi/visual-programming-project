using Student_Interface;
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

namespace Log_In_Form
{
    public partial class Dashboard : Form
    {
        String Current_Student;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStuden student = new FormStuden();
            student.ShowDialog();
            this.Close();
            
           
           
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            // this code Block to show the student information

            //by reading the name from the txt file current student 
            StreamReader Current_User;
            Current_User = File.OpenText("Current_Student.txt");
            Current_Student = Current_User.ReadLine();
            StreamReader Student_info;
            try
            {
                //and reading the txt file that has the student info and has the same name as the student
                Student_info = File.OpenText($"{Current_Student}.txt");
                labelName.Text = Student_info.ReadLine();
                labelID.Text = Student_info.ReadLine();
                labelMajor.Text = Student_info.ReadLine();
            }
            catch (Exception)
            {
                // exception handling method
                MessageBox.Show("error : failed to upload file");
            }
            try
            {
                StreamReader StudentCourses;
                StudentCourses = File.OpenText($"{Current_Student}_courses.txt");
                while (!StudentCourses.EndOfStream)
                {
                    listBox1.Items.Add(StudentCourses.ReadLine());
                }
                StudentCourses.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("unable to load file or the student didnt choose courses");
            }
        }

    }
    }

