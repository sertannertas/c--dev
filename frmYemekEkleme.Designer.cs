namespace YemekTarifi
{
    partial class frmYemekEkleme
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
            this.btnYemekEklemeYemekEkle = new System.Windows.Forms.Button();
            this.lblYemekEklemeYemekAdi = new System.Windows.Forms.Label();
            this.lblYemekEklemeMalzemeler = new System.Windows.Forms.Label();
            this.txtYemekEklemeMalzemeler = new System.Windows.Forms.TextBox();
            this.btnYemekEkleMalzemeEkle = new System.Windows.Forms.Button();
            this.txtYemekEklemeYemekAdi = new System.Windows.Forms.TextBox();
            this.lbYemeklerVeMalzemeler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYemekEklemeYemekEkle
            // 
            this.btnYemekEklemeYemekEkle.BackColor = System.Drawing.Color.Tomato;
            this.btnYemekEklemeYemekEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYemekEklemeYemekEkle.Location = new System.Drawing.Point(303, 157);
            this.btnYemekEklemeYemekEkle.Name = "btnYemekEklemeYemekEkle";
            this.btnYemekEklemeYemekEkle.Size = new System.Drawing.Size(379, 23);
            this.btnYemekEklemeYemekEkle.TabIndex = 5;
            this.btnYemekEklemeYemekEkle.Text = "Yemeği Ekle";
            this.btnYemekEklemeYemekEkle.UseVisualStyleBackColor = false;
            this.btnYemekEklemeYemekEkle.Click += new System.EventHandler(this.btnYemekEklemeYemekEkle_Click);
            // 
            // lblYemekEklemeYemekAdi
            // 
            this.lblYemekEklemeYemekAdi.AutoSize = true;
            this.lblYemekEklemeYemekAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblYemekEklemeYemekAdi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYemekEklemeYemekAdi.Location = new System.Drawing.Point(206, 138);
            this.lblYemekEklemeYemekAdi.Name = "lblYemekEklemeYemekAdi";
            this.lblYemekEklemeYemekAdi.Size = new System.Drawing.Size(91, 18);
            this.lblYemekEklemeYemekAdi.TabIndex = 6;
            this.lblYemekEklemeYemekAdi.Text = "Yemek Adı\r\n";
            // 
            // lblYemekEklemeMalzemeler
            // 
            this.lblYemekEklemeMalzemeler.AutoSize = true;
            this.lblYemekEklemeMalzemeler.BackColor = System.Drawing.Color.Transparent;
            this.lblYemekEklemeMalzemeler.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYemekEklemeMalzemeler.Location = new System.Drawing.Point(199, 192);
            this.lblYemekEklemeMalzemeler.Name = "lblYemekEklemeMalzemeler";
            this.lblYemekEklemeMalzemeler.Size = new System.Drawing.Size(98, 18);
            this.lblYemekEklemeMalzemeler.TabIndex = 7;
            this.lblYemekEklemeMalzemeler.Text = "Malzemeler";
            // 
            // txtYemekEklemeMalzemeler
            // 
            this.txtYemekEklemeMalzemeler.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtYemekEklemeMalzemeler.Location = new System.Drawing.Point(303, 187);
            this.txtYemekEklemeMalzemeler.Name = "txtYemekEklemeMalzemeler";
            this.txtYemekEklemeMalzemeler.Size = new System.Drawing.Size(379, 23);
            this.txtYemekEklemeMalzemeler.TabIndex = 8;
            // 
            // btnYemekEkleMalzemeEkle
            // 
            this.btnYemekEkleMalzemeEkle.BackColor = System.Drawing.Color.Tomato;
            this.btnYemekEkleMalzemeEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYemekEkleMalzemeEkle.Location = new System.Drawing.Point(303, 216);
            this.btnYemekEkleMalzemeEkle.Name = "btnYemekEkleMalzemeEkle";
            this.btnYemekEkleMalzemeEkle.Size = new System.Drawing.Size(379, 23);
            this.btnYemekEkleMalzemeEkle.TabIndex = 9;
            this.btnYemekEkleMalzemeEkle.Text = "Malzemeyi Ekle";
            this.btnYemekEkleMalzemeEkle.UseVisualStyleBackColor = false;
            this.btnYemekEkleMalzemeEkle.Click += new System.EventHandler(this.btnYemekEkleMalzemeEkle_Click);
            // 
            // txtYemekEklemeYemekAdi
            // 
            this.txtYemekEklemeYemekAdi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtYemekEklemeYemekAdi.Location = new System.Drawing.Point(303, 133);
            this.txtYemekEklemeYemekAdi.Name = "txtYemekEklemeYemekAdi";
            this.txtYemekEklemeYemekAdi.Size = new System.Drawing.Size(379, 23);
            this.txtYemekEklemeYemekAdi.TabIndex = 11;
            // 
            // lbYemeklerVeMalzemeler
            // 
            this.lbYemeklerVeMalzemeler.FormattingEnabled = true;
            this.lbYemeklerVeMalzemeler.ItemHeight = 15;
            this.lbYemeklerVeMalzemeler.Location = new System.Drawing.Point(303, 245);
            this.lbYemeklerVeMalzemeler.Name = "lbYemeklerVeMalzemeler";
            this.lbYemeklerVeMalzemeler.Size = new System.Drawing.Size(379, 199);
            this.lbYemeklerVeMalzemeler.TabIndex = 12;
            // 
            // frmYemekEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::YemekTarifi.Properties.Resources._1000_F_105594325_Fr2aMw6NpKtsJlYBg2l6JPCM67sWWfIb;
            this.ClientSize = new System.Drawing.Size(755, 544);
            this.Controls.Add(this.lbYemeklerVeMalzemeler);
            this.Controls.Add(this.txtYemekEklemeYemekAdi);
            this.Controls.Add(this.btnYemekEkleMalzemeEkle);
            this.Controls.Add(this.txtYemekEklemeMalzemeler);
            this.Controls.Add(this.lblYemekEklemeMalzemeler);
            this.Controls.Add(this.lblYemekEklemeYemekAdi);
            this.Controls.Add(this.btnYemekEklemeYemekEkle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmYemekEkleme";
            this.Text = "Yemek Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYemekEklemeYemekEkle;
        private System.Windows.Forms.Label lblYemekEklemeYemekAdi;
        private System.Windows.Forms.Label lblYemekEklemeMalzemeler;
        private System.Windows.Forms.TextBox txtYemekEklemeMalzemeler;
        private System.Windows.Forms.Button btnYemekEkleMalzemeEkle;
        private System.Windows.Forms.TextBox txtYemekEklemeYemekAdi;
        private System.Windows.Forms.ListBox lbYemeklerVeMalzemeler;
    }
}