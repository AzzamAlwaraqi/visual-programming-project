using System.Windows.Forms;
using System.Drawing;
namespace Admin_Interface
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.buttonAddSchedule = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.radioButtonFaceToFace = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonOnline = new System.Windows.Forms.RadioButton();
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.radioButtonBlended = new System.Windows.Forms.RadioButton();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCourseTeacher = new System.Windows.Forms.TextBox();
            this.textBoxStartingTime = new System.Windows.Forms.TextBox();
            this.textBoxFinishTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddSchedule
            // 
            this.buttonAddSchedule.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddSchedule.Location = new System.Drawing.Point(386, 378);
            this.buttonAddSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSchedule.Name = "buttonAddSchedule";
            this.buttonAddSchedule.Size = new System.Drawing.Size(121, 23);
            this.buttonAddSchedule.TabIndex = 0;
            this.buttonAddSchedule.Text = "&Add schedule";
            this.buttonAddSchedule.UseVisualStyleBackColor = false;
            this.buttonAddSchedule.Click += new System.EventHandler(this.buttonAddSchedule_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(550, 378);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(704, 378);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Firebrick;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(962, 378);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(374, 82);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(682, 276);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.BackColor = System.Drawing.Color.White;
            this.checkBoxSunday.Location = new System.Drawing.Point(20, 266);
            this.checkBoxSunday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(75, 20);
            this.checkBoxSunday.TabIndex = 5;
            this.checkBoxSunday.Text = "Sunday";
            this.checkBoxSunday.UseVisualStyleBackColor = false;
            // 
            // radioButtonFaceToFace
            // 
            this.radioButtonFaceToFace.AutoSize = true;
            this.radioButtonFaceToFace.Location = new System.Drawing.Point(20, 198);
            this.radioButtonFaceToFace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFaceToFace.Name = "radioButtonFaceToFace";
            this.radioButtonFaceToFace.Size = new System.Drawing.Size(95, 20);
            this.radioButtonFaceToFace.TabIndex = 6;
            this.radioButtonFaceToFace.TabStop = true;
            this.radioButtonFaceToFace.Text = "OnCampus";
            this.radioButtonFaceToFace.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(457, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Courses Schedule App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Course Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Teacher : ";
            // 
            // radioButtonOnline
            // 
            this.radioButtonOnline.AutoSize = true;
            this.radioButtonOnline.Location = new System.Drawing.Point(127, 198);
            this.radioButtonOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonOnline.Name = "radioButtonOnline";
            this.radioButtonOnline.Size = new System.Drawing.Size(66, 20);
            this.radioButtonOnline.TabIndex = 13;
            this.radioButtonOnline.TabStop = true;
            this.radioButtonOnline.Text = "Online";
            this.radioButtonOnline.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonday
            // 
            this.checkBoxMonday.AutoSize = true;
            this.checkBoxMonday.Location = new System.Drawing.Point(127, 266);
            this.checkBoxMonday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMonday.Name = "checkBoxMonday";
            this.checkBoxMonday.Size = new System.Drawing.Size(78, 20);
            this.checkBoxMonday.TabIndex = 14;
            this.checkBoxMonday.Text = "Monday";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.Location = new System.Drawing.Point(234, 266);
            this.checkBoxTuesday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(83, 20);
            this.checkBoxTuesday.TabIndex = 15;
            this.checkBoxTuesday.Text = "Tuesday";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlended
            // 
            this.radioButtonBlended.AutoSize = true;
            this.radioButtonBlended.Location = new System.Drawing.Point(234, 198);
            this.radioButtonBlended.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBlended.Name = "radioButtonBlended";
            this.radioButtonBlended.Size = new System.Drawing.Size(78, 20);
            this.radioButtonBlended.TabIndex = 16;
            this.radioButtonBlended.TabStop = true;
            this.radioButtonBlended.Text = "blended";
            this.radioButtonBlended.UseVisualStyleBackColor = true;
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.Location = new System.Drawing.Point(20, 299);
            this.checkBoxWednesday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(103, 20);
            this.checkBoxWednesday.TabIndex = 17;
            this.checkBoxWednesday.Text = "Wednesday";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.Location = new System.Drawing.Point(127, 299);
            this.checkBoxThursday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(86, 20);
            this.checkBoxThursday.TabIndex = 18;
            this.checkBoxThursday.Text = "Thursday";
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Location = new System.Drawing.Point(234, 299);
            this.checkBoxSaturday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(83, 20);
            this.checkBoxSaturday.TabIndex = 19;
            this.checkBoxSaturday.Text = "Saturday";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Start : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lecture Type : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Days : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 60);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(20, 132);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(125, 22);
            this.textBoxCourseName.TabIndex = 24;
            // 
            // textBoxCourseTeacher
            // 
            this.textBoxCourseTeacher.Location = new System.Drawing.Point(192, 132);
            this.textBoxCourseTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCourseTeacher.Name = "textBoxCourseTeacher";
            this.textBoxCourseTeacher.Size = new System.Drawing.Size(125, 22);
            this.textBoxCourseTeacher.TabIndex = 25;
            // 
            // textBoxStartingTime
            // 
            this.textBoxStartingTime.Location = new System.Drawing.Point(20, 367);
            this.textBoxStartingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStartingTime.Name = "textBoxStartingTime";
            this.textBoxStartingTime.Size = new System.Drawing.Size(125, 22);
            this.textBoxStartingTime.TabIndex = 26;
            // 
            // textBoxFinishTime
            // 
            this.textBoxFinishTime.Location = new System.Drawing.Point(192, 367);
            this.textBoxFinishTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFinishTime.Name = "textBoxFinishTime";
            this.textBoxFinishTime.Size = new System.Drawing.Size(125, 22);
            this.textBoxFinishTime.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Finish : ";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Firebrick;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReturn.Location = new System.Drawing.Point(849, 378);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(93, 23);
            this.buttonReturn.TabIndex = 103;
            this.buttonReturn.Text = "&Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1068, 410);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFinishTime);
            this.Controls.Add(this.textBoxStartingTime);
            this.Controls.Add(this.textBoxCourseTeacher);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxSaturday);
            this.Controls.Add(this.checkBoxThursday);
            this.Controls.Add(this.checkBoxWednesday);
            this.Controls.Add(this.radioButtonBlended);
            this.Controls.Add(this.checkBoxTuesday);
            this.Controls.Add(this.checkBoxMonday);
            this.Controls.Add(this.radioButtonOnline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonFaceToFace);
            this.Controls.Add(this.checkBoxSunday);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddSchedule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddSchedule;
        private Button buttonDelete;
        private Button buttonSave;
        private Button buttonExit;
        private ListBox listBox1;
        private CheckBox checkBoxSunday;
        private RadioButton radioButtonFaceToFace;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButtonOnline;
        private CheckBox checkBoxMonday;
        private CheckBox checkBoxTuesday;
        private RadioButton radioButtonBlended;
        private CheckBox checkBoxWednesday;
        private CheckBox checkBoxThursday;
        private CheckBox checkBoxSaturday;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox textBoxCourseName;
        private TextBox textBoxCourseTeacher;
        private TextBox textBoxStartingTime;
        private TextBox textBoxFinishTime;
        private Label label7;
        private Button buttonReturn;
    }
}