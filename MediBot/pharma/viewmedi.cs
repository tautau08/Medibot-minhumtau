using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBot.pharma
{
    public partial class viewmedi : UserControl
    {
        function1 fn = new function1();
        String query;

        public viewmedi()
        {
            InitializeComponent();
        }

        private void viewmedi_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void searchmedi_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '"+searchmedi.Text+"%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String medicineid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineid = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch { }
        }

        private void medicinedltbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete?","Delete Confirmations",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                query="delete from medic where mid='"+medicineid+"'";
                fn.setdata(query, "Medicine Deleted!");
                viewmedi_Load(this, null);

            }
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            viewmedi_Load(this, null);
        }

       
    }
}
