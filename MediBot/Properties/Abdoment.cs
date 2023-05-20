using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBot.Properties
{
    public partial class Abdoment : Form
    {

        public int diverticulitis = 0, gastritis = 0, lactosein = 0, shingles = 0, kidneystone = 0, diarrhea = 0;
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LApain_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RApain_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nausea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bloating_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void rash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void itiching_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void burping_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void heartburn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void uncomfortable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FFB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PainUrine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void loose_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Disease disease = new Disease();
           disease.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            fever.Checked = false;
            LApain.Checked = false;
            RApain.Checked = false;
            nausea.Checked = false;
            bloating.Checked = false;
            burping.Checked = false;
            heartburn.Checked = false;
            uncomfortable.Checked = false;
            FFB.Checked = false;
            PainUrine.Checked = false;   
            itiching.Checked = false;
            rash.Checked = false;
            loose.Checked = false;
            suggestion.Clear();
            suggestionlist.Items.Clear();

        }

        private void suggestionlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Abdoment_Load(object sender, EventArgs e)
        {

        }

        public  Dictionary<string, float> suggestion= new Dictionary<string, float>();

        private void check_Click(object sender, EventArgs e)
        {
          
            suggestion.Clear();
            try
            {
                diverticulitis = 0; gastritis = 0; lactosein = 0; shingles = 0; kidneystone = 0; diarrhea = 0;
        suggestion.Clear();
                suggestionlist.Items.Clear();
                if (fever.Checked ==false && LApain.Checked ==false && RApain.Checked==false&& nausea.Checked==false && bloating.Checked==false&& burping.Checked==false &&heartburn.Checked==false&&uncomfortable.Checked==false&&FFB.Checked==false&&PainUrine.Checked==false&&itiching.Checked==false&&rash.Checked==false&&loose.Checked==false)
                {
                    throw new Exception();
                }


             


                if (fever.Checked == true)
                {
                    diverticulitis++;
                    shingles++;
                }
                if (LApain.Checked == true)
                {
                    diverticulitis++;
                    lactosein++;
                    kidneystone++;
                }
                if (RApain.Checked == true)
                {
                    lactosein++;
                    kidneystone++;
                }
                if (nausea.Checked == true)
                {
                    diverticulitis++;
                    lactosein++;
                    kidneystone++;
                }
                if (bloating.Checked == true)
                {

                    lactosein++;

                }
                if (burping.Checked == true)
                {
                    gastritis++;
                }
                if (heartburn.Checked == true)
                {
                    gastritis++;
                }
                if (uncomfortable.Checked == true)
                {
                    gastritis++;
                }
                if (FFB.Checked == true)
                {

                    shingles += 5;
                }
                if (PainUrine.Checked == true)
                {
                    kidneystone += 5;
                }
                if (itiching.Checked == true)
                {

                    shingles++;
                }
                if (rash.Checked == true)
                {

                    shingles++;
                }
                if (loose.Checked == true)
                {
                    diarrhea++;
                }
                float total = shingles + diarrhea + diverticulitis + lactosein + kidneystone + gastritis;
                float avgshin = shingles / total * 100;
                float avgdia = diarrhea / total * 100;
                float avgdiv = diverticulitis / total * 100;
                float avglac = lactosein / total * 100;
                float avgkid = kidneystone / total * 100;
                float avggas = gastritis / total * 100;
                avgshin = (float)System.Math.Round(avgshin, 2);
                avgdia = (float)System.Math.Round(avgdia, 2);
                avgdiv = (float)System.Math.Round(avgdiv, 2);
                avglac = (float)System.Math.Round(avglac, 2);
                avgkid = (float)System.Math.Round(avgkid, 2);
                avggas = (float)System.Math.Round(avggas, 2);
                suggestion.Add("Shingle", avgshin);
              
                suggestion.Add("Diarrhea", avgdia);
               
                suggestion.Add("Diverticulitis", avgdiv);
                
                suggestion.Add("Lactose Intolerate", avglac);
               
                suggestion.Add("Kidneystone", avgkid);
             
                suggestion.Add("Gastritis", avggas);
              


                foreach (var kk in suggestion)
                {
                    suggestionlist.Items.Add(kk);
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Atleast one box has to be checked");
            }


        }

        public Abdoment()
        {
            InitializeComponent();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fever_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
