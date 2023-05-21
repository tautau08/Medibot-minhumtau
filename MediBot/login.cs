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
    public partial class login : Form
    {
        function1 fn = new function1();
        String query;
        DataSet ds;
        public bool d;
        public login()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if (logusername.Text == "tauhid" && logpass.Text == "TauTau")
                {
                    medpannel a = new medpannel();
                    a.Show();
                    this.Hide();
                }
            }
            else
            {

                query = "select * from users where username='" + logusername.Text + "' and pass='" + logpass.Text + "'";
                ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {

                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {   medpannel a=new medpannel();
                        a.Show();
                        logusername.Clear();
                        logpass.Clear();
                        this.Hide();


                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();


                    }

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            this.Hide();
        }
    }
}
