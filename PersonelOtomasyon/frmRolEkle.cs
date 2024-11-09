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
    public partial class frmRolEkle : Form
    {
       
        public frmRolEkle()
        {
            InitializeComponent();
          
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni rol bilgilerini al
                string rolAdi = txtRolAdi.Text;

                // Veri tabanı işlemlerini gerçekleştirin
                VeriTabanı veriTabanı = new VeriTabanı();

                // Yeni rol objesi oluştur
                Roller yeniRol = new Roller
                {
                    RolAdi = rolAdi
                };

                // Roller tablosuna ekle
                bool isKayitBasarili = veriTabanı.KayitEkleRol(yeniRol);

                // Eğer kayıt başarılıysa
                if (isKayitBasarili)
                {
                    // Başarılı mesajı göster
                    MessageBox.Show("Rol başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Formun başarı ile kapandığını belirt
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Formu kapat
                }
                else
                {
                    // Eğer kayıt başarısızsa hata mesajı göster
                    MessageBox.Show("Rol eklenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı göster
                MessageBox.Show($"Kayıt sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            // İptal mesajını göster
            MessageBox.Show("İşlem iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formu kapat
            this.Close();
        }

        private void frmRolEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
