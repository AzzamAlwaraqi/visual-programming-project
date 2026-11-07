namespace Log_In_Form
{
    partial class FormSignin
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.textBoxMajor = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.buttonSignIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(150, 78);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(172, 22);
            this.UserName.TabIndex = 0;
            this.UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.BackColor = System.Drawing.Color.White;
            this.textBoxMajor.Location = new System.Drawing.Point(150, 244);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.Size = new System.Drawing.Size(100, 22);
            this.textBoxMajor.TabIndex = 1;
            this.textBoxMajor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.White;
            this.textBoxID.Location = new System.Drawing.Point(150, 163);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Password_Box
            // 
            this.Password_Box.BackColor = System.Drawing.Color.White;
            this.Password_Box.Location = new System.Drawing.Point(150, 334);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(100, 22);
            this.Password_Box.TabIndex = 3;
            this.Password_Box.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // buttonSignIN
            // 
            this.buttonSignIN.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSignIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSignIN.Location = new System.Drawing.Point(26, 404);
            this.buttonSignIN.Name = "buttonSignIN";
            this.buttonSignIN.Size = new System.Drawing.Size(96, 34);
            this.buttonSignIN.TabIndex = 5;
            this.buttonSignIN.Text = "&Sign up";
            this.buttonSignIN.UseVisualStyleBackColor = false;
            this.buttonSignIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 100;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Firebrick;
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfirm.Location = new System.Drawing.Point(295, 332);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(72, 24);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "&Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogopictureBox
            // 
            this.LogopictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogopictureBox.Image = global::Log_In_Form.Properties.Resources.logo;
            this.LogopictureBox.Location = new System.Drawing.Point(600, 0);
            this.LogopictureBox.Name = "LogopictureBox";
            this.LogopictureBox.Size = new System.Drawing.Size(203, 114);
            this.LogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogopictureBox.TabIndex = 8;
            this.LogopictureBox.TabStop = false;
            this.LogopictureBox.Click += new System.EventHandler(this.LogopictureBox_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(22, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Major";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "User ID";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_btn.Location = new System.Drawing.Point(695, 404);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(93, 34);
            this.Exit_btn.TabIndex = 101;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Firebrick;
            this.buttonReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReturn.Location = new System.Drawing.Point(569, 404);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(93, 34);
            this.buttonReturn.TabIndex = 102;
            this.buttonReturn.Text = "&Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Firebrick;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(241, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 32);
            this.label5.TabIndex = 103;
            this.label5.Text = "SignUp Sysytem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Firebrick;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(147, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 18);
            this.label6.TabIndex = 104;
            this.label6.Text = "Note: please enter your Full Name";
            // 
            // FormSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Log_In_Form.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogopictureBox);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSignIN);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxMajor);
            this.Controls.Add(this.UserName);
            this.Name = "FormSignin";
            this.Text = "FormSignin";
            this.Load += new System.EventHandler(this.FormSignin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox textBoxMajor;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Button buttonSignIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.PictureBox LogopictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}