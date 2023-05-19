using MediBot.AdministratorUC;
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
    public partial class adminlog : UserControl
    {
        function1 fn = new function1();
        String query;
        DataSet ds;
        public bool d;
        public adminlog()
        {
            InitializeComponent();
        }

       

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.GetData(query);
            
                if (ds.Tables[0].Rows.Count == 0)
                {
                    if (guna2TextBox1.Text == "tauhid" && guna2TextBox2.Text == "TauTau")
                    {
                        
                        this.Hide();
                    }
                }
                else
                {
               
                    query = "select * from users where username='" + guna2TextBox1.Text + "' and pass='" + guna2TextBox2.Text + "'";
                    ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {

                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        guna2TextBox1.Clear();
                        guna2TextBox2.Clear();
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
            
        }

       
    }
}
