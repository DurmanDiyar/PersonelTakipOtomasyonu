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
    public partial class frmGuncellePersonel : Form
    {
        public frmGuncellePersonel()
        {
            InitializeComponent();
        }
        public int PersonelID { get; set; } // PersonelID için property tanımlayın

        private void frmGuncellePersonel_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş personel bilgilerini al
            Personeller guncelPersonel = new Personeller
            {
                PersonelID = this.PersonelID,
                Adi = txtAd.Text,
                Soyadi = txtSoyad.Text,
                Telefon = mskTelefon.Text,
                Adres = txtAdres.Text,
                Email = txtEmail.Text,
                DepartmanID = Convert.ToInt32(txtDepartmanID.Text),
                Durumu = cmbDurum.SelectedItem.ToString(),
                Maasi = Convert.ToDecimal(mskMaas.Text),
                GirisTarihi = Convert.ToDateTime(txtGiris.Text),
                CikisTarihi = string.IsNullOrEmpty(txtCikis.Text) ? (DateTime?)null : Convert.ToDateTime(txtCikis.Text),
                Aciklama = txtAciklama.Text
            };

            // Veri tabanında güncelleme işlemi yap
            VeriTabanı veriTabanı = new VeriTabanı();
            veriTabanı.KayitGuncellePersonel(guncelPersonel);

            //MessageBox.Show("Personel bilgileri başarıyla güncellendi.");
            this.Close(); // Formu kapat
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
