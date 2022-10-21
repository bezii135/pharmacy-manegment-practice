using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_manegment_practice
{
    public partial class UC_Dashboard : UserControl
    {


        function fn = new function();
        String query;
        DataSet ds;


        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole='Adimistator'";
            ds = fn.GetData(query);
            setLabel(ds,AdminLabel);
           
            query = "select count(userRole) from users where userRole='Cashier'";
            ds = fn.GetData(query);
            setLabel(ds, CustLabel);


            query = "select count(userRole) from users where userRole='Pharmacist'";
            ds = fn.GetData(query);
            setLabel(ds,PharmLabel);
        }


        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            UC_Dashboard_Load(this, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void PharmLabel_Click(object sender, EventArgs e)
        {

        }

        private void CustLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
