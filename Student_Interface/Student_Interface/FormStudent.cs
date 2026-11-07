using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Student_Interface
{

    public partial class FormStudent : Form
    {
        String Current_Student;
        private List<Course> courses = new List<Course>();
        public FormStudent()
        {
            InitializeComponent();
            LoadCourses();
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            buttonSave.Click += button1_Click;



        }

        private void LoadCourses()
        {
            try
            {
                var lines = File.ReadAllLines("courses.txt");
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
                int startTime = int.Parse(parts[3]);
                int finishTime = int.Parse(parts[4]);
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

        private void button1_Click(object sender, EventArgs e)
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
            string filePath = $@"C:\Users\LOQ\Downloads\Uni stuff\Visual_Programming_Project\Student_Information\{studentName}_courses.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true)) // Using 'true' for append mode
                {
                    foreach (int index in checkedListBox1.CheckedIndices)
                    {
                        writer.WriteLine(courses[index].ToString());
                    }
                }
                MessageBox.Show("Courses selected successfully and saved to file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader Current_User;
            Current_User = File.OpenText(@"C:\Users\LOQ\Downloads\Uni stuff\Visual_Programming_Project\Student_Information\Current_Student.txt");
            Current_Student = Current_User.ReadLine();
            StreamReader Student_info;
            try
            {

                Student_info = File.OpenText($@"C:\Users\LOQ\Downloads\Uni stuff\Visual_Programming_Project\Student_Information\{Current_Student}.txt");
                labelStudentName.Text = Student_info.ReadLine();
                labelStudentID.Text = Student_info.ReadLine();
                labelMajor.Text = Student_info.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("error : failed to upload file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public string LectureType { get; set; }
        public int StartTime { get; set; }
        public int FinishTime { get; set; }
        public List<string> Days { get; set; }

        public override string ToString()
        {
            return $"{CourseName} by {CourseTeacher} ({LectureType}) from {StartTime} to {FinishTime} on {string.Join(", ", Days)}";
        }
    }
}
