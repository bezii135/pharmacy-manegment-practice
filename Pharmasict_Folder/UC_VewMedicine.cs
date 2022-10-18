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
    public partial class UC_VewMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_VewMedicine()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            query = "select * from medic where mname like'" + textBox1.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void UC_VewMedicine_Load(object sender, EventArgs e)
        {

            query = "select * from medic";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];


        }


        private void setDataGridVeiw(String query)
        {
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String medicineId;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                medicineId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_VewMedicine_Load(this, null);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
