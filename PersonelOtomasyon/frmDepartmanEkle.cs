using DocumentFormat.OpenXml.Bibliography;
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
    public partial class frmDepartmanEkle : Form
    {
        public frmDepartmanEkle()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

        }

        private void btn_depKaydet_Click(object sender, EventArgs e)
        {
            VeriTabanı vt = new VeriTabanı();
            // Verileri al
            string departmanAdi = txt_DepartmanEkle.Text;
            string acıklama = txt_AcıklamaEkle.Text;

            // Yeni departman nesnesi oluştur ve veritabanına ekle
            Departmanlar yeniDepartman = new Departmanlar
            {
                DepartmanAdi = departmanAdi,
                Aciklama = acıklama
            };

            vt.KayitEkleDepartman(yeniDepartman);

            // Kullanıcıya başarı mesajı göster
            MessageBox.Show("Departman başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // DialogResult'ı OK yaparak formu kapat
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmDepartmanEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
