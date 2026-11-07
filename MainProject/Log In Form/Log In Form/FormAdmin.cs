using System.IO;
using Log_In_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Admin_Interface
{

    public partial class FormAdmin : Form
    {
        string LectureType;
        List<ScheduleEntry> scheduleEntries = new List<ScheduleEntry>();
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            textBoxCourseName.Clear();
            textBoxCourseTeacher.Clear();
            textBoxStartingTime.Clear();
            textBoxFinishTime.Clear();
            radioButtonFaceToFace.Checked = false;
            radioButtonOnline.Checked = false;
            radioButtonBlended.Checked = false;
            checkBoxSunday.Checked = false;
            checkBoxMonday.Checked = false;
            checkBoxTuesday.Checked = false;
            checkBoxWednesday.Checked = false;
            checkBoxThursday.Checked = false;
            checkBoxSaturday.Checked = false;
            checkBoxSaturday.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCourseName.Text) ||
                string.IsNullOrWhiteSpace(textBoxCourseTeacher.Text) ||
                string.IsNullOrWhiteSpace(textBoxStartingTime.Text) ||
                string.IsNullOrWhiteSpace(textBoxFinishTime.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radioButtonFaceToFace.Checked)
            {
                LectureType = radioButtonFaceToFace.Text;
            }
            else if (radioButtonOnline.Checked)
            {
                LectureType = radioButtonOnline.Text;
            }
            else if (radioButtonBlended.Checked)
            {
                LectureType = radioButtonBlended.Text;
            }
            else
            {
                MessageBox.Show("Please select a lecture type/days.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            List<string> days = new List<string>();
            if (checkBoxSunday.Checked) days.Add(checkBoxSunday.Text);
            if (checkBoxMonday.Checked) days.Add(checkBoxMonday.Text);
            if (checkBoxTuesday.Checked) days.Add(checkBoxTuesday.Text);
            if (checkBoxWednesday.Checked) days.Add(checkBoxWednesday.Text);
            if (checkBoxThursday.Checked) days.Add(checkBoxThursday.Text);
            if (checkBoxSaturday.Checked) days.Add(checkBoxSaturday.Text);
            if (checkBoxSaturday.Checked) days.Add(checkBoxSaturday.Text);



            if (!double.TryParse(textBoxStartingTime.Text, out double startTime) ||
                !double.TryParse(textBoxFinishTime.Text, out double finishTime))
            {
                MessageBox.Show("Please enter valid start and finish times.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ScheduleEntry newEntry = new ScheduleEntry
            {
                CourseName = textBoxCourseName.Text,
                CourseTeacher = textBoxCourseTeacher.Text,
                LectureType = LectureType,
                StartTime = startTime,
                FinishTime = finishTime,
                Days = days
            };

            foreach (var entry in scheduleEntries)
            {
                if (entry.CourseTeacher == newEntry.CourseTeacher && entry.Days.Intersect(newEntry.Days).Any())
                {
                    if ((newEntry.StartTime < entry.FinishTime && newEntry.StartTime >= entry.StartTime) ||
                        (newEntry.FinishTime > entry.StartTime && newEntry.FinishTime <= entry.FinishTime) ||
                        (newEntry.StartTime <= entry.StartTime && newEntry.FinishTime >= entry.FinishTime))
                    {
                        MessageBox.Show("Conflict detected: " + newEntry.CourseTeacher + " is already scheduled to teach another course at the same time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            scheduleEntries.Add(newEntry);
            listBox1.Items.Add($"{newEntry.CourseName} by {newEntry.CourseTeacher} ({newEntry.LectureType}) from {newEntry.StartTime} to {newEntry.FinishTime} on {string.Join(", ", newEntry.Days)}");

            ClearForm();

        }
        //this delet a selected item from the listbox
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
               
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }
        //this save the courses to a txtfile name courses.txt
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Courses.txt"))
            {
                foreach (var item in listBox1.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Courses saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
// this close this page and return the project to login form
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            StreamReader courses;
            try
            {
                courses = File.OpenText("Courses.txt");
                while (!courses.EndOfStream)
                {
                    listBox1.Items.Add(courses.ReadLine());
                }
                courses.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(" no Courses has been submited by the admin before  ");
            }

            
        }
    }
}