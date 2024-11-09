using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public class VeriTabanı
    {
        private string connectionString = "Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True";
        private static SqlConnection bgl = new SqlConnection("Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True");
        public static void esg(SqlCommand komut, string sqlcumle)
        {
            komut.CommandText = sqlcumle;
            komut.Connection = bgl;
            if (bgl.State == ConnectionState.Closed)
            {
                bgl.Open();
            }
            komut.ExecuteNonQuery();
            bgl.Close();
        }
        public static DataTable ListeleAra(DataGridView gridView, string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            bgl.Open();
            SqlCommand cmd = new SqlCommand(sql, bgl);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            gridView.DataSource = dt;
            bgl.Close();
            return dt;
        }


        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        #region Departman İşlemleri

        // Departmanları getiren metod
        public List<Departmanlar> GetDepartmanlar()
        {
            List<Departmanlar> departmanlar = new List<Departmanlar>();

            using (SqlConnection baglanti = GetConnection())
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblDepartmanlar", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Departmanlar departman = new Departmanlar
                    {
                        DepartmanID = Convert.ToInt32(dr["DepartmanID"]),
                        DepartmanAdi = dr["DepartmanAdi"].ToString(),
                        Aciklama = dr["Aciklama"].ToString(),
                        /*RolID = Convert.ToInt32(dr["RolID"])*/  // RolID'yi ekleyin
                    };
                    departmanlar.Add(departman);
                }
            }

            return departmanlar;
        }

        // Departman ekleyen metod
        public void KayitEkleDepartman(Departmanlar departman)
        {
            string sorgu = "INSERT INTO tblDepartmanlar (DepartmanAdi, Aciklama) VALUES (@DepartmanAdi, @Aciklama)";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@DepartmanAdi", departman.DepartmanAdi);
                komut.Parameters.AddWithValue("@Aciklama", departman.Aciklama);
                /*komut.Parameters.AddWithValue("@RolID", departman.RolID);*/  // RolID'yi ekleyin

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Departman başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Departman ekleme işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Departman güncelleyen metod
        public void KayitGuncelleDepartman(Departmanlar departman)
        {
            string sorgu = "UPDATE tblDepartmanlar SET DepartmanAdi = @DepartmanAdi, Aciklama = @Aciklama WHERE DepartmanID = @DepartmanID";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@DepartmanID", departman.DepartmanID);
                komut.Parameters.AddWithValue("@DepartmanAdi", departman.DepartmanAdi);
                komut.Parameters.AddWithValue("@Aciklama", departman.Aciklama);
               /* komut.Parameters.AddWithValue("@RolID", departman.RolID);*/  // RolID'yi ekleyin

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Departman başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Departman güncelleme işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Departman silen metod
        public void KayitSilDepartman(int id)
        {
            string sorgu = "DELETE FROM tblDepartmanlar WHERE DepartmanID = @ID";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@ID", id);

                try
                {
                    baglanti.Open();
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Departman başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Silinecek departman bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Departman silme işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Personel İşlemleri

        // Personel verilerini getiren metod
        public List<Personeller> GetPersoneller()
        {
            List<Personeller> personeller = new List<Personeller>();

            using (SqlConnection baglanti = GetConnection())
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblPersoneller", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Personeller personel = new Personeller
                    {
                        PersonelID = Convert.ToInt32(dr["PersonelID"]),
                        Adi = dr["Adi"].ToString(),
                        Soyadi = dr["Soyadi"].ToString(),
                        Telefon = dr["Telefon"].ToString(),
                        Adres = dr["Adres"].ToString(),
                        Email = dr["Email"].ToString(),
                        DepartmanID = Convert.ToInt32(dr["DepartmanID"]),
                        Durumu = dr["Durumu"].ToString(),
                        Maasi = Convert.ToDecimal(dr["Maasi"]),
                        GirisTarihi = dr["GirisTarihi"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["GirisTarihi"]),
                        CikisTarihi = dr["CikisTarihi"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["CikisTarihi"]),
                        Aciklama = dr["Aciklama"].ToString(),
                        RolID = Convert.ToInt32(dr["RolID"]),
                    };
                    personeller.Add(personel);
                }
            }

            return personeller;
        }

        // Personel kaydını ekleyen metod
        public void KayitEklePersonel(Personeller personel)
        {
            string sorgu = "INSERT INTO tblPersoneller (Adi, Soyadi, Telefon, Adres, Email, DepartmanID, Durumu, Maasi, GirisTarihi, CikisTarihi, Aciklama,RolID) " +
                           "VALUES (@Adi, @Soyadi, @Telefon, @Adres, @Email, @DepartmanID, @Durumu, @Maasi, @GirisTarihi, @CikisTarihi, @Aciklama,@RolID)";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@Adi", personel.Adi);
                komut.Parameters.AddWithValue("@Soyadi", personel.Soyadi);
                komut.Parameters.AddWithValue("@Telefon", personel.Telefon);
                komut.Parameters.AddWithValue("@Adres", personel.Adres);
                komut.Parameters.AddWithValue("@Email", personel.Email);
                komut.Parameters.AddWithValue("@DepartmanID", personel.DepartmanID);
                komut.Parameters.AddWithValue("@Durumu", personel.Durumu);
                komut.Parameters.AddWithValue("@Maasi", personel.Maasi);
                komut.Parameters.AddWithValue("@GirisTarihi", (object)personel.GirisTarihi ?? DBNull.Value);
                komut.Parameters.AddWithValue("@CikisTarihi", (object)personel.CikisTarihi ?? DBNull.Value);
                komut.Parameters.AddWithValue("@Aciklama", personel.Aciklama);
                komut.Parameters.AddWithValue("@RolID", personel.RolID);

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel ekleme işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Personel kaydını güncelleyen metod
        public void KayitGuncellePersonel(Personeller personel)
        {
            string sorgu = "UPDATE tblPersoneller SET Adi = @Adi, Soyadi = @Soyadi, Telefon = @Telefon, Adres = @Adres, Email = @Email, DepartmanID = @DepartmanID, " +
                           "Durumu = @Durumu, Maasi = @Maasi, GirisTarihi = @GirisTarihi, CikisTarihi = @CikisTarihi, Aciklama = @Aciklama WHERE PersonelID = @PersonelID";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@PersonelID", personel.PersonelID);
                komut.Parameters.AddWithValue("@Adi", personel.Adi);
                komut.Parameters.AddWithValue("@Soyadi", personel.Soyadi);
                komut.Parameters.AddWithValue("@Telefon", personel.Telefon);
                komut.Parameters.AddWithValue("@Adres", personel.Adres);
                komut.Parameters.AddWithValue("@Email", personel.Email);
                komut.Parameters.AddWithValue("@DepartmanID", personel.DepartmanID);
                komut.Parameters.AddWithValue("@Durumu", personel.Durumu);
                komut.Parameters.AddWithValue("@Maasi", personel.Maasi);
                komut.Parameters.AddWithValue("@GirisTarihi", (object)personel.GirisTarihi ?? DBNull.Value);
                komut.Parameters.AddWithValue("@CikisTarihi", (object)personel.CikisTarihi ?? DBNull.Value);
                komut.Parameters.AddWithValue("@Aciklama", personel.Aciklama);

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel güncelleme işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Personel kaydını silen metod
        public void KayitSilPersonel(int id)
        {
            // İlk olarak tblKullanicilar ve tblMesailerr tablosunda referans edilen kayıtları sil
            string kullaniciSilmeSorgusu = "DELETE FROM tblKullanicilar WHERE PersonelID = @ID";
            string mesaiSilmeSorgusu = "DELETE FROM tblMesailerr WHERE PersonelID = @ID";

            // Daha sonra tblPersoneller tablosundan kaydı sil
            string personelSilmeSorgusu = "DELETE FROM tblPersoneller WHERE PersonelID = @ID";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand mesaiSilKomutu = new SqlCommand(mesaiSilmeSorgusu, baglanti))
            using (SqlCommand kullaniciSilKomutu = new SqlCommand(kullaniciSilmeSorgusu, baglanti))
            using (SqlCommand personelSilKomutu = new SqlCommand(personelSilmeSorgusu, baglanti))
            {
                mesaiSilKomutu.Parameters.AddWithValue("@ID", id);
                kullaniciSilKomutu.Parameters.AddWithValue("@ID", id);
                personelSilKomutu.Parameters.AddWithValue("@ID", id);

                try
                {
                    baglanti.Open();

                    // İlk olarak tblMesailerr tablosundaki ilgili mesai kayıtlarını sil
                    mesaiSilKomutu.ExecuteNonQuery();

                    // Ardından tblKullanicilar tablosundaki ilgili kullanıcı kayıtlarını sil
                    kullaniciSilKomutu.ExecuteNonQuery();

                    // Son olarak tblPersoneller tablosundan personel kaydını sil
                    int silmeSonucu = personelSilKomutu.ExecuteNonQuery();
                    if (silmeSonucu > 0)
                    {
                        MessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Silinecek personel bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel silme işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        #endregion
        public int GetDepartmanIDByRolID(int rolID)
        {
            int departmanID = -1;
            string sorgu = "SELECT DepartmanID FROM tblDepartmanlar WHERE DepartmanID = (SELECT TOP 1 DepartmanID FROM tblPersoneller WHERE PersonelID = (SELECT TOP 1 PersonelID FROM tblKullanicilar WHERE RolID = @RolID))";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@RolID", rolID);

                try
                {
                    baglanti.Open();
                    object result = komut.ExecuteScalar();
                    if (result != null)
                    {
                        departmanID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Departman ID alma işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return departmanID;
        }
        public DataTable GetRollerData()
        {
            DataTable dtRoller = new DataTable();

            using (SqlConnection baglanti = GetConnection())
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblRoller", baglanti);
                da.Fill(dtRoller);
            }

            return dtRoller;
        }
        public void KayitSilRol(int rolID)
        {
            string sorgu = "DELETE FROM tblRoller WHERE RolID = @RolID";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@RolID", rolID);

                try
                {
                    baglanti.Open();
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Rol başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Silinecek rol bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rol silme işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public List<Personeller> GetPersonellerByDepartmanID(int departmanID)
        {
            List<Personeller> personeller = new List<Personeller>();

            string sorgu = "SELECT * FROM tblPersoneller WHERE DepartmanID = @DepartmanID";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@DepartmanID", departmanID);

                try
                {
                    baglanti.Open();
                    SqlDataReader dr = komut.ExecuteReader();

                    while (dr.Read())
                    {
                        Personeller personel = new Personeller
                        {
                            PersonelID = Convert.ToInt32(dr["PersonelID"]),
                            Adi = dr["Adi"].ToString(),
                            Soyadi = dr["Soyadi"].ToString(),
                            Telefon = dr["Telefon"].ToString(),
                            Adres = dr["Adres"].ToString(),
                            Email = dr["Email"].ToString(),
                            DepartmanID = Convert.ToInt32(dr["DepartmanID"]),
                            Durumu = dr["Durumu"].ToString(),
                            Maasi = Convert.ToDecimal(dr["Maasi"]),
                            GirisTarihi = dr["GirisTarihi"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["GirisTarihi"]),
                            CikisTarihi = dr["CikisTarihi"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["CikisTarihi"]),
                            Aciklama = dr["Aciklama"].ToString()
                        };
                        personeller.Add(personel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Departman ID'ye göre personel alma işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return personeller;
        }
        //public List<Departmanlar> GetDepartmanlar()
        //{
        //    List<Departmanlar> departmanlar = new List<Departmanlar>();

        //    using (SqlConnection baglanti = GetConnection())
        //    {
        //        baglanti.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM tblDepartmanlar", baglanti);
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            Departmanlar departman = new Departmanlar
        //            {
        //                DepartmanID = Convert.ToInt32(dr["DepartmanID"]),
        //                DepartmanAdi = dr["DepartmanAdi"].ToString(),
        //                Aciklama = dr["Aciklama"].ToString(),
        //                RolID = Convert.ToInt32(dr["RolID"])  // RolID'yi ekleyin
        //            };
        //            departmanlar.Add(departman);
        //        }
        //    }

        //    return departmanlar;
        //}

        public bool KayitEkleRol(Roller rol)
        {
            int kontrol = 0;
            using (SqlConnection conn = new SqlConnection("Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tblRoller ( RolAdi) VALUES ( @RolAdi)", conn))
                {
                    
                    cmd.Parameters.AddWithValue("@RolAdi", rol.RolAdi);

                   kontrol= cmd.ExecuteNonQuery();
                }
                return kontrol > 0;
            }
        }
        public bool KayitGuncelleRol(int rolID, string rolAdi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblRoller SET RolAdi = @RolAdi WHERE RolID = @RolID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RolID", rolID);
                    cmd.Parameters.AddWithValue("@RolAdi", rolAdi);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Eğer güncellenen satır sayısı 0'dan büyükse başarılı
                }
            }
        }
        public List<Mesailer> MesaiListele()
        {
            List<Mesailer> mesailer = new List<Mesailer>();

            using (SqlConnection baglanti = GetConnection())
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblMesailerr", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Mesailer mesai = new Mesailer
                    {
                        MesaiID = Convert.ToInt32(dr["MesaiID"]),
                        KullaniciID = Convert.ToInt32(dr["KullaniciID"]),
                        PersonelID = Convert.ToInt32(dr["PersonelID"]),
                        BaslangicSaati = dr["BaslangicSaati"].ToString(),
                        BitisSaati = dr["BitisSaati"].ToString(),
                        MesaiSaatUcreti = Convert.ToDecimal(dr["MesaiSaatUcreti"]),
                        Tutar = Convert.ToDecimal(dr["Tutar"]),
                        Donem = dr["Donem"].ToString(),
                        OdenmeDurumu = dr["OdenmeDurumu"].ToString(),
                        Tarih = Convert.ToDateTime(dr["Tarih"]),
                        Aciklama = dr["Aciklama"].ToString(),
                    };
                    mesailer.Add(mesai);
                }
            }

            return mesailer;
        }
        public List<Personeller> GetPersonellerByRolID(int rolID)
        {
            List<Personeller> personeller = new List<Personeller>();
            string sorgu = "SELECT * FROM tblPersoneller WHERE RolID = @RolID";

            using (SqlConnection baglanti = GetConnection())
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@RolID", rolID);

                try
                {
                    baglanti.Open();
                    SqlDataReader reader = komut.ExecuteReader();
                    while (reader.Read())
                    {
                        personeller.Add(new Personeller
                        {
                            PersonelID = reader["PersonelID"] != DBNull.Value ? Convert.ToInt32(reader["PersonelID"]) : 0,
                            Adi = reader["Adi"] != DBNull.Value ? reader["Adi"].ToString() : string.Empty,
                            Soyadi = reader["Soyadi"] != DBNull.Value ? reader["Soyadi"].ToString() : string.Empty,
                            Telefon = reader["Telefon"] != DBNull.Value ? reader["Telefon"].ToString() : string.Empty,
                            Adres = reader["Adres"] != DBNull.Value ? reader["Adres"].ToString() : string.Empty,
                            Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty,
                            DepartmanID = reader["DepartmanID"] != DBNull.Value ? Convert.ToInt32(reader["DepartmanID"]) : 0,
                            Durumu = reader["Durumu"] != DBNull.Value ? reader["Durumu"].ToString() : string.Empty,
                            Maasi = reader["Maasi"] != DBNull.Value ? Convert.ToDecimal(reader["Maasi"]) : 0m,
                            GirisTarihi = reader["GirisTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["GirisTarihi"]) : DateTime.MinValue,
                            CikisTarihi = reader["CikisTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["CikisTarihi"]) : DateTime.MinValue,
                            RolID = reader["RolID"] != DBNull.Value ? Convert.ToInt32(reader["RolID"]) : 0,
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel verilerini yükleme işleminde bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return personeller;
        }

    }

}
