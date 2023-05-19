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
    public partial class uc_p_updatemedicine : UserControl
    {
        function1 fn = new function1();
        String query;
        public uc_p_updatemedicine()
        {
            InitializeComponent();
        }

        private void idsrchupdt_btn_Click(object sender, EventArgs e)
        {
            if (mediidupdt.Text != "")
            {
                query = "select * from medic where mid='" + mediidupdt.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    medinmupdt.Text = ds.Tables[0].Rows[0][2].ToString();
                    medinmbrupdt.Text = ds.Tables[0].Rows[0][3].ToString();
                    medimandobupdt.Text = ds.Tables[0].Rows[0][4].ToString();
                    mediexdobupdt.Text = ds.Tables[0].Rows[0][5].ToString();
                    mediquanupdt.Text = ds.Tables[0].Rows[0][6].ToString();
                    medipriceupdt.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with " + mediidupdt.Text + " exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {medipriceupdt.Clear();
                mediidupdt.Clear();
                medinmupdt.Clear();
                medinmbrupdt.Clear();
                mediquanupdt.Clear();
                mediexdobupdt.ResetText();
                medimandobupdt.ResetText();
                medipriceupdt.Clear();
                if (mediadquanupdt.Text != "0")
                {
                    mediadquanupdt.Text = "0";
                }
                else
                {
                    mediadquanupdt.Text = "0";
                }

               
            }

        }
        Int64 totalQuantity;
        private void mediupdt_btn_Click(object sender, EventArgs e)
        {
            String mname=medinmupdt.Text;
            String mnumber=medinmbrupdt.Text;
            String mdate = medimandobupdt.Text;
            String edate = mediexdobupdt.Text;
            Int64 quantity=Int64.Parse(mediquanupdt.Text);
            Int64 addquantity = Int64.Parse(mediadquanupdt.Text);
            Int64 unitprice=Int64.Parse(medipriceupdt.Text);
            totalQuantity = quantity+addquantity;
            query="update medic set mname='"+mname+"',mnumber='"+mnumber+"',mdate='"+mdate+"',edate='"+edate+"',quantity="+totalQuantity+",perunit=" + unitprice + " where mid='" + mediidupdt.Text + "'";
            fn.setdata(query, "Medicine Details Updated!");
        }
    }
}
