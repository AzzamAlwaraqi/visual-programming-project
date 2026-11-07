namespace Student_Interface
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            pictureBox1 = new PictureBox();
            buttonSave = new Button();
            buttonExit = new Button();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelStudentName = new Label();
            labelStudentID = new Label();
            labelMajor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 75);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Firebrick;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.ForeColor = SystemColors.ButtonHighlight;
            buttonSave.Location = new Point(434, 499);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "&Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += button1_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Firebrick;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.ForeColor = SystemColors.ControlLightLight;
            buttonExit.Location = new Point(865, 499);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "&Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(437, 38);
            label1.TabIndex = 5;
            label1.Text = "Student Course Booking System";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(382, 55);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(636, 422);
            checkedListBox1.TabIndex = 6;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 7;
            label2.Text = "Student_Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 8;
            label3.Text = "Student_ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 229);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 9;
            label4.Text = "Student_Major: ";
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Location = new Point(118, 120);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(27, 20);
            labelStudentName.TabIndex = 10;
            labelStudentName.Text = "___";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Location = new Point(118, 174);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(27, 20);
            labelStudentID.TabIndex = 11;
            labelStudentID.Text = "___";
            // 
            // labelMajor
            // 
            labelMajor.AutoSize = true;
            labelMajor.BackColor = Color.Transparent;
            labelMajor.Location = new Point(118, 229);
            labelMajor.Name = "labelMajor";
            labelMajor.Size = new Size(27, 20);
            labelMajor.TabIndex = 12;
            labelMajor.Text = "___";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 543);
            Controls.Add(labelMajor);
            Controls.Add(labelStudentID);
            Controls.Add(labelStudentName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button buttonSave;
        private Button buttonExit;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelStudentName;
        private Label labelStudentID;
        private Label labelMajor;
    }
}