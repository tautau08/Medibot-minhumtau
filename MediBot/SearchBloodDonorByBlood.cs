using System;
using System.Collections;
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
    public partial class SearchBloodDonorByBlood : Form
    {
        function fn = new function();
        String query;
        public SearchBloodDonorByBlood()
        {
            InitializeComponent();
        }

        private void SearchBloodDonorByBlood_Load(object sender, EventArgs e)
        {
            query = "Select * from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchBlood_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBlood.Text != "")
            {
                string query = "Select * from newDonor where bloodgroup Like '" + txtSearchBlood.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string query = "Select * from newDonor";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
