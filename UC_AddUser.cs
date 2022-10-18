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
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
        }

        private static void btnreset_Click(object sender, EventArgs e)
        {

        }

        private static void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private static void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_AddUser_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
           

        }

        private void btnSignUp_Add_Click(object sender, EventArgs e)
        {

            String role = txtUserRole_Add.Text;
            String name = txtName_Add.Text;
            string dob = txtDob_Add.Text;
            Int64 mobile = Int64.Parse(txtMobileNumber_Add.Text);
            String email = txtEmailAddress.Text;
            String username = txtUsername_Add.Text;
            String pass = txtPassword_Add.Text;

            try
            {
                query = "insert into users(userRole,name,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','" + dob + "','" + mobile + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Sign Up Successful.");

            }

            catch (Exception)
            {
                MessageBox.Show("Username Already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtUsername_Add_TextChanged(object sender, EventArgs e)
        {

            query = "select * from users where username='" + txtUsername_Add.Text + "'";
            DataSet ds = fn.GetData(query);


            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\Users\OM\Desktop\ICON\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\OM\Desktop\ICON\Pharmacy Management System in C#\yes.png";
            }
        }

        private void btnReset_Add_Click(object sender, EventArgs e)
        {
            txtName_Add.Clear();
            txtDob_Add.ResetText();
            txtMobileNumber_Add.Clear();
            txtEmailAddress.Clear();
            txtUsername_Add.Clear();
            txtPassword_Add.Clear();
            txtUserRole_Add.SelectedIndex = -1;

        }

        private void txtUserRole_Add_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMobileNumber_Add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_Add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtUsername_Add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_Add_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
