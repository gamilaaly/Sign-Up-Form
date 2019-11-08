using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newtwork_Task1
{
    public partial class Form1 : Form
    {
        bool firstNameFlag = false;
        bool lastNameFlag = false;
        bool passwordFlag = false;
        bool emailFlag = false;
        bool confirmFlag = false;
        bool checkBoxFlag = false;
        int counterPassword = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {   
            if (firstNameBox.Text.Length <= 0 || firstNameBox.Text.Length > 15)
            {
                MessageBox.Show("Name Can't be blank", "Invaild Input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameFlag = false;
            }
            else
            {
                firstNameFlag = true;
            }
            Console.WriteLine(firstNameFlag);

        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            { checkBoxFlag = true;
            }
            else { checkBoxFlag = false; }


        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            bool result = passwordBOx.Text.Equals(confirmBox.Text);
            if (result == false & confirmBox.Text.Length == passwordBOx.Text.Length)
            {
                MessageBox.Show("Password doesn't match!", "Invaild Input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmFlag = false;
            }
            else
            {
                confirmFlag = true;
              
            }
       

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (firstNameFlag == true & lastNameFlag == true & emailFlag == true & confirmFlag == true & checkBoxFlag == true & passwordFlag == true)
            {
              MessageBox.Show("Signed Up Successfully!", "Information",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else {
                MessageBox.Show("You must complete all fields", "Invaild Input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void PasswordBOx_TextChanged(object sender, EventArgs e)
        {
            
            if (passwordBOx.Text.Length <8 & counterPassword> 8)
            {
                MessageBox.Show("Password mush contains at least 8 characters", "Invaild Input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordFlag = false;
            }
            else
            {
                passwordFlag = true;
                counterPassword++;
        
            }

        
        }


        private void EmailBox_TextChanged(object sender, EventArgs e)
        {   
            if ( EmailBox.Text.IndexOf("@") == -1 & EmailBox.Text.IndexOf(".") == -1 & EmailBox.Text.Length > 15)
            {
                MessageBox.Show("Invalid Email Address", "Invaild Input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailFlag = false;
            }
            else
            {
                emailFlag = true;
            }
  
        

        }

        private void LastNameBox_TextChanged_1(object sender, EventArgs e)
        {
            if (lastNameBox.Text.Length <= 0 || lastNameBox.Text.Length > 15)
            {
                MessageBox.Show("Name Can't be blank", "Invaild Input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lastNameFlag = true;
            }
        }
    }
}
