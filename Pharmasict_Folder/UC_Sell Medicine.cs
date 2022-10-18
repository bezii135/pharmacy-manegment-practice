using System;                                                                                             
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_manegment_practice.Pharmasict_Folder
{

    public partial class UC_Sell_Medicine : UserControl
    {


        //function fn = new function();
        //String query;
        //DataSet ds; Int64 count;

        public UC_Sell_Medicine()
        {
            InitializeComponent();
        }

        private void txtMedID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMedNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMedNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Sell_Medicine_Load(object sender, EventArgs e)
        {


            //listBox1.Items.Clear();
            //query = "select mname from medic where eDate>= getdate() and quantity>'0'";
            //fn.GetData(query);

            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //}
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //query = "select mname from medic where mname like '" + textBox1.Text + "%'and eDate>=getdate() and quantity>'0'";
            //ds = fn.GetData(query);

            //for (int i = 0; i<ds.Tables[0].Rows.Count; i++)
            //{
            //    listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //}

        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {

        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Sell_Medicine_Load(this, null);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMedID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpExpireDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           
          
        

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //txtQuantity.Clear();

            //String name = listBox1.GetItemText(listBox1.SelectedItems);

            //txtMedName.Text = name;
            //query = "select mid,eDate,perUnit from medic where mname='" + name + "'";

            //ds=fn.GetData(query);
            //txtMedID.Text = ds.Tables[0].Rows[0][0].ToString();
            //dtpExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            //txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();


        }
    }
}
