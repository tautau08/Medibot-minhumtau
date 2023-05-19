using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string fileName = Login_User_Name.Text;
            string filePath = Path.Combine(Application.StartupPath, fileName);



            try
            {
                using (StreamReader reader = new StreamReader(filePath))

                    if (File.Exists(fileName))
                    {

                        string[] lines = File.ReadAllLines(fileName);



                        foreach (string line in lines)
                        {
                            string[] login = line.Split(',');
                            string userName = login[0];
                            string passWord = login[1];

                            if (userName == Login_User_Name.Text && passWord == Login_Password.Text)
                            {
                                MessageBox.Show("Login Successful");
                            }
                        if(passWord != Login_Password.Text)
                            {
                                MessageBox.Show("Incorrect Password");
                            }

                        }

                    }
            }
            catch (Exception ex) { MessageBox.Show("Username Does Not Exist"); }
        }


        private void Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Password.Checked == true)
            {
                Login_Password.UseSystemPasswordChar = false;
            }
            else
            {
                Login_Password.UseSystemPasswordChar = true;
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void Recoverpassbutton_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

