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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }
       

            private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form1 fm=new Form1();
            fm.ShowDialog();    
            this.Hide();    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_ValidtyCheck1.Visible = true;
            uC_ValidtyCheck1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_VewMedicine1.Visible = true;
            uC_VewMedicine1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uC_VewMedicine1.Visible = false;
            uC_UpdateMedicine1.Visible = false;
            uC_ValidtyCheck1.Visible = false;
            

        }

        private void btnmodifymedicine_Click(object sender, EventArgs e)
        {
            uC_UpdateMedicine1.Visible = true;
            uC_UpdateMedicine1.BringToFront();
        }

        private void uC_Sell_Medicine1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
