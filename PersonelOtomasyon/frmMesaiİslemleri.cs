using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class frmMesaiİslemleri : Form
    {
        public frmMesaiİslemleri()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            // Buraya gerekli kodu ekleyebilirsin.
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Buraya gerekli kodu ekleyebilirsin.
        }

        Personeller p = new Personeller();
        Label lbl;
        VeriTabanı veriTabanı = new VeriTabanı();
        private void frmMesaiİslemleri_Load(object sender, EventArgs e)
        {
            int yil = DateTime.Now.Year;
            for (int i = yil; i >= yil - 5; --i)
            {
                cmbYıl.Items.Add(i);
            }

            p.ComboyaPersonelGetir(cmbPersonelAdSoyad);
            int yil1 = DateTime.Now.Year;
            for (int i = yil1; i >= yil1 - 5; --i)
            {
                cmbYıl2.Items.Add(i);
            }
            List<Mesailer> mesailer = veriTabanı.MesaiListele();
            dataGridView1.DataSource = mesailer;
        }

        private void cmbPersonelAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl = new Label();
            p.ComboSecilirsePersonelGetir(cmbPersonelAdSoyad, lbl);
        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int personelID = int.Parse(lbl.Text);

                // Giriş yapan kullanıcının ID'sini al
                int kullaniciID = 1; // Bu değeri oturum açmış kullanıcının ID'si olarak değiştir

                // Başlangıç tarihi ve saati
                string baslangicTarihi = dateTimeBaslangic.Value.ToString("dd/MM/yyyy");
                string baslangicSaati = mskBaslangic.Text;

                // Bitiş tarihi ve saati
                string bitisTarihi = dateTimeBitis.Value.ToString("dd/MM/yyyy");
                string bitisSaati = mskBitis.Text;

                // Başlangıç ve bitiş DateTime'larını oluştur
                string baslangicDateTime = $"{baslangicTarihi} {baslangicSaati}";
                string bitisDateTime = $"{bitisTarihi} {bitisSaati}";

                // Mesailer nesnesi oluştur
                Mesailer yeniMesai = new Mesailer
                {
                    KullaniciID = kullaniciID,
                    PersonelID = personelID,
                    BaslangicSaati = baslangicDateTime, // Format: 'dd/MM/yyyy HH:mm'
                    BitisSaati = bitisDateTime,         // Format: 'dd/MM/yyyy HH:mm'
                    MesaiSaatUcreti = Convert.ToDecimal(txtMesaiSaatUcreti.Text),
                    Tutar = Convert.ToDecimal(txtTutar.Text),
                    Donem = cmbAy.SelectedItem.ToString() + " " + cmbYıl.Text, // Format: 'Ay Yıl'
                    OdenmeDurumu = "Ödenmedi", // Başlangıçta "Ödenmedi" olarak belirliyoruz
                    Tarih = DateTime.Now, // Tarih, DateTime türündeyse DateTime.Now kullanılmalı
                    Aciklama = txtAciklama.Text
                };

                // Veritabanı bağlantısını başlat
                using (SqlConnection conn = new SqlConnection("Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True"))
                {
                    conn.Open();

                    // INSERT sorgusu
                    string query = "INSERT INTO tblMesailerr (KullaniciID, PersonelID, BaslangicSaati, BitisSaati, MesaiSaatUcreti, Tutar, Donem, OdenmeDurumu, Tarih, Aciklama) " +
                                   "VALUES (@KullaniciID, @PersonelID, @BaslangicSaati, @BitisSaati, @MesaiSaatUcreti, @Tutar, @Donem, @OdenmeDurumu, @Tarih, @Aciklama)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciID", yeniMesai.KullaniciID);
                        cmd.Parameters.AddWithValue("@PersonelID", yeniMesai.PersonelID);
                        cmd.Parameters.AddWithValue("@BaslangicSaati", yeniMesai.BaslangicSaati);
                        cmd.Parameters.AddWithValue("@BitisSaati", yeniMesai.BitisSaati);
                        cmd.Parameters.AddWithValue("@MesaiSaatUcreti", yeniMesai.MesaiSaatUcreti);
                        cmd.Parameters.AddWithValue("@Tutar", yeniMesai.Tutar);
                        cmd.Parameters.AddWithValue("@Donem", yeniMesai.Donem); // Dönem formatı: 'Ay Yıl'
                        cmd.Parameters.AddWithValue("@OdenmeDurumu", yeniMesai.OdenmeDurumu);
                        cmd.Parameters.AddWithValue("@Tarih", yeniMesai.Tarih); // DateTime türündeki veriyi doğrudan kullanın
                        cmd.Parameters.AddWithValue("@Aciklama", yeniMesai.Aciklama);

                        cmd.ExecuteNonQuery();
                    }
                }

                List<Mesailer> mesailer = veriTabanı.MesaiListele();
                dataGridView1.DataSource = mesailer;
                MessageBox.Show("Mesai başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ClearControls(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesai eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // ClearControls(this);
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Tarih ve saat bilgilerini al
                string baslangic = dateTimeBaslangic.Text + " " + mskBaslangic.Text;
                string bitis = dateTimeBitis.Text + " " + mskBitis.Text;

                // Tarih ve saat farkını hesapla
                TimeSpan saatFarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);

                // Mesai saat ücreti ve toplam tutarı hesapla
                double mesaiSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatFarki.TotalHours * mesaiSaatUcreti;

                // Tutarı ilgili TextBox'a yazdır
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir saat ve ücret değeri girin.", "Geçersiz Girdi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Diğer tüm beklenmeyen hatalar için genel bir hata mesajı göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbYıl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void txtTutar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // TextBox ve ComboBox'lara hücre verilerini atama
                txtMesaiID2.Text = row.Cells["MesaiID"].Value?.ToString();
                txtPersonelID2.Text = row.Cells["PersonelID"].Value?.ToString();
                txtMesaiUcreti2.Text = row.Cells["MesaiSaatUcreti"].Value?.ToString();
                txtAciklama2.Text = row.Cells["Aciklama"].Value?.ToString();
                txtTutar2.Text = row.Cells["Tutar"].Value?.ToString();
                cmbOdeme.Text = row.Cells["OdenmeDurumu"].Value?.ToString();

                // Tarih ve saat bilgilerini al
                string baslangicStr = row.Cells["BaslangicSaati"].Value?.ToString();
                string bitisStr = row.Cells["BitisSaati"].Value?.ToString();
                string Donem = row.Cells["Donem"].Value?.ToString();

                DateTime baslangicDateTime = DateTime.MinValue;
                DateTime bitisDateTime = DateTime.MinValue;
                // Tarih ve saat bilgilerini işle
                if (!string.IsNullOrEmpty(baslangicStr))
                {
                    if (DateTime.TryParse(baslangicStr, out baslangicDateTime))
                    {
                        dtpBaslangicSaati.Value = baslangicDateTime.Date; // Tarih kısmını ayarla
                        mskBaslangic2.Text = baslangicDateTime.ToString("HH:mm"); // Saat kısmını ayarla
                    }
                    else
                    {
                        MessageBox.Show("Başlangıç saati formatı geçersiz.");
                    }
                }

                if (!string.IsNullOrEmpty(bitisStr))
                {
                    if (DateTime.TryParse(bitisStr, out bitisDateTime))
                    {
                        dtpBitisSaati2.Value = bitisDateTime.Date; // Tarih kısmını ayarla
                        mskBitis2.Text = bitisDateTime.ToString("HH:mm"); // Saat kısmını ayarla
                    }
                    else
                    {
                        MessageBox.Show("Bitiş saati formatı geçersiz.");
                    }
                }

                // Dönem bilgilerini işleme
                if (!string.IsNullOrEmpty(Donem))
                {
                    Dictionary<string, string> aylar = new Dictionary<string, string>
            {
                { "Ocak", "01" },
                { "Şubat", "02" },
                { "Mart", "03" },
                { "Nisan", "04" },
                { "Mayıs", "05" },
                { "Haziran", "06" },
                { "Temmuz", "07" },
                { "Ağustos", "08" },
                { "Eylül", "09" },
                { "Ekim", "10" },
                { "Kasım", "11" },
                { "Aralık", "12" }
            };

                    if (Donem.Contains("/"))
                    {
                        int indexOfSlash = Donem.IndexOf('/');
                        if (indexOfSlash > 0 && Donem.Length > indexOfSlash + 1)
                        {
                            string ay = Donem.Substring(0, indexOfSlash).Trim();
                            string yil = Donem.Substring(indexOfSlash + 1).Trim();

                            if (int.TryParse(ay, out int ayNo))
                            {
                                cmbAy2.Text = ayNo.ToString("00");
                            }
                            else if (aylar.ContainsKey(ay))
                            {
                                cmbAy2.Text = aylar[ay];
                            }
                            else
                            {
                                MessageBox.Show("Geçersiz ay ismi.");
                            }

                            cmbYıl2.Text = yil;
                        }
                        else
                        {
                            MessageBox.Show("Dönem formatı geçersiz. Format: 'Ay/Yıl'.");
                        }
                    }
                    else
                    {
                        string[] donemParcalari = Donem.Split(' ');
                        if (donemParcalari.Length == 2)
                        {
                            string ay = donemParcalari[0].Trim();
                            string yil = donemParcalari[1].Trim();

                            if (int.TryParse(ay, out int ayNo))
                            {
                                cmbAy2.Text = ayNo.ToString("00");
                            }
                            else if (aylar.ContainsKey(ay))
                            {
                                cmbAy2.Text = aylar[ay];
                            }
                            else
                            {
                                MessageBox.Show("Geçersiz ay ismi.");
                            }

                            cmbYıl2.Text = yil;
                        }
                        else
                        {
                            MessageBox.Show("Dönem formatı geçersiz. Format: 'Ay/Yıl' veya 'Ay Yıl'.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dönem bilgisi boş.");
                }

                // Mesai ücreti hesaplama
                decimal mesaiUcreti;
                if (decimal.TryParse(txtMesaiUcreti2.Text, out mesaiUcreti))
                {
                    TimeSpan fark = bitisDateTime - baslangicDateTime;
                    decimal saatFarki = (decimal)fark.TotalHours;

                    decimal tutar2 = saatFarki * mesaiUcreti;
                    txtTutar2.Text = tutar2.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Mesai ücreti geçersiz.");
                }
            }
        }



        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }
        private bool isClearingControls = false;
        private void txtPersonelID2_TextChanged(object sender, EventArgs e)
        {
            if (!isClearingControls) // Temizleme işlemi sırasında bu olay tetiklenmesin
            {
                if (!string.IsNullOrEmpty(txtPersonelID2.Text))
                {
                    // ID alanı doluysa veriyi getir
                    p.PersonelAdiSoyadiGetir(txtPersonelID2, txtAdsoyad2);
                }
            }
        }

        private void btnTemzile2_Click(object sender, EventArgs e)
        {
            isClearingControls = true; // Temizleme işlemi başlıyor

            // Form üzerindeki tüm kontrolleri temizleyen metod
            ClearControls(this);

            isClearingControls = false; // Temizleme işlemi bitti
            // DateTimePicker'ları sıfırla
            dtpBaslangicSaati.Value = DateTime.Now;
            dtpBitisSaati2.Value = DateTime.Now;
        }
        private void ClearControls(Control parent)
        {
            foreach (Control item in parent.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1; // ComboBox için SelectedIndex'i sıfırlayın
                }
                else if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
                else if (item.Controls.Count > 0)
                {
                    // Eğer kontrol bir konteyner ise (Panel, GroupBox gibi) alt kontrolleri de kontrol et
                    ClearControls(item);
                }
            }
        }

        private void btnTümMesaiÖde_Click(object sender, EventArgs e)
        {
            // Onay mesajı göster ve sonucu kontrol et
            DialogResult result = MessageBox.Show("Tüm ödenmemiş mesai ücretlerini ödemek istediğinizden emin misiniz?",
                                                  "Toplu Mesai Ödeme Onayı",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Mesailer m = new Mesailer();
                m.OdenmeDurumu = "Ödendi";
                string sql = "update tblMesailerr set OdenmeDurumu=@p where OdenmeDurumu=@p2";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@p", m.OdenmeDurumu);
                cmd.Parameters.AddWithValue("@p2", "Ödenmedi");
                VeriTabanı.esg(cmd, sql);
                MessageBox.Show("Ödenmeyen tüm mesailer ödendi.", "Mesai Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls(this);
                List<Mesailer> mesailer = veriTabanı.MesaiListele();
                dataGridView1.DataSource = mesailer;
            }
            else
            {
                MessageBox.Show("Ödeme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnÖde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMesaiID2.Text))
            {
                MessageBox.Show("Lütfen geçerli bir Mesai ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }
            Mesailer m = new Mesailer();
            // Onay mesajı göster ve sonucu kontrol et
            DialogResult result = MessageBox.Show(" Mesai Ücretini ödemek istediğinizden emin misiniz?", "Mesai Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                m.OdenmeDurumu = "Ödendi";
                m.MesaiID = int.Parse(txtMesaiID2.Text);
                string sql = "update tblMesailerr set OdenmeDurumu=@p where MesaiID=@p2";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@p", m.OdenmeDurumu);
                cmd.Parameters.AddWithValue("@p2", m.MesaiID);
                VeriTabanı.esg(cmd, sql);
                MessageBox.Show(m.MesaiID + ".Nolu Mesai Ücreti Ödendi.", "Mesai Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls(this);
                List<Mesailer> mesailer = veriTabanı.MesaiListele();
                dataGridView1.DataSource = mesailer;
            }
            else
            {
                MessageBox.Show("Ödeme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnSil2_Click(object sender, EventArgs e)
        {
            try
            {
                Mesailer m = new Mesailer();
                int mesaiID;

                // MesaiID'nin geçerli bir sayı olup olmadığını kontrol et
                if (int.TryParse(txtMesaiID2.Text, out mesaiID))
                {
                    m.MesaiID = mesaiID;

                    if (MessageBox.Show("Bu Kayıt Silinsin mi?", "Mesai Silme Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string sql = "delete from tblMesailerr where MesaiID=@p2";
                        SqlCommand cmd = new SqlCommand(sql);
                        cmd.Parameters.AddWithValue("@p2", m.MesaiID);

                        VeriTabanı.esg(cmd, sql); // SQL komutunu çalıştır

                        MessageBox.Show(m.MesaiID + ". Nolu Mesai Kaydı Silindi.", "Mesai Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        ClearControls(this); // Tüm kontrolleri temizle

                        List<Mesailer> mesailer = veriTabanı.MesaiListele();
                        dataGridView1.DataSource = mesailer; // Yeni verileri DataGridView'a yükle
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir Mesai ID girin.", "Geçersiz Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGüncelle2_Click(object sender, EventArgs e)
        {
            // PersonelID ve MesaiID alanlarının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtPersonelID2.Text) || string.IsNullOrWhiteSpace(txtMesaiID2.Text))
            {
                MessageBox.Show("Lütfen Personel ID ve Mesai ID alanlarını doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // PersonelID ve MesaiID'nin sayısal formatta olup olmadığını kontrol et
                int personelID, mesaiID;
                if (!int.TryParse(txtPersonelID2.Text, out personelID) || !int.TryParse(txtMesaiID2.Text, out mesaiID))
                {
                    MessageBox.Show("Personel ID ve Mesai ID alanları sayısal olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Mesailer m = new Mesailer();
                Personeller p = new Personeller();
                p.PersonelID = personelID;
                m.MesaiID = mesaiID;
                m.BaslangicSaati = dtpBaslangicSaati.Text + " " + mskBaslangic2.Text;
                m.BitisSaati = dtpBitisSaati2.Text + " " + mskBitis2.Text;
                m.MesaiSaatUcreti = decimal.Parse(txtMesaiUcreti2.Text);
                m.Tutar = decimal.Parse(txtTutar2.Text);
                m.Donem = cmbAy2.Text + "/" + cmbYıl2.Text;
                m.Aciklama = txtAciklama2.Text;
                m.OdenmeDurumu = cmbOdeme.Text;

                string sql = "UPDATE tblMesailerr SET BaslangicSaati = @p1, BitisSaati = @p2, MesaiSaatUcreti = @p3, Tutar = @p4, OdenmeDurumu = @p8, Donem = @p5, Aciklama = @p6 WHERE MesaiID = @p7";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@p1", m.BaslangicSaati);
                cmd.Parameters.AddWithValue("@p2", m.BitisSaati);
                cmd.Parameters.AddWithValue("@p3", m.MesaiSaatUcreti);
                cmd.Parameters.AddWithValue("@p4", m.Tutar);
                cmd.Parameters.AddWithValue("@p8", m.OdenmeDurumu);
                cmd.Parameters.AddWithValue("@p5", m.Donem);
                cmd.Parameters.AddWithValue("@p6", m.Aciklama);
                cmd.Parameters.AddWithValue("@p7", m.MesaiID);

                VeriTabanı.esg(cmd, sql);
                MessageBox.Show(m.MesaiID + ". Nolu Mesai Kaydı Güncellendi.", "Mesai Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kontrolleri temizle ve güncel verileri listele
                ClearControls(this);
                List<Mesailer> mesailer = veriTabanı.MesaiListele();
                dataGridView1.DataSource = mesailer;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Veri formatı hatalı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonelMesaileri_Click(object sender, EventArgs e)
        {
            frmPersonelMesailer fr = new frmPersonelMesailer();
            fr.ShowDialog();
        }

        private void Btncıkıs2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpBaslangicSaati_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mskBaslangic2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
