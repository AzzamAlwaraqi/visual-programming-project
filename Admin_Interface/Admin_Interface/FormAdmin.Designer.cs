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
            buttonAddSchedule = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            buttonExit = new Button();
            listBox1 = new ListBox();
            checkBoxSunday = new CheckBox();
            radioButtonFaceToFace = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButtonOnline = new RadioButton();
            checkBoxMonday = new CheckBox();
            checkBoxTuesday = new CheckBox();
            radioButtonBlended = new RadioButton();
            checkBoxWednesday = new CheckBox();
            checkBoxThursday = new CheckBox();
            checkBoxSaturday = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            textBoxCourseName = new TextBox();
            textBoxCourseTeacher = new TextBox();
            textBoxStartingTime = new TextBox();
            textBoxFinishTime = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAddSchedule
            // 
            buttonAddSchedule.BackColor = Color.Firebrick;
            buttonAddSchedule.FlatStyle = FlatStyle.Popup;
            buttonAddSchedule.ForeColor = SystemColors.ControlLightLight;
            buttonAddSchedule.Location = new Point(386, 472);
            buttonAddSchedule.Name = "buttonAddSchedule";
            buttonAddSchedule.Size = new Size(121, 29);
            buttonAddSchedule.TabIndex = 0;
            buttonAddSchedule.Text = "&Add schedule";
            buttonAddSchedule.UseVisualStyleBackColor = false;
            buttonAddSchedule.Click += button1_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Firebrick;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(565, 472);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(119, 29);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "&Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += button2_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Firebrick;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(760, 472);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(119, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "&Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += button3_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Firebrick;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.ForeColor = SystemColors.ControlLightLight;
            buttonExit.Location = new Point(934, 472);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "&Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.HighlightText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(374, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(682, 344);
            listBox1.TabIndex = 4;
            // 
            // checkBoxSunday
            // 
            checkBoxSunday.AutoSize = true;
            checkBoxSunday.BackColor = Color.White;
            checkBoxSunday.Location = new Point(20, 333);
            checkBoxSunday.Name = "checkBoxSunday";
            checkBoxSunday.Size = new Size(77, 24);
            checkBoxSunday.TabIndex = 5;
            checkBoxSunday.Text = "sunday";
            checkBoxSunday.UseVisualStyleBackColor = false;
            checkBoxSunday.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButtonFaceToFace
            // 
            radioButtonFaceToFace.AutoSize = true;
            radioButtonFaceToFace.Location = new Point(20, 247);
            radioButtonFaceToFace.Name = "radioButtonFaceToFace";
            radioButtonFaceToFace.Size = new Size(59, 24);
            radioButtonFaceToFace.TabIndex = 6;
            radioButtonFaceToFace.TabStop = true;
            radioButtonFaceToFace.Text = "Face";
            radioButtonFaceToFace.UseVisualStyleBackColor = true;
            radioButtonFaceToFace.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(457, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 38);
            label1.TabIndex = 7;
            label1.Text = "Courses Schedule App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 11;
            label2.Text = "Course Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 142);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 12;
            label3.Text = "Teacher : ";
            // 
            // radioButtonOnline
            // 
            radioButtonOnline.AutoSize = true;
            radioButtonOnline.Location = new Point(146, 247);
            radioButtonOnline.Name = "radioButtonOnline";
            radioButtonOnline.Size = new Size(73, 24);
            radioButtonOnline.TabIndex = 13;
            radioButtonOnline.TabStop = true;
            radioButtonOnline.Text = "Online";
            radioButtonOnline.UseVisualStyleBackColor = true;
            radioButtonOnline.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // checkBoxMonday
            // 
            checkBoxMonday.AutoSize = true;
            checkBoxMonday.Location = new Point(127, 333);
            checkBoxMonday.Name = "checkBoxMonday";
            checkBoxMonday.Size = new Size(85, 24);
            checkBoxMonday.TabIndex = 14;
            checkBoxMonday.Text = "monday";
            checkBoxMonday.UseVisualStyleBackColor = true;
            checkBoxMonday.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBoxTuesday
            // 
            checkBoxTuesday.AutoSize = true;
            checkBoxTuesday.Location = new Point(234, 333);
            checkBoxTuesday.Name = "checkBoxTuesday";
            checkBoxTuesday.Size = new Size(84, 24);
            checkBoxTuesday.TabIndex = 15;
            checkBoxTuesday.Text = "Teusday";
            checkBoxTuesday.UseVisualStyleBackColor = true;
            checkBoxTuesday.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // radioButtonBlended
            // 
            radioButtonBlended.AutoSize = true;
            radioButtonBlended.Location = new Point(251, 247);
            radioButtonBlended.Name = "radioButtonBlended";
            radioButtonBlended.Size = new Size(85, 24);
            radioButtonBlended.TabIndex = 16;
            radioButtonBlended.TabStop = true;
            radioButtonBlended.Text = "blended";
            radioButtonBlended.UseVisualStyleBackColor = true;
            radioButtonBlended.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // checkBoxWednesday
            // 
            checkBoxWednesday.AutoSize = true;
            checkBoxWednesday.Location = new Point(20, 374);
            checkBoxWednesday.Name = "checkBoxWednesday";
            checkBoxWednesday.Size = new Size(105, 24);
            checkBoxWednesday.TabIndex = 17;
            checkBoxWednesday.Text = "wednesday";
            checkBoxWednesday.UseVisualStyleBackColor = true;
            checkBoxWednesday.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBoxThursday
            // 
            checkBoxThursday.AutoSize = true;
            checkBoxThursday.Location = new Point(127, 374);
            checkBoxThursday.Name = "checkBoxThursday";
            checkBoxThursday.Size = new Size(90, 24);
            checkBoxThursday.TabIndex = 18;
            checkBoxThursday.Text = "Thursday";
            checkBoxThursday.UseVisualStyleBackColor = true;
            checkBoxThursday.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBoxSaturday
            // 
            checkBoxSaturday.AutoSize = true;
            checkBoxSaturday.Location = new Point(234, 374);
            checkBoxSaturday.Name = "checkBoxSaturday";
            checkBoxSaturday.Size = new Size(89, 24);
            checkBoxSaturday.TabIndex = 19;
            checkBoxSaturday.Text = "Saturday";
            checkBoxSaturday.UseVisualStyleBackColor = true;
            checkBoxSaturday.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 436);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 20;
            label4.Text = "Start : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 224);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 21;
            label5.Text = "Lecture Type : ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 298);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 22;
            label6.Text = "Days : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 75);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // textBoxCourseName
            // 
            textBoxCourseName.Location = new Point(12, 165);
            textBoxCourseName.Name = "textBoxCourseName";
            textBoxCourseName.Size = new Size(125, 27);
            textBoxCourseName.TabIndex = 24;
            textBoxCourseName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxCourseTeacher
            // 
            textBoxCourseTeacher.Location = new Point(184, 165);
            textBoxCourseTeacher.Name = "textBoxCourseTeacher";
            textBoxCourseTeacher.Size = new Size(125, 27);
            textBoxCourseTeacher.TabIndex = 25;
            textBoxCourseTeacher.TextChanged += textBox2_TextChanged;
            // 
            // textBoxStartingTime
            // 
            textBoxStartingTime.Location = new Point(30, 459);
            textBoxStartingTime.Name = "textBoxStartingTime";
            textBoxStartingTime.Size = new Size(125, 27);
            textBoxStartingTime.TabIndex = 26;
            textBoxStartingTime.TextChanged += textBox3_TextChanged;
            // 
            // textBoxFinishTime
            // 
            textBoxFinishTime.Location = new Point(184, 459);
            textBoxFinishTime.Name = "textBoxFinishTime";
            textBoxFinishTime.Size = new Size(125, 27);
            textBoxFinishTime.TabIndex = 27;
            textBoxFinishTime.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(184, 436);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 28;
            label7.Text = "Finish : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1068, 513);
            Controls.Add(label7);
            Controls.Add(textBoxFinishTime);
            Controls.Add(textBoxStartingTime);
            Controls.Add(textBoxCourseTeacher);
            Controls.Add(textBoxCourseName);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBoxSaturday);
            Controls.Add(checkBoxThursday);
            Controls.Add(checkBoxWednesday);
            Controls.Add(radioButtonBlended);
            Controls.Add(checkBoxTuesday);
            Controls.Add(checkBoxMonday);
            Controls.Add(radioButtonOnline);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButtonFaceToFace);
            Controls.Add(checkBoxSunday);
            Controls.Add(listBox1);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAddSchedule);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}