using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBot.AdministratorUC
{
    public partial class UC_dashboard : UserControl
    {
        function1 fn = new function1();
        String query;
        DataSet ds;
        public UC_dashboard()
        {
            InitializeComponent();
        }



        private void UC_dashboard_Load(object sender, EventArgs e)
        {
            query = "select count (userRole) from users where userRole='Administrator'";
            ds = fn.GetData(query);
            setlabel(ds, labeladmin);
            query = "select count (userRole) from users where userRole='Pharmacist'";
            ds = fn.GetData(query);
            setlabel(ds,labelphar);
        }
        private void setlabel(DataSet ds,Label a)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                a.Text = ds.Tables[0].Rows[0][0].ToString();   
            }
            else { a.Text = "0"; }
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            UC_dashboard_Load(this, null);
        }
    }
}
