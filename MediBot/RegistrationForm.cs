using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MediBot
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            string uname = username.Text;
            string firstname = this.firstname.Text;
            string lastname = this.lastname.Text;
            string password = this.password.Text;
            string repassword = confrmpassword.Text;
            string email = this.email.Text;
            string day = this.day.Text;
            string month = this.month.Text;
            string year = this.year.Text;
            string phone = phonenumber.Text;
            string bloodgroup = this.bloodgroup.Text;
            string address = this.address.Text;
           


            try
            {
                if(password != repassword)
                {
                    throw new Exception("Password Does Not Match");
                }

                string id =uname+ "," + password + "," + email + "," +firstname+ "," +lastname+ "," + day +","+month+","+year+","+phone+","+bloodgroup+","+address;
                using(StreamWriter sw = new StreamWriter(uname))
                {
                    sw.WriteLine(id);
                    MessageBox.Show("Account Created Successfully");
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }


            }
            catch(Exception ex)

            { MessageBox.Show(ex.Message); }
           

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.username.Clear();
            this.password.Clear();
            this.email.Clear();
            this.day.Text = "day";
            this.month.Text = "month";
            this.year.Text = "year";
            this.phonenumber.Clear();
            this.bloodgroup.Text = "Bloodgroup";
            this.firstname.Clear();
            this.lastname.Clear();
            this.address.Text = "Address";
            confrmpassword.Clear();
        }
    }
}
