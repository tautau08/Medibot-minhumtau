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
    public partial class Brain : Form
    {
        public int braininjury = 0, braintumor = 0, neurodegenerative = 0;
        public Brain()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            brainsug.Clear();
            speech.Checked = false;
            BFE.Checked = false;
            mem.Checked = false;
            con.Checked = false;
            head.Checked = false;
            sei.Checked = false;
            balance.Checked = false;
            mood.Checked = false;
            apa.Checked = false;
            agi.Checked = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Disease disease= new Disease();
            disease.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void speech_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Brain_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void con_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void head_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sei_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void mood_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void balance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void apa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void agi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Dictionary<string, float> brainsug = new Dictionary<string, float>();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(speech.Checked && BFE.Checked && mem.Checked || con.Checked || head.Checked ||sei.Checked ||balance.Checked||mood.Checked||apa.Checked||agi.Checked) 
                {
                    throw new Exception();
                }
                if(speech.Checked)
                {
                    braininjury += 5;
                }
                if(BFE.Checked)
                {
                    braininjury += 5;
                }
                if(mem.Checked)
                {
                    neurodegenerative++;
                    braininjury++;
                    braintumor++;
                }
                if(con.Checked)
                {
                    braininjury++;
                }
                if(head.Checked) {
                    braintumor++;
                }
                if(balance.Checked)
                {
                    braintumor+=5;
                }
                if(mood.Checked)
                {
                    braintumor++;
                    neurodegenerative++;
                }
                if(sei.Checked)
                {
                    braintumor+=5;
                }
                if(apa.Checked) { neurodegenerative++; }
                if(agi.Checked) { neurodegenerative++ ; }
                float total =braintumor+braininjury+neurodegenerative;
                float avgtumor = braintumor / total * 100;
                float avginjury = braininjury / total * 100;
                float avgneu = neurodegenerative / total * 100;
                brainsug.Add("Brain Tumor", avgtumor);
                brainsug.Add("Brain Injury", avginjury);
                brainsug.Add("neurodegenerative", avgneu);

                foreach (KeyValuePair<string, float> kvp in brainsug.OrderByDescending(key => key.Value))
                {
                    listBox1.Items.Add(kvp.Key);
                }

            }
            catch {
                MessageBox.Show("Atleast one box has to be checked");
            }
        }
    }
}
