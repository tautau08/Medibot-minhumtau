using MediBot.pharma;
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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            uc_p_updatemedicine1.Visible = true;
            uc_p_updatemedicine1.BringToFront();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Form1 a=new Form1();
            a.Show();
            this.Close();
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uc__p1.Visible = true;
            uc__p1.BringToFront();

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
           uc__p1.Visible = false;
            auc_p_admedi1.Visible = false;
            viewmedi1.Visible = false;
            uc_p_updatemedicine1.Visible=false;
            uc_p_medivaliditycheck1.Visible=false;
            uc_p_sellmedicine1.Visible=false;
        }

        private void aduserbtn_Click(object sender, EventArgs e)
        {
        auc_p_admedi1.Visible=true;
            auc_p_admedi1.BringToFront();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            viewmedi1.Visible=true;
            viewmedi1.BringToFront();
        }

        private void btnmedivaliditycheck_Click(object sender, EventArgs e)
        {
            uc_p_medivaliditycheck1.Visible=true;
            uc_p_medivaliditycheck1.BringToFront();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            uc_p_sellmedicine1.Visible = true;
            uc_p_sellmedicine1.BringToFront();
        }
    }
}
