namespace Log_In_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameLabelArabic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordLabelArabic = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.logInBTN = new System.Windows.Forms.Button();
            this.capIndicatorlabel = new System.Windows.Forms.Label();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.ShowPasswordLBL = new System.Windows.Forms.Label();
            this.linkLabelSignIn = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogopictureBox
            // 
            this.LogopictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogopictureBox.Image = global::Log_In_Form.Properties.Resources.logo;
            this.LogopictureBox.Location = new System.Drawing.Point(2, 1);
            this.LogopictureBox.Name = "LogopictureBox";
            this.LogopictureBox.Size = new System.Drawing.Size(203, 114);
            this.LogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogopictureBox.TabIndex = 0;
            this.LogopictureBox.TabStop = false;
            this.LogopictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Maroon;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(179, 234);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(129, 25);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password : ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Maroon;
            this.usernameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameLabel.Location = new System.Drawing.Point(174, 172);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(134, 25);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username : ";
            this.usernameLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // usernameLabelArabic
            // 
            this.usernameLabelArabic.AutoSize = true;
            this.usernameLabelArabic.BackColor = System.Drawing.Color.Maroon;
            this.usernameLabelArabic.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabelArabic.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameLabelArabic.Location = new System.Drawing.Point(499, 172);
            this.usernameLabelArabic.Name = "usernameLabelArabic";
            this.usernameLabelArabic.Size = new System.Drawing.Size(113, 25);
            this.usernameLabelArabic.TabIndex = 7;
            this.usernameLabelArabic.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(482, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // passwordLabelArabic
            // 
            this.passwordLabelArabic.AutoSize = true;
            this.passwordLabelArabic.BackColor = System.Drawing.Color.Maroon;
            this.passwordLabelArabic.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabelArabic.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLabelArabic.Location = new System.Drawing.Point(531, 234);
            this.passwordLabelArabic.Name = "passwordLabelArabic";
            this.passwordLabelArabic.Size = new System.Drawing.Size(85, 25);
            this.passwordLabelArabic.TabIndex = 9;
            this.passwordLabelArabic.Text = "كلمة السر";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(179, 200);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(449, 22);
            this.UsernameTextBox.TabIndex = 10;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(179, 262);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(449, 22);
            this.passwordtextBox.TabIndex = 11;
            this.passwordtextBox.MouseLeave += new System.EventHandler(this.label6_Click);
            this.passwordtextBox.MouseHover += new System.EventHandler(this.ShowPasswordLBL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(512, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // logInBTN
            // 
            this.logInBTN.BackColor = System.Drawing.Color.Maroon;
            this.logInBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logInBTN.Location = new System.Drawing.Point(264, 335);
            this.logInBTN.Name = "logInBTN";
            this.logInBTN.Size = new System.Drawing.Size(249, 43);
            this.logInBTN.TabIndex = 13;
            this.logInBTN.Text = "&Log In    دخول";
            this.logInBTN.UseVisualStyleBackColor = false;
            this.logInBTN.Click += new System.EventHandler(this.logInBTN_Click);
            // 
            // capIndicatorlabel
            // 
            this.capIndicatorlabel.AutoSize = true;
            this.capIndicatorlabel.Location = new System.Drawing.Point(670, 262);
            this.capIndicatorlabel.Name = "capIndicatorlabel";
            this.capIndicatorlabel.Size = new System.Drawing.Size(83, 16);
            this.capIndicatorlabel.TabIndex = 14;
            this.capIndicatorlabel.Text = "caps lock on";
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.Color.Maroon;
            this.ExitBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitBTN.Location = new System.Drawing.Point(735, 423);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(123, 43);
            this.ExitBTN.TabIndex = 15;
            this.ExitBTN.Text = "&Exit";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowPasswordLBL
            // 
            this.ShowPasswordLBL.AutoSize = true;
            this.ShowPasswordLBL.Location = new System.Drawing.Point(185, 293);
            this.ShowPasswordLBL.Name = "ShowPasswordLBL";
            this.ShowPasswordLBL.Size = new System.Drawing.Size(44, 16);
            this.ShowPasswordLBL.TabIndex = 16;
            this.ShowPasswordLBL.Text = "label1";
            this.ShowPasswordLBL.Click += new System.EventHandler(this.ShowPasswordLBL_Click);
            // 
            // linkLabelSignIn
            // 
            this.linkLabelSignIn.AutoSize = true;
            this.linkLabelSignIn.BackColor = System.Drawing.Color.DarkRed;
            this.linkLabelSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSignIn.LinkColor = System.Drawing.Color.White;
            this.linkLabelSignIn.Location = new System.Drawing.Point(360, 406);
            this.linkLabelSignIn.Name = "linkLabelSignIn";
            this.linkLabelSignIn.Size = new System.Drawing.Size(65, 20);
            this.linkLabelSignIn.TabIndex = 17;
            this.linkLabelSignIn.TabStop = true;
            this.linkLabelSignIn.Text = "Sign up";
            this.linkLabelSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Log_In_Form.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 478);
            this.Controls.Add(this.linkLabelSignIn);
            this.Controls.Add(this.ShowPasswordLBL);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.capIndicatorlabel);
            this.Controls.Add(this.logInBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.passwordLabelArabic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameLabelArabic);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.LogopictureBox);
            this.Name = "Form1";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.HidePasswordLBL_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogopictureBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label usernameLabelArabic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label passwordLabelArabic;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logInBTN;
        private System.Windows.Forms.Label capIndicatorlabel;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Label ShowPasswordLBL;
        private System.Windows.Forms.LinkLabel linkLabelSignIn;
    }
}

