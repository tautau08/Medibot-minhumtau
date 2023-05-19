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
    public partial class auc_p_admedi : UserControl
    {
        function1 fn = new function1();
        String query;
        public auc_p_admedi()
        {
            InitializeComponent();
        }

        private void mediaddbtn_Click(object sender, EventArgs e)
        {
            if (mediname.Text != "" && medinmbr.Text != "" && mediprice.Text != "" && mediid.Text != "" && medimandob.Text != "" && mediexdob.Text != "" && mediquan.Text != "")
            {
                String mid = mediid.Text;
                String mname=mediname.Text;
                String mnumber=medinmbr.Text;
                Int64 quantity=Convert.ToInt64(mediquan.Text);
                Int64 price=Convert.ToInt64(mediprice.Text);
                String mdate=medimandob.Text;
                String edate=mediexdob.Text;
                query = "insert into medic(mid,mname,mnumber,mdate,edate,quantity,perunit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mdate + "','" + edate + "'," + quantity + "," + price + ")";
                fn.setdata(query, "Medicine added to Database.");
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            mediid.Clear();
            mediname.Clear();
            medinmbr.Clear();
            mediquan.Clear();
            medimandob.ResetText();
            mediexdob.ResetText();
            mediprice.Clear();
        }

        
    }
}
