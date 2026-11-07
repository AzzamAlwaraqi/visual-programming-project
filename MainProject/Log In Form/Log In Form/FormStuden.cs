using Log_In_Form;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Student_Interface
{

    public partial class FormStuden : Form
    {
        String Current_Student;
        private List<Course> courses = new List<Course>();
        public FormStuden()
        {
            InitializeComponent();
            LoadCourses();
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            buttonSave.Click += buttonSave_Click;



        }
        // a function to laoad courses from courses.txt and add it to the checked list box
        private void LoadCourses()
        {
            try
            {
                var lines = File.ReadAllLines("Courses.txt");
                foreach (var line in lines)
                {
                    Course course = ParseCourse(line);
                    if (course != null)
                    {
                        courses.Add(course);
                        checkedListBox1.Items.Add(course.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
        /* this function take the course format in courses.txt and
        check it and get the days hours teacher and name from it */
        private Course ParseCourse(string line)
        {
            try
            {
                
                // Ensure the line format is consistent with the expected format
                var parts = line.Split(new[] { " by ", " (", ") from ", " to ", " on " }, StringSplitOptions.None);

                if (parts.Length != 6)
                {
                    throw new FormatException("Line does not match the expected format");
                }

                string courseName = parts[0];
                string teacher = parts[1];
                string lectureType = parts[2];
                double startTime = double.Parse(parts[3]);
                double finishTime = double.Parse(parts[4]);
                var days = parts[5].Split(new[] { ", " }, StringSplitOptions.None).ToList();

                return new Course
                {
                    CourseName = courseName,
                    CourseTeacher = teacher,
                    LectureType = lectureType,
                    StartTime = startTime,
                    FinishTime = finishTime,
                    Days = days
                };
            }
            catch (Exception ex)
            {
                // Log the error or handle it as needed
                MessageBox.Show($"Error parsing line: {line}\n{ex.Message}");
                return null;
            }
        }
  /* this a checked list box it check if the courses that the student  try to choose are over lapping 
   and prevent him from doing so and notify him*/
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                var selectedCourse = courses[e.Index];
                foreach (int index in checkedListBox1.CheckedIndices)
                {
                    var checkedCourse = courses[index];
                    if (CoursesOverlap(selectedCourse, checkedCourse))
                    {
                        MessageBox.Show("You have selected overlapping courses. Please choose a different course.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.NewValue = CheckState.Unchecked;
                        return;
                    }
                }
            }
        }

        private bool CoursesOverlap(Course course1, Course course2)
        {
            foreach (var day in course1.Days)
            {
                if (course2.Days.Contains(day))
                {
                    if ((course1.StartTime < course2.FinishTime && course1.StartTime >= course2.StartTime) ||
                        (course1.FinishTime > course2.StartTime && course1.FinishTime <= course2.FinishTime) ||
                        (course1.StartTime <= course2.StartTime && course1.FinishTime >= course2.FinishTime))
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // a button to save the student choice in a txt file called (student name)_couses.txt
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one course.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Current_Student))
            {
                MessageBox.Show("Please enter the student's name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentName = Current_Student.Trim();
            string filePath = $"{studentName}_courses.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath)) // Using 'true' for append mode
                {
                    foreach (int index in checkedListBox1.CheckedIndices)
                    {
                        writer.WriteLine(courses[index].ToString());
                    }
                }
                MessageBox.Show("Courses selected successfully and saved to file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }

        }

        private void FormStuden_Load(object sender, EventArgs e)
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
                labelStudentName.Text = Student_info.ReadLine();
                labelStudentID.Text = Student_info.ReadLine();
                labelMajor.Text = Student_info.ReadLine();
            }
            catch (Exception)
            {
                // exception handling method
                MessageBox.Show("error : failed to upload file");
            }
        }
        // this close the project completely
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // this allow this page to close and return to the main page which is login form
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
           login.ShowDialog();
            this.Close();
        }

        
    }
    // a class named  course to get the courses from courses.txt
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public string LectureType { get; set; }
        public double StartTime { get; set; }
        public double FinishTime { get; set; }
        public List<string> Days { get; set; }

        public override string ToString()
        {
            return $"{CourseName} by {CourseTeacher} ({LectureType}) from {StartTime} to {FinishTime} on {string.Join(", ", Days)}";
        }
    }
}
