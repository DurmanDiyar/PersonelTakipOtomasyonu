namespace PersonelOtomasyon
{
    partial class frmDepartmanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanEkle));
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_acıklama = new System.Windows.Forms.TextBox();
            this.txt_departman = new System.Windows.Forms.TextBox();
            this.lbl_depAcıklama = new System.Windows.Forms.Label();
            this.lbl_Departman = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_depKaydet = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_AcıklamaEkle = new System.Windows.Forms.TextBox();
            this.txt_DepartmanEkle = new System.Windows.Forms.TextBox();
            this.lbl_Guncelleme_acıklama = new System.Windows.Forms.Label();
            this.lbl_Guncelle_Departman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(196, 350);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(143, 47);
            this.btn_Kaydet.TabIndex = 34;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // txt_acıklama
            // 
            this.txt_acıklama.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_acıklama.Location = new System.Drawing.Point(162, 247);
            this.txt_acıklama.Multiline = true;
            this.txt_acıklama.Name = "txt_acıklama";
            this.txt_acıklama.Size = new System.Drawing.Size(221, 79);
            this.txt_acıklama.TabIndex = 29;
            // 
            // txt_departman
            // 
            this.txt_departman.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_departman.Location = new System.Drawing.Point(162, 204);
            this.txt_departman.Name = "txt_departman";
            this.txt_departman.Size = new System.Drawing.Size(221, 23);
            this.txt_departman.TabIndex = 28;
            // 
            // lbl_depAcıklama
            // 
            this.lbl_depAcıklama.AutoSize = true;
            this.lbl_depAcıklama.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_depAcıklama.Location = new System.Drawing.Point(11, 233);
            this.lbl_depAcıklama.Name = "lbl_depAcıklama";
            this.lbl_depAcıklama.Size = new System.Drawing.Size(99, 24);
            this.lbl_depAcıklama.TabIndex = 30;
            this.lbl_depAcıklama.Text = "Açıklama :";
            // 
            // lbl_Departman
            // 
            this.lbl_Departman.AutoSize = true;
            this.lbl_Departman.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Departman.Location = new System.Drawing.Point(11, 200);
            this.lbl_Departman.Name = "lbl_Departman";
            this.lbl_Departman.Size = new System.Drawing.Size(118, 24);
            this.lbl_Departman.TabIndex = 31;
            this.lbl_Departman.Text = "Departman :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_depKaydet);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txt_AcıklamaEkle);
            this.panel1.Controls.Add(this.txt_DepartmanEkle);
            this.panel1.Controls.Add(this.lbl_Guncelleme_acıklama);
            this.panel1.Controls.Add(this.lbl_Guncelle_Departman);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 456);
            this.panel1.TabIndex = 35;
            // 
            // btn_depKaydet
            // 
            this.btn_depKaydet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_depKaydet.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_depKaydet.Location = new System.Drawing.Point(227, 373);
            this.btn_depKaydet.Name = "btn_depKaydet";
            this.btn_depKaydet.Size = new System.Drawing.Size(204, 56);
            this.btn_depKaydet.TabIndex = 27;
            this.btn_depKaydet.Text = "Kaydet";
            this.btn_depKaydet.UseVisualStyleBackColor = false;
            this.btn_depKaydet.Click += new System.EventHandler(this.btn_depKaydet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(171, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // txt_AcıklamaEkle
            // 
            this.txt_AcıklamaEkle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AcıklamaEkle.Location = new System.Drawing.Point(227, 203);
            this.txt_AcıklamaEkle.Multiline = true;
            this.txt_AcıklamaEkle.Name = "txt_AcıklamaEkle";
            this.txt_AcıklamaEkle.Size = new System.Drawing.Size(202, 140);
            this.txt_AcıklamaEkle.TabIndex = 1;
            // 
            // txt_DepartmanEkle
            // 
            this.txt_DepartmanEkle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DepartmanEkle.Location = new System.Drawing.Point(224, 159);
            this.txt_DepartmanEkle.Name = "txt_DepartmanEkle";
            this.txt_DepartmanEkle.Size = new System.Drawing.Size(205, 36);
            this.txt_DepartmanEkle.TabIndex = 1;
            // 
            // lbl_Guncelleme_acıklama
            // 
            this.lbl_Guncelleme_acıklama.AutoSize = true;
            this.lbl_Guncelleme_acıklama.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelleme_acıklama.Location = new System.Drawing.Point(68, 203);
            this.lbl_Guncelleme_acıklama.Name = "lbl_Guncelleme_acıklama";
            this.lbl_Guncelleme_acıklama.Size = new System.Drawing.Size(117, 28);
            this.lbl_Guncelleme_acıklama.TabIndex = 0;
            this.lbl_Guncelleme_acıklama.Text = "Açıklama :";
            // 
            // lbl_Guncelle_Departman
            // 
            this.lbl_Guncelle_Departman.AutoSize = true;
            this.lbl_Guncelle_Departman.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelle_Departman.ForeColor = System.Drawing.Color.Black;
            this.lbl_Guncelle_Departman.Location = new System.Drawing.Point(41, 159);
            this.lbl_Guncelle_Departman.Name = "lbl_Guncelle_Departman";
            this.lbl_Guncelle_Departman.Size = new System.Drawing.Size(144, 28);
            this.lbl_Guncelle_Departman.TabIndex = 0;
            this.lbl_Guncelle_Departman.Text = "Departman  :";
            // 
            // frmDepartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(506, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_acıklama);
            this.Controls.Add(this.txt_departman);
            this.Controls.Add(this.lbl_depAcıklama);
            this.Controls.Add(this.lbl_Departman);
            this.Name = "frmDepartmanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Ekle";
            this.Load += new System.EventHandler(this.frmDepartmanEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_acıklama;
        private System.Windows.Forms.TextBox txt_departman;
        private System.Windows.Forms.Label lbl_depAcıklama;
        private System.Windows.Forms.Label lbl_Departman;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_depKaydet;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox txt_AcıklamaEkle;
        public System.Windows.Forms.TextBox txt_DepartmanEkle;
        public System.Windows.Forms.Label lbl_Guncelleme_acıklama;
        public System.Windows.Forms.Label lbl_Guncelle_Departman;
    }
}