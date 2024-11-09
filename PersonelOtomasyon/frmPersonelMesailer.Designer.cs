namespace PersonelOtomasyon
{
    partial class frmPersonelMesailer
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
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.dataGridViewMesai = new System.Windows.Forms.DataGridView();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesaiIDAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesai)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonel.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.RowHeadersWidth = 51;
            this.dataGridViewPersonel.RowTemplate.Height = 24;
            this.dataGridViewPersonel.Size = new System.Drawing.Size(319, 495);
            this.dataGridViewPersonel.TabIndex = 0;
            this.dataGridViewPersonel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonel_CellDoubleClick);
            // 
            // dataGridViewMesai
            // 
            this.dataGridViewMesai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMesai.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewMesai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesai.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMesai.Location = new System.Drawing.Point(319, 0);
            this.dataGridViewMesai.Name = "dataGridViewMesai";
            this.dataGridViewMesai.RowHeadersWidth = 51;
            this.dataGridViewMesai.RowTemplate.Height = 24;
            this.dataGridViewMesai.Size = new System.Drawing.Size(926, 426);
            this.dataGridViewMesai.TabIndex = 1;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(849, 463);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(253, 23);
            this.lblTutar.TabIndex = 2;
            this.lblTutar.Text = "Mesai Ücreti Tutarı = 0000000";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitSayisi.Location = new System.Drawing.Point(590, 463);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(212, 23);
            this.lblKayitSayisi.TabIndex = 2;
            this.lblKayitSayisi.Text = "Toplam 0 Kayıt Listelendi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(343, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mesai ID Ara :";
            // 
            // txtMesaiIDAra
            // 
            this.txtMesaiIDAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(196)))));
            this.txtMesaiIDAra.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesaiIDAra.Location = new System.Drawing.Point(378, 468);
            this.txtMesaiIDAra.Name = "txtMesaiIDAra";
            this.txtMesaiIDAra.Size = new System.Drawing.Size(122, 25);
            this.txtMesaiIDAra.TabIndex = 3;
            this.txtMesaiIDAra.TextChanged += new System.EventHandler(this.txtMesaiIDAra_TextChanged);
            // 
            // frmPersonelMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1245, 495);
            this.Controls.Add(this.txtMesaiIDAra);
            this.Controls.Add(this.lblKayitSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.dataGridViewMesai);
            this.Controls.Add(this.dataGridViewPersonel);
            this.Name = "frmPersonelMesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonelMesailer";
            this.Load += new System.EventHandler(this.frmPersonelMesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.DataGridView dataGridViewMesai;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMesaiIDAra;
    }
}