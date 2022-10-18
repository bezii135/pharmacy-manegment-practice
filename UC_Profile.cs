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
    public partial class uC_Profile : UserControl
    {


        function fn = new function();
        String query;
        

        public uC_Profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { userNameLabel.Text = value; }
        }


        private void UC_Profile_Load(object sender, EventArgs e )
        {
            userNameLabel.Text = "Beza";
            Administrator a = new Administrator();
            userNameLabel.Text = a.x("");
                

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserRole.Text="";
            txtName.Text = "";
            txtDob.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String target= userNameLabel.Text ;
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            String mobile = txtMobile.Text;
            String email = txtEmail.Text;
            String username = userNameLabel.Text;
            String pass = txtPassword.Text;


            query = "update users set userRole='" + role + "',name='" + name + "',dob='" + dob + "',mobile='" + mobile + "',email='" + email + "',pass='" + pass + "'where name='" + target + "'";
            fn.setData(query, "Profile Updation Successful.");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            

        }

        private void chek_Click(object sender, EventArgs e)
        {

        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            UC_Profile_Enter(sender, e, txtUserRole);
        }

        private void UC_Profile_Enter(object sender, EventArgs e, Guna.UI2.WinForms.Guna2ComboBox txtUserRole)
        {

            //query = "select * from users where username='" + userNameLabel.Text + "'";
            //DataSet ds = fn.GetData(query);
            //txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            //txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            //txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            //txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            //txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            //txtPassword.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

