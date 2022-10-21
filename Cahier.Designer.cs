namespace pharmacy_manegment_practice
{
    partial class Cahier
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Sell_Medicine1 = new pharmacy_manegment_practice.Pharmasict_Folder.UC_Sell_Medicine();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uC_Sell_Medicine1
            // 
            this.uC_Sell_Medicine1.BackColor = System.Drawing.Color.White;
            this.uC_Sell_Medicine1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uC_Sell_Medicine1.Location = new System.Drawing.Point(2, 1);
            this.uC_Sell_Medicine1.Name = "uC_Sell_Medicine1";
            this.uC_Sell_Medicine1.Size = new System.Drawing.Size(1240, 962);
            this.uC_Sell_Medicine1.TabIndex = 0;
            // 
            // Cahier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 854);
            this.Controls.Add(this.uC_Sell_Medicine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cahier";
            this.Text = "Cahier";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Pharmasict_Folder.UC_Sell_Medicine uC_Sell_Medicine1;
    }
}