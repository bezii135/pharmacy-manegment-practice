namespace pharmacy_manegment_practice.Pharmasict_Folder
{
    partial class Pharmacist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnmedicinevaliditycheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddmedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnmodifymedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnviewmedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btndashbaord = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_ValidtyCheck1 = new pharmacy_manegment_practice.Pharmasict_Folder.UC_ValidtyCheck();
            this.uC_UpdateMedicine1 = new pharmacy_manegment_practice.Pharmasict_Folder.UC_UpdateMedicine();
            this.uC_VewMedicine1 = new pharmacy_manegment_practice.Pharmasict_Folder.UC_VewMedicine();
            this.uC_P_AddMedicine1 = new pharmacy_manegment_practice.Pharmasict_Folder.UC_P_AddMedicine();
            this.uC_P_Dashboard1 = new pharmacy_manegment_practice.Pharmasict_Folder.UC_P_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnmedicinevaliditycheck);
            this.panel1.Controls.Add(this.btnaddmedicine);
            this.panel1.Controls.Add(this.btnmodifymedicine);
            this.panel1.Controls.Add(this.btnviewmedicine);
            this.panel1.Controls.Add(this.btndashbaord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 782);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnlogout
            // 
            this.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogout.FillColor = System.Drawing.Color.Transparent;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnlogout.HoverState.FillColor = System.Drawing.Color.Peru;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageSize = new System.Drawing.Size(35, 35);
            this.btnlogout.Location = new System.Drawing.Point(3, 632);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(324, 56);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // btnmedicinevaliditycheck
            // 
            this.btnmedicinevaliditycheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmedicinevaliditycheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmedicinevaliditycheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmedicinevaliditycheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmedicinevaliditycheck.FillColor = System.Drawing.Color.Transparent;
            this.btnmedicinevaliditycheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmedicinevaliditycheck.ForeColor = System.Drawing.Color.White;
            this.btnmedicinevaliditycheck.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnmedicinevaliditycheck.HoverState.FillColor = System.Drawing.Color.Peru;
            this.btnmedicinevaliditycheck.Image = ((System.Drawing.Image)(resources.GetObject("btnmedicinevaliditycheck.Image")));
            this.btnmedicinevaliditycheck.ImageSize = new System.Drawing.Size(35, 35);
            this.btnmedicinevaliditycheck.Location = new System.Drawing.Point(3, 552);
            this.btnmedicinevaliditycheck.Name = "btnmedicinevaliditycheck";
            this.btnmedicinevaliditycheck.Size = new System.Drawing.Size(324, 56);
            this.btnmedicinevaliditycheck.TabIndex = 6;
            this.btnmedicinevaliditycheck.Text = "Medicine Validity Check";
            this.btnmedicinevaliditycheck.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnaddmedicine
            // 
            this.btnaddmedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddmedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddmedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddmedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddmedicine.FillColor = System.Drawing.Color.Transparent;
            this.btnaddmedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnaddmedicine.ForeColor = System.Drawing.Color.White;
            this.btnaddmedicine.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnaddmedicine.HoverState.FillColor = System.Drawing.Color.Peru;
            this.btnaddmedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnaddmedicine.Image")));
            this.btnaddmedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnaddmedicine.Location = new System.Drawing.Point(3, 315);
            this.btnaddmedicine.Name = "btnaddmedicine";
            this.btnaddmedicine.Size = new System.Drawing.Size(324, 56);
            this.btnaddmedicine.TabIndex = 5;
            this.btnaddmedicine.Text = "Add Medicine";
            this.btnaddmedicine.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnmodifymedicine
            // 
            this.btnmodifymedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmodifymedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmodifymedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmodifymedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmodifymedicine.FillColor = System.Drawing.Color.Transparent;
            this.btnmodifymedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmodifymedicine.ForeColor = System.Drawing.Color.White;
            this.btnmodifymedicine.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnmodifymedicine.HoverState.FillColor = System.Drawing.Color.Peru;
            this.btnmodifymedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnmodifymedicine.Image")));
            this.btnmodifymedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnmodifymedicine.Location = new System.Drawing.Point(3, 473);
            this.btnmodifymedicine.Name = "btnmodifymedicine";
            this.btnmodifymedicine.Size = new System.Drawing.Size(324, 56);
            this.btnmodifymedicine.TabIndex = 4;
            this.btnmodifymedicine.Text = "Modify Medicine";
            this.btnmodifymedicine.Click += new System.EventHandler(this.btnmodifymedicine_Click);
            // 
            // btnviewmedicine
            // 
            this.btnviewmedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnviewmedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnviewmedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnviewmedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnviewmedicine.FillColor = System.Drawing.Color.Transparent;
            this.btnviewmedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnviewmedicine.ForeColor = System.Drawing.Color.White;
            this.btnviewmedicine.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnviewmedicine.HoverState.FillColor = System.Drawing.Color.Peru;
            this.btnviewmedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnviewmedicine.Image")));
            this.btnviewmedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnviewmedicine.Location = new System.Drawing.Point(3, 394);
            this.btnviewmedicine.Name = "btnviewmedicine";
            this.btnviewmedicine.Size = new System.Drawing.Size(324, 56);
            this.btnviewmedicine.TabIndex = 3;
            this.btnviewmedicine.Text = "View Medicine";
            this.btnviewmedicine.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btndashbaord
            // 
            this.btndashbaord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndashbaord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndashbaord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndashbaord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndashbaord.FillColor = System.Drawing.Color.Transparent;
            this.btndashbaord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndashbaord.ForeColor = System.Drawing.Color.White;
            this.btndashbaord.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btndashbaord.HoverState.FillColor = System.Drawing.Color.Peru;
            this.btndashbaord.Image = ((System.Drawing.Image)(resources.GetObject("btndashbaord.Image")));
            this.btndashbaord.ImageSize = new System.Drawing.Size(35, 35);
            this.btndashbaord.Location = new System.Drawing.Point(3, 236);
            this.btndashbaord.Name = "btndashbaord";
            this.btndashbaord.Size = new System.Drawing.Size(324, 56);
            this.btndashbaord.TabIndex = 2;
            this.btndashbaord.Text = "Dashboard";
            this.btndashbaord.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_ValidtyCheck1);
            this.panel2.Controls.Add(this.uC_UpdateMedicine1);
            this.panel2.Controls.Add(this.uC_VewMedicine1);
            this.panel2.Controls.Add(this.uC_P_AddMedicine1);
            this.panel2.Controls.Add(this.uC_P_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(325, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 770);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uC_ValidtyCheck1
            // 
            this.uC_ValidtyCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_ValidtyCheck1.Name = "uC_ValidtyCheck1";
            this.uC_ValidtyCheck1.Size = new System.Drawing.Size(1380, 962);
            this.uC_ValidtyCheck1.TabIndex = 4;
            // 
            // uC_UpdateMedicine1
            // 
            this.uC_UpdateMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_UpdateMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateMedicine1.Name = "uC_UpdateMedicine1";
            this.uC_UpdateMedicine1.Size = new System.Drawing.Size(1380, 962);
            this.uC_UpdateMedicine1.TabIndex = 3;
            // 
            // uC_VewMedicine1
            // 
            this.uC_VewMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_VewMedicine1.Name = "uC_VewMedicine1";
            this.uC_VewMedicine1.Size = new System.Drawing.Size(1380, 962);
            this.uC_VewMedicine1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1380, 962);
            this.uC_P_AddMedicine1.TabIndex = 1;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(1380, 962);
            this.uC_P_Dashboard1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 782);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btnmedicinevaliditycheck;
        private Guna.UI2.WinForms.Guna2Button btnaddmedicine;
        private Guna.UI2.WinForms.Guna2Button btnmodifymedicine;
        private Guna.UI2.WinForms.Guna2Button btnviewmedicine;
        private Guna.UI2.WinForms.Guna2Button btndashbaord;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UC_P_AddMedicine uC_P_AddMedicine1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UC_VewMedicine uC_VewMedicine1;
        private UC_UpdateMedicine uC_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private UC_ValidtyCheck uC_ValidtyCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
    }
}