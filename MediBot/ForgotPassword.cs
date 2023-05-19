using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBot
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string receiver, source, password, OTP;
            receiver = forgotpassemail.Text;
            source = "hamimsaad.raji@gmail.com";
            OTP = RandomNumber.randomNumber.ToString();
            password = "gwzo boqf yubf gltk";
            try
            {
                MailMessage message = new MailMessage();
                message.To.Add(receiver);
                message.From = new MailAddress(source);
                message.Body = $"Your Verification Code For MediBot App is \n\n\t\t{OTP} \n" +
                    $"\nNever Share Your Code With Anyone!";
                message.Subject = "MediBot - Verification Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(source, password);



                smtp.Send(message);
                MessageBox.Show("Verification Code Sent Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter E-mail in Correct Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            if (RandomNumber.randomNumber.ToString() == otp.Text)
            {
                MessageBox.Show("E-mail Verified!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Wrong OTP!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
