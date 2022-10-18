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
    


    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMedID.Text = "";
            txtMedName.Text = "";
            txtMedNumber.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void txtMedID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedID.Text != "" && txtMedName.Text != "" && txtMedNumber.Text != "" && txtQuantity.Text != "" && txtPrice.Text != "")
            {
                String mid = txtMedID.Text;
                String mname = txtMedName.Text;
                String mnumber = txtMedNumber.Text;
                String mdate = dtpManufacturing.Text;
                String edate = dtpExpireDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPrice.Text);

                query = "insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mdate + "','" + edate + "','" + quantity + "','" + perunit + "')";
                fn.setData(query, "Medicine Added to Database.");


            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information,", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMedName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpExpireDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpManufacturing_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {

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

        private void txtMedName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

