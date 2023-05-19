using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBot.AdministratorUC
{
    public partial class UC_adduser : UserControl
    {
        function1 fn = new function1();
        String query;
       
        public UC_adduser()
        {
            
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (UserRole.Text != "" && addname.Text != "" && adddob.Text != "" && addmobnmbr.Text != "" && addusername.Text != "" && addemail.Text != "" && addpassword.Text != "")
            {
                String role = UserRole.Text;
                String name = addname.Text;
                String dob = adddob.Text;
                Int64 mobile = Convert.ToInt64(addmobnmbr.Text);
                String email = addemail.Text;
                String username = addusername.Text;
                String password = addpassword.Text;

                try
                {
                    query = "insert into users (userRole,name,dob,mobile,email,username,pass) values('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + password + "')";
                    fn.setdata(query, "Sign Up Successful.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Username already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Enter all the information to SignUp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            UserRole.SelectedIndex = -1;
            addname.Clear();
            addemail.Clear();
            addmobnmbr.Clear();
            addusername.Clear();
            addpassword.Clear();
            adddob.ResetText();
        }

        

        private void addusername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + addusername.Text + "'";
            DataSet ds = fn.GetData(query);   
            if (ds.Tables[0].Rows.Count ==0)
            {
                checkPic.ImageLocation = @"D:\yes.png";
            }
            else
            {
                checkPic.ImageLocation = @"D:\no2.png";
            }
        }

        private void viewuserbtn_Click(object sender, EventArgs e)
        { 
            
            viewuser1 a = new viewuser1();
            a.Show();
        }

       
    }
}
