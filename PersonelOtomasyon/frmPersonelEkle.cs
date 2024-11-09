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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Veri tabanına ekleme işlemi yapılır
                VeriTabanı veriTabanı = new VeriTabanı();

                // Seçilen RolAdi'na göre RolID'yi bul
                string selectedRoleName = comboBox1.Text;
                int roleId = GetRoleIdByRoleName(selectedRoleName);

                Personeller yeniPersonel = new Personeller
                {
                    Adi = txtAd.Text,
                    Soyadi = txtSoyad.Text,
                    Telefon = mskTelefon.Text,
                    Adres = txtAdres.Text,
                    Email = txtEmail.Text,
                    DepartmanID = Convert.ToInt32(txtDepartmanID.Text),
                    Durumu = cmbDurum.SelectedItem.ToString(),
                    Maasi = Convert.ToDecimal(mskMaas.Text),
                    GirisTarihi = Convert.ToDateTime(txtGiris.Text),
                    CikisTarihi = Convert.ToDateTime(txtCikis.Text),
                    Aciklama = txtAciklama.Text,
                    RolID = roleId // Burada doğru RolID kullanılır
                };

                // Personeli veri tabanına ekle
                veriTabanı.KayitEklePersonel(yeniPersonel);

                // Formun başarı ile kapandığını belirt
                this.DialogResult = DialogResult.OK;
                this.Close(); // Formu kapat
            }
            catch (Exception ex)
            {
                // Hata mesajı göster
                MessageBox.Show($"Kayıt sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetRoleIdByRoleName(string roleName)
        {
            int roleId = 0;
            string connectionString = "Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT RolID FROM tblRoller WHERE RolAdi = @RolAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RolAdi", roleName);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    roleId = Convert.ToInt32(reader["RolID"]);
                }
                reader.Close();
            }

            return roleId;
        }


        private void LoadRolesIntoComboBox()
        {
            string connectionString = "Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT RolID, RolAdi FROM tblRoller";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // ComboBox'ı doldur
                comboBox1.DisplayMember = "RolAdi";
                comboBox1.ValueMember = "RolID";
                comboBox1.DataSource = dt;
            }
        }

        public void ClearForm()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            mskTelefon.Text = string.Empty;
            txtAdres.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDepartmanID.Text = string.Empty;
            cmbDurum.SelectedIndex = -1; // veya boş bir değer
            mskMaas.Text = string.Empty;
            txtGiris.Text = string.Empty;
            txtCikis.Text = string.Empty;
            txtAciklama.Text = string.Empty;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmGenel fr =new frmGenel();
            //fr.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Kullanıcının seçtiği rol ID'sini al
            //int selectedRoleID = Convert.ToInt32(comboBox1.SelectedValue);

            //// Seçilen rol ID'sine göre işlemler yapabilirsiniz
            //MessageBox.Show("Seçilen Rol ID: " + selectedRoleID);
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            LoadRolesIntoComboBox();
        }
    }
}
