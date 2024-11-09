namespace PersonelOtomasyon
{
    partial class frmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminGiris));
            this.btn_AdminGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtadminSifre = new System.Windows.Forms.TextBox();
            this.chb_SifreGoster = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_İptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AdminGiris
            // 
            this.btn_AdminGiris.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AdminGiris.Location = new System.Drawing.Point(446, 304);
            this.btn_AdminGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AdminGiris.Name = "btn_AdminGiris";
            this.btn_AdminGiris.Size = new System.Drawing.Size(104, 30);
            this.btn_AdminGiris.TabIndex = 0;
            this.btn_AdminGiris.Text = "Giriş Yap";
            this.btn_AdminGiris.UseVisualStyleBackColor = true;
            this.btn_AdminGiris.Click += new System.EventHandler(this.btn_AdminGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(350, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(446, 158);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 34);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // txtadminSifre
            // 
            this.txtadminSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadminSifre.Location = new System.Drawing.Point(446, 200);
            this.txtadminSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadminSifre.Name = "txtadminSifre";
            this.txtadminSifre.Size = new System.Drawing.Size(200, 34);
            this.txtadminSifre.TabIndex = 5;
            this.txtadminSifre.TextChanged += new System.EventHandler(this.txt_adminSifre_TextChanged);
            // 
            // chb_SifreGoster
            // 
            this.chb_SifreGoster.AutoSize = true;
            this.chb_SifreGoster.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_SifreGoster.Location = new System.Drawing.Point(522, 235);
            this.chb_SifreGoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb_SifreGoster.Name = "chb_SifreGoster";
            this.chb_SifreGoster.Size = new System.Drawing.Size(139, 29);
            this.chb_SifreGoster.TabIndex = 7;
            this.chb_SifreGoster.Text = "Şifreyi Göster";
            this.chb_SifreGoster.UseVisualStyleBackColor = true;
            this.chb_SifreGoster.CheckedChanged += new System.EventHandler(this.chb_SifreGoster_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_İptal
            // 
            this.btn_İptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_İptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_İptal.Location = new System.Drawing.Point(557, 304);
            this.btn_İptal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_İptal.Name = "btn_İptal";
            this.btn_İptal.Size = new System.Drawing.Size(104, 30);
            this.btn_İptal.TabIndex = 0;
            this.btn_İptal.Text = "İptal";
            this.btn_İptal.UseVisualStyleBackColor = true;
            this.btn_İptal.Click += new System.EventHandler(this.btn_İptal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(280, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = " Giriş Paneli";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmAdminGiris
            // 
            this.AcceptButton = this.btn_AdminGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.CancelButton = this.btn_İptal;
            this.ClientSize = new System.Drawing.Size(761, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chb_SifreGoster);
            this.Controls.Add(this.txtadminSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_İptal);
            this.Controls.Add(this.btn_AdminGiris);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Girişler";
            this.Load += new System.EventHandler(this.frmAdminGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AdminGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtadminSifre;
        private System.Windows.Forms.CheckBox chb_SifreGoster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_İptal;
        private System.Windows.Forms.Label label3;
    }
}