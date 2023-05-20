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
    public partial class Heart : Form
    {
        public Heart()
        {
            InitializeComponent();
        }
        public int arrhythmias = 0, cardiomyopathy = 0, heart = 0;
        public Dictionary<string, float> heartsug = new Dictionary<string, float>();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                arrhythmias = 0; cardiomyopathy = 0; heart = 0;
        listBox1.Items.Clear();
                heartsug.Clear();
                if (chest.Checked==false &&diz.Checked==false&&breath.Checked == false &&fat.Checked == false &&leg.Checked == false &&jaw.Checked == false &&arm.Checked == false && sweat.Checked == false && nausea.Checked == false) {
                    throw new Exception();
                        }
                    if(chest.Checked)
                {
                    arrhythmias++;
                    heart++;
                }
                    if(breath.Checked)
                {
                    arrhythmias++;
                    heart++;
                }
                    if(fat.Checked)
                {
                    cardiomyopathy+=3;
                    heart++;
                }
                    if(leg.Checked)
                {
                    cardiomyopathy += 2;
                }
                    if(jaw.Checked)
                {
                    heart++;
                }
                    if(arm.Checked)
                {
                    heart+=4;
                }
                if(sweat.Checked){
                    heart += 2;

                }
                if (nausea.Checked) { heart ++;
                    cardiomyopathy++;
                }
                float total = heart + cardiomyopathy + arrhythmias;
                float avgar = arrhythmias / total * 100;
                float avgcar = cardiomyopathy/ total * 100;
                float avgher = heart/ total * 100;
                avgar = (float)System.Math.Round(avgar, 2);
                avgcar = (float)System.Math.Round(avgcar, 2);
                avgher = (float)System.Math.Round(avgher, 2);
                heartsug.Add("Arrhythmias",avgar);
                heartsug.Add("Cardiomyopathy", avgcar);
                heartsug.Add("Heart Attack", avgher);

                foreach (var kk in heartsug)
                {
                    listBox1.Items.Add(kk);
                }


            }
            catch
            {
                MessageBox.Show("Atleast One Box Have to be Checked");
                }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            chest.Checked= false;
            breath.Checked= false;
            diz.Checked= false;
            fat.Checked = false;    
            leg.Checked= false;
            jaw.Checked= false;
            arm.Checked= false;
            sweat.Checked= false;
            nausea.Checked= false;
            listBox1.Items.Clear();
            heartsug.Clear();
        }

        private void chest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void diz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void breath_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void leg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void jaw_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void arm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sweat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nausea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Disease disease= new Disease();
            disease.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
