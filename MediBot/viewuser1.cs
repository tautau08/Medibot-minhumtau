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
    public partial class viewuser1 : Form
    {
        function1 fn = new function1();
        String query;
        String currentuser = "";
        public viewuser1()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { currentuser = value; }
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            viewuser1_Load(this, null);
        }

        

        private void searchuser_TextChanged(object sender, EventArgs e)
        {
            query="select * from users where username like'"+searchuser.Text+"%'";
            DataSet ds=fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
     
        

        private void dltbtn_Click(object sender, EventArgs e)
        {   if(MessageBox.Show("Are you sure?","Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from users where username='" + username + "'";
                fn.setdata(query,"User Record Deleted.");
                viewuser1_Load(this, null);
            }
            /*if(currentuser!=username)
            {

            }
            else { MessageBox.Show("You are tryig to delete\n your own account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }
        String username;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch { }
        }

        private void viewuser1_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void backtodash_Click(object sender, EventArgs e)
        {
            medpannel a=new medpannel();
            a.Show();
        }
    }
}
