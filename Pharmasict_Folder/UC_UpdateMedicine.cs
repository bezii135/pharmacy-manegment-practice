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
    public partial class UC_UpdateMedicine : UserControl
    {


        function fn = new function();
        String query;
        DataSet ds; Int64 count;
       
        public UC_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void UC_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void txtMedName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtMedID.Text != "")
            {
                query = "select * from medic where mid ='" + txtMedID.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    dtpManufacturing.Text = ds.Tables[0].Rows[0][4].ToString();
                    dtpExpireDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();

                  
          
                }
                else
                {
                    MessageBox.Show("No Medicine with ID:  '" + txtMedID.Text + "' exists.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fn.setData(query, "Medicine Details Updated.");
                }
            }
            else
            {
                clearAll();
            }

        }




        private void clearAll()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            txtMedNumber.Clear();
            dtpManufacturing.ResetText();
            dtpExpireDate.ResetText();
            txtQuantity.Clear();
            txtPrice.Clear();

            if (textBox1.Text != "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = "0";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        Int64 totalQuantity;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMedName.Text;
            String mnumber = txtMedNumber.Text;
            String mdate = dtpManufacturing.Text;
            String edate = dtpExpireDate.Text;
            Int64 quantity =Int64.Parse( txtQuantity.Text);
            Int64 addquantity = Int64.Parse(textBox1.Text);
            String unitPrice = txtPrice.Text;

            totalQuantity = quantity + addquantity;

            query = " update medic set mname ='" + mname + "',mnumber='" + mnumber + "', mdate='" + mdate + "', edate'" + edate + "', quantity='" + totalQuantity + "',perUnit= '" + unitPrice + " where mid ='" + txtMedID.Text + "'";
            fn.setData(query, "medicine details updated.");
        }
    }
}
