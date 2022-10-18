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
    public partial class UC_ViewUser : UserControl
    {

        function fn = new function();
        String query;
        String currentUser = "";
        DataSet ds;

        public UC_ViewUser()
        {
            InitializeComponent();
        }



        public string ID
        {

            set { currentUser = value; }
        }

        public void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '" + txtUserName_View.Text + "%";//a%
            guna2DataGridView1.DataSource = ds.Tables[0];
        }


        String userName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }

            catch
            {

            }


        }

        
        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "DeleteConfirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                if (currentUser != userName)
                {
                    query = "delete from users where username='" + userName + "'";
                    fn.setData(query, "User Record Deleted.");
                    UC_ViewUser_Load(this, null);
                }

                else
                {
                    MessageBox.Show("You are trying to delete \n Your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_ViewUser_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        private void txtUserName_View_TextChanged(object sender, EventArgs e)
        {
            //query = "select * from users where mname like'" + txtUserName_View.Text + "%'";
            //DataSet ds = fn.GetData(query);
            //guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUserName_View_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }





}

