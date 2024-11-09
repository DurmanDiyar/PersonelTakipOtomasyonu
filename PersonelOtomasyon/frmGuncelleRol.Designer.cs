namespace PersonelOtomasyon
{
    partial class frmGuncelleRol
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtRolAdi = new System.Windows.Forms.TextBox();
            this.txtRolID = new System.Windows.Forms.TextBox();
            this.lbl_Guncelle_Departman = new System.Windows.Forms.Label();
            this.lbl_Guncelle_DepartmanID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btn_iptal);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.txtRolAdi);
            this.panel1.Controls.Add(this.txtRolID);
            this.panel1.Controls.Add(this.lbl_Guncelle_Departman);
            this.panel1.Controls.Add(this.lbl_Guncelle_DepartmanID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 273);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.IndianRed;
            this.btn_iptal.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.Location = new System.Drawing.Point(248, 172);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(111, 56);
            this.btn_iptal.TabIndex = 4;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnGuncelle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(388, 172);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(126, 56);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btn_depGuncelle_Click);
            // 
            // txtRolAdi
            // 
            this.txtRolAdi.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRolAdi.Location = new System.Drawing.Point(309, 115);
            this.txtRolAdi.Name = "txtRolAdi";
            this.txtRolAdi.Size = new System.Drawing.Size(205, 29);
            this.txtRolAdi.TabIndex = 2;
            // 
            // txtRolID
            // 
            this.txtRolID.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRolID.Location = new System.Drawing.Point(309, 62);
            this.txtRolID.Name = "txtRolID";
            this.txtRolID.Size = new System.Drawing.Size(115, 29);
            this.txtRolID.TabIndex = 1;
            // 
            // lbl_Guncelle_Departman
            // 
            this.lbl_Guncelle_Departman.AutoSize = true;
            this.lbl_Guncelle_Departman.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelle_Departman.Location = new System.Drawing.Point(162, 108);
            this.lbl_Guncelle_Departman.Name = "lbl_Guncelle_Departman";
            this.lbl_Guncelle_Departman.Size = new System.Drawing.Size(121, 35);
            this.lbl_Guncelle_Departman.TabIndex = 0;
            this.lbl_Guncelle_Departman.Text = "Rol Adi  :";
            // 
            // lbl_Guncelle_DepartmanID
            // 
            this.lbl_Guncelle_DepartmanID.AutoSize = true;
            this.lbl_Guncelle_DepartmanID.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Guncelle_DepartmanID.Location = new System.Drawing.Point(181, 55);
            this.lbl_Guncelle_DepartmanID.Name = "lbl_Guncelle_DepartmanID";
            this.lbl_Guncelle_DepartmanID.Size = new System.Drawing.Size(102, 35);
            this.lbl_Guncelle_DepartmanID.TabIndex = 0;
            this.lbl_Guncelle_DepartmanID.Text = "Rol ID :";
            // 
            // frmGuncelleRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 273);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGuncelleRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol Güncelle";
            this.Load += new System.EventHandler(this.frmGuncelleRol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_iptal;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.TextBox txtRolAdi;
        public System.Windows.Forms.TextBox txtRolID;
        public System.Windows.Forms.Label lbl_Guncelle_Departman;
        public System.Windows.Forms.Label lbl_Guncelle_DepartmanID;
    }
}