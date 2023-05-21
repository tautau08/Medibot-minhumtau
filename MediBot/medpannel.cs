using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBot
{
    public partial class medpannel : Form
    {
        String user = "";
        
        public medpannel()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public medpannel(String username)
        {
            InitializeComponent();
            
            user = username;
           viewuser1 a = new viewuser1();
            a.ID = ID;

        }
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            //adminlog1.Visible = true;
            //adminlog1.BringToFront();
            uC_adduser1.Visible = true;
            loadgif.Visible = false;
            uC_dashboard1.Visible = false;
            Welcomemesg.Visible = false;

        }

        

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {   Front_page a= new Front_page();
            a.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_dashboard1.Visible = true;
            uC_dashboard1.BringToFront();
            loadgif.Visible = false;
            Welcomemesg.Visible = false;
        }

        private void medpannel_Load(object sender, EventArgs e)
        {
            uC_dashboard1.Visible=false;
            uC_adduser1.Visible=false;
            adminlog1.Visible=false;
            loadgif.Visible=true; loadgif.BringToFront();
            Welcomemesg.Visible = true;Welcomemesg.BringToFront();


        }

        private void phamacistbtn_Click(object sender, EventArgs e)
        {
            Pharmacist pharmacist = new Pharmacist();
            pharmacist.Show();
            this.Hide();
        }
    }
}
