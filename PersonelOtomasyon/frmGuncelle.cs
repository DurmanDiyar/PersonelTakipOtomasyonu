using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class frmGuncelle : Form
    {
        public int DepartmanID { get; set; }
        public string Departman { get; set; }
        public string Aciklama { get; set; }

        public frmGuncelle(int departmanID, string departmanAdi, string aciklama, int rolID)
        {
            InitializeComponent();

            // Argümanları kullanarak form üzerindeki kontrolleri güncelleyin
            txt_DepartmanID.Text = departmanID.ToString();
            txt_Departman.Text = departmanAdi;
            txt_Acıklama.Text = aciklama;
            //txt_RolID.Text = rolID.ToString();
        }
        public frmGuncelle()
        {
           
            InitializeComponent();
        }

        // Constructor ile formu veri ile doldur
        public frmGuncelle(int departmanID, string departman, string aciklama) : this()
        {
            DepartmanID = departmanID;
            Departman = departman;
            Aciklama = aciklama;
        }

        private void frmGuncelle_Load(object sender, EventArgs e)
        {
            // Bilgileri form elemanlarına ata
            txt_DepartmanID.Text = DepartmanID.ToString();
            txt_Departman.Text = Departman;
            txt_Acıklama.Text = Aciklama;
        }

        private void btn_depGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş bilgileri al
            DepartmanID = int.Parse(txt_DepartmanID.Text);
            Departman = txt_Departman.Text;
            Aciklama = txt_Acıklama.Text;

            // Formu kapat ve OK sonucu döndür
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txt_Acıklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Departman_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DepartmanID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Guncelleme_acıklama_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Guncelle_Departman_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Guncelle_DepartmanID_Click(object sender, EventArgs e)
        {

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İptal etmek istiyor musunuz?", "İptal Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Formu kapat
                this.Close();

                // Ekranda işlem iptal edildi mesajını göster
                MessageBox.Show("İşlem iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // frmDepartmanlar formuna geri dön
                if (Application.OpenForms["frmDepartmanlar"] is frmDepartmanlar frmDepartmanlar)
                {
                    frmDepartmanlar.BringToFront();
                }
            }
            // Kullanıcı "Hayır" seçeneğini seçerse, hiçbir işlem yapılmaz ve formda kalır
        }
    }

}
