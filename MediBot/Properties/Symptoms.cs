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
    public partial class Symptoms : Form
    {
        public Symptoms()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Abdoment abdoment= new Abdoment();
            abdoment.Show();
            this.Close();

        }
    }
}
