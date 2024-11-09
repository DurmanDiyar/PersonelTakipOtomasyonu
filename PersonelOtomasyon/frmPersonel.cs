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
    public partial class frmPersonel : Form
    {
        private int _personelID;
        public frmPersonel()
        {
            InitializeComponent();
        }
        
        private void frmPersonel_Load(object sender, EventArgs e)
        {

        }
        public void SetPersonelBilgileri(string ad, string soyad, string telefon ,string adres, string email,int ıd)
        {
            // Form üzerindeki ilgili TextBox veya Label kontrollerine bilgileri set et
            lbl_adsoyad.Text=ad+" "+soyad;
            lbl_telNo.Text = telefon.ToString();
            lblAdres.Text = adres;
            lblEmail.Text = email;
            _personelID = ıd;
            LoadMesaiBilgileri(_personelID);
        }
        private void LoadMesaiBilgileri(int personelID)
        {
            string connectionString = "Data Source=DIYAR;Initial Catalog=PersonelTakipp;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT MesaiID, Tarih, BaslangicSaati, BitisSaati,MesaiSaatUcreti,Tutar,Donem,OdenmeDurumu,Tarih,Aciklama FROM tblMesailerr WHERE PersonelID = @PersonelID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PersonelID", personelID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnklbl_BilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
