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
    public partial class uc_p_medivaliditycheck : UserControl
    {
        function1 fn = new function1();
        String Query;
        public uc_p_medivaliditycheck()
        {
            InitializeComponent();
        }

        private void txtcheckcombobox_medivaliditycheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtcheckcombobox_medivaliditycheck.SelectedIndex==0)
            {
                Query = "select * from medic where edate>=getdate()";
               DataSet ds = fn.GetData(Query);
                validitycheckgridview.DataSource = ds.Tables[0];
                setlabel.Text = "Valid Medicines";
                setlabel.ForeColor = Color.Green;
               

            }
            else if(txtcheckcombobox_medivaliditycheck.SelectedIndex==1)
            {
                Query = "select * from medic where edate<getdate()";
                DataSet ds = fn.GetData(Query);
                validitycheckgridview.DataSource = ds.Tables[0];
                setlabel.Text = "Expired Medicines";
                setlabel.ForeColor = Color.Red;
            }
            else
            {
                Query = "select * from medic";
                DataSet ds = fn.GetData(Query);
                validitycheckgridview.DataSource = ds.Tables[0];
                setlabel.Text = "All Medicines";
                setlabel.ForeColor = Color.Black;
            }
        }
    }
}
