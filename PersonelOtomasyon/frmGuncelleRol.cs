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
    public partial class frmGuncelleRol : Form
    {
        public int RolID { get; set; }
        public string RolAdi { get; set; }
        public frmGuncelleRol()
        {
            InitializeComponent();
        }

        private void frmGuncelleRol_Load(object sender, EventArgs e)
        {

        }

        private void btn_depGuncelle_Click(object sender, EventArgs e)
        {

            // txtRolID ve txtRolAdi alanlarındaki bilgileri alıyoruz
            int rolID = int.Parse(txtRolID.Text); // RolID genellikle sayısal bir değerdir
            string rolAdi = txtRolAdi.Text;

            // Veritabanı güncelleme işlemini gerçekleştirmek için
            try
            {
                // VeriTabanı sınıfından bir örnek oluştur
                VeriTabanı veriTabanı = new VeriTabanı();

                // Güncelleme işlemini gerçekleştir
                bool isUpdated = veriTabanı.KayitGuncelleRol(rolID, rolAdi);

                if (isUpdated)
                {
                    MessageBox.Show("Rol başarıyla güncellendi.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu.", "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
