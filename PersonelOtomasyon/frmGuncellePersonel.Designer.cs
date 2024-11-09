namespace PersonelOtomasyon
{
    partial class frmGuncellePersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuncellePersonel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.mskMaas = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.txtDepartmanID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtCikis = new System.Windows.Forms.TextBox();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Guncelleme_acıklama = new System.Windows.Forms.Label();
            this.lbl_Guncelle_Departman = new System.Windows.Forms.Label();
            this.lbl_Guncelle_DepartmanID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.mskMaas);
            this.panel1.Controls.Add(this.mskTelefon);
            this.panel1.Controls.Add(this.cmbDurum);
            this.panel1.Controls.Add(this.txtDepartmanID);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btniptal);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.txtCikis);
            this.panel1.Controls.Add(this.txtGiris);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_Guncelleme_acıklama);
            this.panel1.Controls.Add(this.lbl_Guncelle_Departman);
            this.panel1.Controls.Add(this.lbl_Guncelle_DepartmanID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 622);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 22);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ör:2020/02/02";
            // 
            // mskMaas
            // 
            this.mskMaas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskMaas.Location = new System.Drawing.Point(298, 268);
            this.mskMaas.Mask = "00000000000000000000";
            this.mskMaas.Name = "mskMaas";
            this.mskMaas.Size = new System.Drawing.Size(205, 32);
            this.mskMaas.TabIndex = 8;
            this.mskMaas.ValidatingType = typeof(int);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(298, 83);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(205, 32);
            this.mskTelefon.TabIndex = 3;
            // 
            // cmbDurum
            // 
            this.cmbDurum.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Aktif ",
            "Pasif"});
            this.cmbDurum.Location = new System.Drawing.Point(298, 231);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(205, 32);
            this.cmbDurum.TabIndex = 7;
            // 
            // txtDepartmanID
            // 
            this.txtDepartmanID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartmanID.Location = new System.Drawing.Point(298, 194);
            this.txtDepartmanID.Name = "txtDepartmanID";
            this.txtDepartmanID.Size = new System.Drawing.Size(205, 32);
            this.txtDepartmanID.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(298, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 32);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(298, 120);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(205, 32);
            this.txtAdres.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(295, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(205, 32);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(295, 9);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(205, 32);
            this.txtAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(195, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 35);
            this.label5.TabIndex = 29;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(193, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(173, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 35);
            this.label3.TabIndex = 29;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(187, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 35);
            this.label2.TabIndex = 29;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(226, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 35);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ad :";
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.Snow;
            this.btniptal.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniptal.Location = new System.Drawing.Point(110, 539);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(202, 56);
            this.btniptal.TabIndex = 28;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Snow;
            this.btnGuncelle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(463, 539);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(204, 56);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(545, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(298, 381);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(205, 152);
            this.txtAciklama.TabIndex = 11;
            // 
            // txtCikis
            // 
            this.txtCikis.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCikis.Location = new System.Drawing.Point(298, 344);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Size = new System.Drawing.Size(205, 32);
            this.txtCikis.TabIndex = 10;
            // 
            // txtGiris
            // 
            this.txtGiris.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiris.Location = new System.Drawing.Point(298, 306);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(205, 32);
            this.txtGiris.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(139, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Çıkış Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(153, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(136, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giriş Tarihi :";
            // 
            // lbl_Guncelleme_acıklama
            // 
            this.lbl_Guncelleme_acıklama.AutoSize = true;
            this.lbl_Guncelleme_acıklama.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelleme_acıklama.Location = new System.Drawing.Point(193, 256);
            this.lbl_Guncelleme_acıklama.Name = "lbl_Guncelleme_acıklama";
            this.lbl_Guncelleme_acıklama.Size = new System.Drawing.Size(99, 35);
            this.lbl_Guncelleme_acıklama.TabIndex = 0;
            this.lbl_Guncelleme_acıklama.Text = "Maaşı :";
            // 
            // lbl_Guncelle_Departman
            // 
            this.lbl_Guncelle_Departman.AutoSize = true;
            this.lbl_Guncelle_Departman.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelle_Departman.Location = new System.Drawing.Point(159, 221);
            this.lbl_Guncelle_Departman.Name = "lbl_Guncelle_Departman";
            this.lbl_Guncelle_Departman.Size = new System.Drawing.Size(133, 35);
            this.lbl_Guncelle_Departman.TabIndex = 0;
            this.lbl_Guncelle_Departman.Text = "Durumu  :";
            // 
            // lbl_Guncelle_DepartmanID
            // 
            this.lbl_Guncelle_DepartmanID.AutoSize = true;
            this.lbl_Guncelle_DepartmanID.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelle_DepartmanID.Location = new System.Drawing.Point(93, 190);
            this.lbl_Guncelle_DepartmanID.Name = "lbl_Guncelle_DepartmanID";
            this.lbl_Guncelle_DepartmanID.Size = new System.Drawing.Size(199, 35);
            this.lbl_Guncelle_DepartmanID.TabIndex = 0;
            this.lbl_Guncelle_DepartmanID.Text = "Departman ID :";
            // 
            // frmGuncellePersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 622);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuncellePersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Güncelle";
            this.Load += new System.EventHandler(this.frmGuncellePersonel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtDepartmanID;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btniptal;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtAciklama;
        public System.Windows.Forms.TextBox txtCikis;
        public System.Windows.Forms.TextBox txtGiris;
        public System.Windows.Forms.Label lbl_Guncelleme_acıklama;
        public System.Windows.Forms.Label lbl_Guncelle_Departman;
        public System.Windows.Forms.Label lbl_Guncelle_DepartmanID;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbDurum;
        public System.Windows.Forms.MaskedTextBox mskMaas;
        public System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label9;
    }
}