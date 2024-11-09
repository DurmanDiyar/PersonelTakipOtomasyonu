using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public class Personeller
    {
        public int PersonelID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public int DepartmanID { get; set; }
        public string Durumu { get; set; }
        public decimal Maasi { get; set; }
        public DateTime? GirisTarihi { get; set; }
        public DateTime? CikisTarihi { get; set; }
        public int RolID { get; set; }
        public string Aciklama { get; set; }
        //RolID = reader["RolID"] != DBNull.Value? Convert.ToInt32(reader["RolID"]);

        // Personelleri ComboBox'a yüklemek için metod
        public void ComboyaPersonelGetir(ComboBox cmb)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True"))
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT PersonelID, Adi, Soyadi FROM tblPersoneller", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmb.Items.Add(dr["PersonelID"] + ". " + dr["Adi"] + " " + dr["Soyadi"]);
                }
            }
        }
        public void PersonelAdiSoyadiGetir(TextBox id, TextBox AdSoyad)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True"))
            {
                baglanti.Open();

                // ID'nin sayısal olup olmadığını kontrol et
                if (int.TryParse(id.Text, out int personelID))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblPersoneller WHERE PersonelID=@p", baglanti);
                    cmd.Parameters.AddWithValue("@p", personelID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            AdSoyad.Text = dr["Adi"].ToString() + " " + dr["Soyadi"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bu ID'ye sahip bir personel bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdSoyad.Clear();
                        }
                    }
                }
                else
                {
                    // ID geçerli değilse bir hata mesajı göster
                    MessageBox.Show("Geçerli bir Personel ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Seçilen personelin ID'sini almak için metod
        public void ComboSecilirsePersonelGetir(ComboBox cmb, Label lblID)
        {
            if (cmb.SelectedItem == null)
            {
                lblID.Text = "Personel seçilmedi!";
                return;
            }

            string selectedPersonel = cmb.SelectedItem.ToString();
            string[] selectedPersonelParts = selectedPersonel.Split('.');
            int selectedPersonelID = int.Parse(selectedPersonelParts[0]);

            using (SqlConnection baglanti = new SqlConnection("Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True"))
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT PersonelID, Adi, Soyadi FROM tblPersoneller WHERE PersonelID = @PersonelID", baglanti);
                cmd.Parameters.AddWithValue("@PersonelID", selectedPersonelID);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblID.Text = dr["PersonelID"].ToString();
                }
                else
                {
                    lblID.Text = "Personel bulunamadı!";
                }
            }
        }
    }
}
