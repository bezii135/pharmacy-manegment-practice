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
    }
}
