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


        function fn = new function();
        String query;
        DataSet ds; Int64 count;

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

            listBox1.Items.Clear();
            query = "select mname from medic where eDate >= 'getdate()' and quantity >'0' ";
            ds= fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString()); 

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
            query = "select mname from medic where mname like '" + textBox1.Text + "%' and eDate>= 'getdate()' and quantity >'0'";
            ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
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
            if (txtQuantity.Text != "")
            {
                Int64 unitPrice= Int64.Parse(txtPrice.Text);
                Int64 noOfUnit = Int64.Parse(txtQuantity.Text);
                Int64 TotalAmount =unitPrice* noOfUnit;
                txtTotalPrice.Text = TotalAmount.ToString();

            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
        
        private void listBox1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        int valueAmount;
        String valueId;
        protected Int64 noOfUnit;
        private void gview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(gview.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = gview.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(gview.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
        protected int r, TotalAmount = 0;
        protected Int64 Quantity, newquantity;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    gview.Rows.RemoveAt(this.gview.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid='" + valueId + "' ";
                    ds = fn.GetData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newquantity = quantity + noOfUnit;
                    query = "upadate medic set quantity = '" + newquantity + "' where mid= '" + valueId + "'";
                    fn.setData(query, "Medicine Removed From Cart");
                    totalAmount = totalAmount - valueAmount;
                    Totallabel.Text = "$. " + totalAmount.ToString();

                }
                UC_Sell_Medicine_Load(this, null);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedID.Text != "")
            {
                query = " select quantity from medic where mid = '" + txtMedID.Text + "'";
                ds= fn.GetData(query);
                Quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newquantity=Quantity - Int64.Parse(txtQuantity.Text);
                if (newquantity >= 0)
                {
                    r= gview.Rows.Add();
                    gview.Rows[r].Cells[0].Value = txtMedID.Text;
                    gview.Rows[r].Cells[1].Value = txtMedName.Text;
                    gview.Rows[r].Cells[2].Value = dtpExpireDate.Text;
                    gview.Rows[r].Cells[3].Value = txtPrice.Text;
                    gview.Rows[r].Cells[4].Value = txtQuantity.Text;
                    gview.Rows[r].Cells[5].Value = txtTotalPrice.Text;

                    TotalAmount= TotalAmount+int.Parse(txtTotalPrice.Text);
                    Totallabel.Text= "Rs. " + TotalAmount.ToString();
                    query = "Update medic set quantity ='" + newQuantity + "' where mid= '" + txtMedID.Text + "'";
                    fn.setData(query, "Medicine Added.");

                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock.\n Only "+Quantity+"Left","Warning!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);


                }
                UC_Sell_Medicine_Load(this, null);
                clearAll();

            }
            else
            {
                MessageBox.Show("Select Medicine First.", "information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
          
          
        

    }

        private void clearAll()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            dtpExpireDate.ResetText();
            txtPrice.Clear();
            txtQuantity.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.Clear();
            String Name = listBox1.GetItemText(listBox1.SelectedItem);
            txtMedName.Text = Name;
            query = "select mid,eDate,perUnit from medic where mname ='" + Name + "'";
            ds = fn.GetData(query);
            txtMedID.Text = ds.Tables[0].Rows[0][0].ToString();
            dtpExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();





        }
    }
}
