using pharmacy_manegment_practice.Pharmasict_Folder;
using System.Data;

namespace pharmacy_manegment_practice
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        public object MessageBoxIcons { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Beza" && txtpassword.Text == "pass")
            {
                Administrator am = new Administrator();
                am.Show();
                this.Hide();
            }
            else if (txtusername.Text == "Birukti" && txtpassword.Text == "pass")
            {
                Pharmacist am = new Pharmacist();
                am.Show();
                this.Hide();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wrong  Username OR Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            /* query = "select * from users";
             DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                 if (txtusername.Text == "Beza" && txtpassword.Text == "pass")
                 {
                     Administrator admin = new Administrator();
                     admin.Show();
                     this.Hide();
                 }

                if (ds.Tables[0].Rows.Count == 0)
             {
                     query = "select * from users where username='" + txtusername.Text + "' and pass='" + txtpassword.Text + "''";
                     ds = fn.GetData(query);
                     if (ds.Tables[0].Rows.Count != 0)
                     {
                         String role = ds.Tables[0].Rows[0][1].ToString();
                         if (role == "Administrator")
                         {
                             Administrator admin = new Administrator(txtusername.Text);
                             admin.Show();
                             this.Hide();
                         }

                         else if (role == "Pharmacist" )
                         {
                             Pharmacist pharm = new Pharmacist();
                             pharm.Show();
                             this.Hide();
                         }
                     }

                     else
                     {
                         MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
             }

        */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}