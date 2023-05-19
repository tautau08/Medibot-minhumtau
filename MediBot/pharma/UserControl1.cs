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
    public partial class uc__p : UserControl
    {
        function1 fn = new function1();
        String query;
        DataSet ds;
        Int64 count;
        public uc__p()
        {
            InitializeComponent();
        }

        private void uc__p_Load(object sender, EventArgs e)
        {
            loadchart();

        }
        public void loadchart()
        {
             query = "SELECT COUNT(mname) FROM medic WHERE edate >= getdate()";

            ds = fn.GetData(query);
            count =Convert.ToInt64( ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine validity chart", count);
            query = "SELECT COUNT(mname) FROM medic WHERE edate < getdate()";

            ds = fn.GetData(query);
            count = Convert.ToInt64(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine validity chart", count);
        }

        private void reloadmedichart_Click(object sender, EventArgs e)
        {

        }

       
    }
}
