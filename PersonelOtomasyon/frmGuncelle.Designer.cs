namespace PersonelOtomasyon
{
    partial class frmGuncelle
    {
        //...

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuncelle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_depGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Acıklama = new System.Windows.Forms.TextBox();
            this.txt_Departman = new System.Windows.Forms.TextBox();
            this.txt_DepartmanID = new System.Windows.Forms.TextBox();
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
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn_iptal);
            this.panel1.Controls.Add(this.btn_depGuncelle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_Acıklama);
            this.panel1.Controls.Add(this.txt_Departman);
            this.panel1.Controls.Add(this.txt_DepartmanID);
            this.panel1.Controls.Add(this.lbl_Guncelleme_acıklama);
            this.panel1.Controls.Add(this.lbl_Guncelle_Departman);
            this.panel1.Controls.Add(this.lbl_Guncelle_DepartmanID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 602);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.IndianRed;
            this.btn_iptal.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.Location = new System.Drawing.Point(41, 510);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(202, 56);
            this.btn_iptal.TabIndex = 28;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_depGuncelle
            // 
            this.btn_depGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btn_depGuncelle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_depGuncelle.Location = new System.Drawing.Point(269, 510);
            this.btn_depGuncelle.Name = "btn_depGuncelle";
            this.btn_depGuncelle.Size = new System.Drawing.Size(204, 56);
            this.btn_depGuncelle.TabIndex = 27;
            this.btn_depGuncelle.Text = "Güncelle";
            this.btn_depGuncelle.UseVisualStyleBackColor = false;
            this.btn_depGuncelle.Click += new System.EventHandler(this.btn_depGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_Acıklama
            // 
            this.txt_Acıklama.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Acıklama.Location = new System.Drawing.Point(269, 352);
            this.txt_Acıklama.Multiline = true;
            this.txt_Acıklama.Name = "txt_Acıklama";
            this.txt_Acıklama.Size = new System.Drawing.Size(202, 152);
            this.txt_Acıklama.TabIndex = 1;
            this.txt_Acıklama.TextChanged += new System.EventHandler(this.txt_Acıklama_TextChanged);
            // 
            // txt_Departman
            // 
            this.txt_Departman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Departman.Location = new System.Drawing.Point(269, 303);
            this.txt_Departman.Name = "txt_Departman";
            this.txt_Departman.Size = new System.Drawing.Size(205, 28);
            this.txt_Departman.TabIndex = 1;
            this.txt_Departman.TextChanged += new System.EventHandler(this.txt_Departman_TextChanged);
            // 
            // txt_DepartmanID
            // 
            this.txt_DepartmanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DepartmanID.Location = new System.Drawing.Point(269, 250);
            this.txt_DepartmanID.Name = "txt_DepartmanID";
            this.txt_DepartmanID.ReadOnly = true;
            this.txt_DepartmanID.Size = new System.Drawing.Size(205, 28);
            this.txt_DepartmanID.TabIndex = 1;
            this.txt_DepartmanID.TextChanged += new System.EventHandler(this.txt_DepartmanID_TextChanged);
            // 
            // lbl_Guncelleme_acıklama
            // 
            this.lbl_Guncelleme_acıklama.AutoSize = true;
            this.lbl_Guncelleme_acıklama.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelleme_acıklama.Location = new System.Drawing.Point(60, 340);
            this.lbl_Guncelleme_acıklama.Name = "lbl_Guncelleme_acıklama";
            this.lbl_Guncelleme_acıklama.Size = new System.Drawing.Size(139, 35);
            this.lbl_Guncelleme_acıklama.TabIndex = 0;
            this.lbl_Guncelleme_acıklama.Text = "Açıklama :";
            this.lbl_Guncelleme_acıklama.Click += new System.EventHandler(this.lbl_Guncelleme_acıklama_Click);
            // 
            // lbl_Guncelle_Departman
            // 
            this.lbl_Guncelle_Departman.AutoSize = true;
            this.lbl_Guncelle_Departman.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelle_Departman.Location = new System.Drawing.Point(60, 296);
            this.lbl_Guncelle_Departman.Name = "lbl_Guncelle_Departman";
            this.lbl_Guncelle_Departman.Size = new System.Drawing.Size(172, 35);
            this.lbl_Guncelle_Departman.TabIndex = 0;
            this.lbl_Guncelle_Departman.Text = "Departman  :";
            this.lbl_Guncelle_Departman.Click += new System.EventHandler(this.lbl_Guncelle_Departman_Click);
            // 
            // lbl_Guncelle_DepartmanID
            // 
            this.lbl_Guncelle_DepartmanID.AutoSize = true;
            this.lbl_Guncelle_DepartmanID.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelle_DepartmanID.Location = new System.Drawing.Point(60, 246);
            this.lbl_Guncelle_DepartmanID.Name = "lbl_Guncelle_DepartmanID";
            this.lbl_Guncelle_DepartmanID.Size = new System.Drawing.Size(199, 35);
            this.lbl_Guncelle_DepartmanID.TabIndex = 0;
            this.lbl_Guncelle_DepartmanID.Text = "Departman ID :";
            this.lbl_Guncelle_DepartmanID.Click += new System.EventHandler(this.lbl_Guncelle_DepartmanID_Click);
            // 
            // frmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(571, 602);
            this.Controls.Add(this.panel1);
            this.Name = "frmGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Güncelle";
            this.Load += new System.EventHandler(this.frmGuncelle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_Acıklama;
        public System.Windows.Forms.TextBox txt_Departman;
        public System.Windows.Forms.Label lbl_Guncelleme_acıklama;
        public System.Windows.Forms.Label lbl_Guncelle_Departman;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_depGuncelle;
        private System.Windows.Forms.Button btn_iptal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox txt_DepartmanID;
        public System.Windows.Forms.Label lbl_Guncelle_DepartmanID;
    }
}
