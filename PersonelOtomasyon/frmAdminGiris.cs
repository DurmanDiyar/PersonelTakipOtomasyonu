using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

        private void txt_adminSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_AdminGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre al
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtadminSifre.Text;

            // Veritabanı bağlantı stringi
            string connectionString = "Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True";

            // Kullanıcı adı ve şifre doğrulama
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT PersonelID FROM tblKullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre", conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);

                object personelIDObj = cmd.ExecuteScalar();
                if (personelIDObj != null)
                {
                    int personelID = Convert.ToInt32(personelIDObj);

                    // PersonelID ile Personel ve Rol bilgilerini al
                    SqlCommand personelCmd = new SqlCommand(
                        "SELECT p.PersonelID, r.RolAdi " +
                        "FROM tblPersoneller p " +
                        "INNER JOIN tblRoller r ON p.RolID = r.RolID " +
                        "WHERE p.PersonelID = @PersonelID", conn);
                    personelCmd.Parameters.AddWithValue("@PersonelID", personelID);

                    SqlDataReader reader = personelCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string rolAdi = reader["RolAdi"].ToString();

                        reader.Close();

                        if (rolAdi == "Admin" || rolAdi == "İnsan Kaynakları")
                        {
                            frmGenel fr = new frmGenel();
                            fr.RolAdi = rolAdi; // Rol adını frmGenel formuna gönderiyoruz
                            fr.Show();
                            this.Hide(); // Mevcut formu gizle
                        }
                        else if (rolAdi == "Personel")
                        {
                            SqlCommand personelBilgiCmd = new SqlCommand(
                                "SELECT Adi, Soyadi,Telefon, Adres, Email FROM tblPersoneller WHERE PersonelID = @PersonelID", conn);
                            personelBilgiCmd.Parameters.AddWithValue("@PersonelID", personelID);

                            SqlDataReader personelReader = personelBilgiCmd.ExecuteReader();
                            if (personelReader.Read())
                            {
                                string ad = personelReader["Adi"].ToString();
                                string soyad = personelReader["Soyadi"].ToString();
                                string adres = personelReader["Adres"].ToString();
                                string email = personelReader["Email"].ToString();
                                string Telefon = personelReader["Telefon"].ToString();

                                frmPersonel personelForm = new frmPersonel();
                                personelForm.SetPersonelBilgileri(ad, soyad,Telefon,adres, email, personelID);
                                personelForm.Show();
                                this.Hide(); // Mevcut formu gizle
                            }
                            else
                            {
                                MessageBox.Show("Personel bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            personelReader.Close();
                        }
                        else
                        {
                            // Rol uygun değilse hata mesajı göster
                            MessageBox.Show("Yetkisiz giriş. Geçersiz rol.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Kullanıcı adı veya şifre yanlış
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chb_SifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtadminSifre.UseSystemPasswordChar = !chb_SifreGoster.Checked;
        }

        private void btn_İptal_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmGirisler fr =new frmGirisler();
            //fr.Show();
        }

        private void frmAdminGiris_Load(object sender, EventArgs e)
        {
            txtadminSifre.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
