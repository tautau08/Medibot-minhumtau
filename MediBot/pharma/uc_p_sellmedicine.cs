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
    public partial class uc_p_sellmedicine : UserControl
    {
        function1 fn = new function1();
        String query;
        DataSet ds;
        public uc_p_sellmedicine()
        {
            InitializeComponent();
        }

        private void uc_p_sellmedicine_Load(object sender, EventArgs e)
        { medicinelistbox.Items.Clear();
            query = "select mname from medic where edate>=getdate() and quantity >'0'";
            ds=fn.GetData(query);
            for(int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                medicinelistbox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            uc_p_sellmedicine_Load(this, null);
        }

        private void searchbxsell_TextChanged(object sender, EventArgs e)
        {
            medicinelistbox.Items.Clear();
            query = "select mname from medic where mname like '" + searchbxsell.Text + "%' and edate>=getdate() and quantity>'0'";
            ds =fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                medicinelistbox.Items.Add(ds.Tables[0].Rows[i][0].ToString());  

            }
        }

        private void medicinelistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sell_quantity.Clear();
            String name=medicinelistbox.GetItemText(medicinelistbox.SelectedItem);
            sell_mediname.Text = name;
            query = "select mid, edate,perunit from medic where mname='" + name + "'";
            ds =fn.GetData(query);
            sell_mediid.Text = ds.Tables[0].Rows[0][0].ToString();
            sell_ex_dob.Text = ds.Tables[0].Rows[0][1].ToString();
            sell_price.Text = ds.Tables[0].Rows[0][2].ToString();

        }

        private void sell_quantity_TextChanged(object sender, EventArgs e)
        {
            if (sell_quantity.Text != "")
            {
            Int64 unitprice=Int64.Parse(sell_price.Text);
                Int64 noOfUnit=Int64.Parse(sell_quantity.Text);
                Int64 total = unitprice * noOfUnit;
                sell_totalprice.Text = total.ToString();
            }
            else
            {
                sell_totalprice.Clear();
            }
        }
        protected int n, totalammount = 0;
        protected Int64 quantity, newQuantity;
        int valueamount;
        String valueid;
        protected Int64 noOfunit; 
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueamount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueid = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());


            }
            catch(Exception) {  }
        }

        private void sell_removebtn_Click(object sender, EventArgs e)
        {
            if (valueid != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid='" + valueid + "'";
                    ds = fn.GetData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;
                    query = "update medic set quantity='" + newQuantity + "' where mid='" + valueid + "'";
                    fn.setdata(query, "Medicine removed from the Cart!");
                    totalammount = totalammount - valueamount;
                    totalpricelabel.Text = "Tk. " + totalammount.ToString();
                }
                uc_p_sellmedicine_Load(this, null);


            }

        }                        

        private void cartbtn_Click(object sender, EventArgs e)
        {
            if (sell_mediid.Text != "")
            {
                query = "select quantity from medic where mid ='" + sell_mediid.Text + "'";
                ds=fn.GetData(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());//stock available
                newQuantity=quantity-Int64.Parse(sell_quantity.Text);//stock available after adding to cart
                if(newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value =sell_mediid.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = sell_mediname.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value =sell_ex_dob.Text;

                    guna2DataGridView1.Rows[n].Cells[3].Value =sell_price.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value =sell_quantity.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value =sell_totalprice.Text;
                    totalammount = totalammount+int.Parse(sell_totalprice.Text);
                    totalpricelabel.Text = "Tk. " + totalammount.ToString();
                    query="update medic set quantity ='"+newQuantity+"' where mid='" + sell_mediid.Text + "'";
                    fn.setdata(query, "Medicines added to the Cart!");
                }
                else
                {
                    MessageBox.Show("Medicine is out of stock.\nOnly " + quantity + " Left.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                uc_p_sellmedicine_Load(this, null);
                sell_ex_dob.ResetText();
                sell_mediname.Clear();
                sell_mediid.Clear();
                sell_price.Clear();
                sell_quantity.Clear();
                sell_totalprice.Clear();
            }
            else
            {
                MessageBox.Show("Select medicine first.", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
