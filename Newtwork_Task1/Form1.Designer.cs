namespace Newtwork_Task1
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.passwordBOx = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Already have an account?";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(343, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(65, 25);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Log in";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.signUpButton);
            this.groupBox1.Controls.Add(this.checkBox);
            this.groupBox1.Controls.Add(this.confirmBox);
            this.groupBox1.Controls.Add(this.passwordBOx);
            this.groupBox1.Controls.Add(this.EmailBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lastNameBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.firstNameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 455);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SIGN UP";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Lime;
            this.signUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpButton.Location = new System.Drawing.Point(111, 414);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(293, 35);
            this.signUpButton.TabIndex = 12;
            this.signUpButton.Text = "SIGN UP NOW";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(50, 371);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(372, 24);
            this.checkBox.TabIndex = 11;
            this.checkBox.Text = "I accept the Terms of Use and  Privacy Policy";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // confirmBox
            // 
            this.confirmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.confirmBox.Location = new System.Drawing.Point(27, 324);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(447, 22);
            this.confirmBox.TabIndex = 10;
            this.confirmBox.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // passwordBOx
            // 
            this.passwordBOx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBOx.ForeColor = System.Drawing.SystemColors.InfoText;
            this.passwordBOx.Location = new System.Drawing.Point(27, 249);
            this.passwordBOx.Name = "passwordBOx";
            this.passwordBOx.Size = new System.Drawing.Size(447, 22);
            this.passwordBOx.TabIndex = 9;
            this.passwordBOx.TextChanged += new System.EventHandler(this.PasswordBOx_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EmailBox.Location = new System.Drawing.Point(27, 176);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(447, 22);
            this.EmailBox.TabIndex = 8;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameBox.Location = new System.Drawing.Point(294, 95);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(180, 22);
            this.lastNameBox.TabIndex = 4;
            this.lastNameBox.TextChanged += new System.EventHandler(this.LastNameBox_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name ";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNameBox.Location = new System.Drawing.Point(27, 95);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(180, 22);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.TextChanged += new System.EventHandler(this.FirstNameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create your account. It\'s FREE and only takes 1 minute.";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel loginLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmBox;
        private System.Windows.Forms.TextBox passwordBOx;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button signUpButton;
    }
}

