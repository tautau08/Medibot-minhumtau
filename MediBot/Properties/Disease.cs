using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBot.Properties
{
    public partial class Disease : Form
    {
        public Disease()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Abdoment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brain brain= new Brain();
            brain.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Heart heart = new Heart();
            heart.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abdoment    abdoment = new Abdoment();
            abdoment.Show();
        }
         private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
