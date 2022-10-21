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
    public partial class Administrator : Form
    {
        private object menuStrip1;
       private object btnDashbord;
        String user = "";

        public Administrator()
        {   
            InitializeComponent();

           
        }



        public String ID
        {
            get { return user.ToString(); }
        }


        public Administrator(String username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            uC_ViewUser1.ID = ID;
            uC_Profile1.ID = ID;
        }

        public String x(String username)
        {
            String v = username;
            return v;
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = false;
           uC_ViewUser1.Visible = false;
            uC_Profile1.Visible = false;
            Dash_board.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront(); 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible=true;
            uC_ViewUser1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(); 
            fm.Show();
            this.Hide();
        }

        private void uC_Dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddUser1_Load_1(object sender, EventArgs e)
        {
        }

        private void uC_Profile1_Load(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
