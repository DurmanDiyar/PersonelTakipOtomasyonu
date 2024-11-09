using DocumentFormat.OpenXml.Office.Word;
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
    public partial class frmPersonelMesailer : Form
    {
        public frmPersonelMesailer()
        {
            InitializeComponent();
        }

        private void frmPersonelMesailer_Load(object sender, EventArgs e)
        {
            string sql = "select PersonelID as ID, Adi as ADI, Soyadi as SOYADI from tblPersoneller";
            VeriTabanı.ListeleAra(dataGridViewPersonel, sql);
        }

        private void dataGridViewPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ıd = dataGridViewPersonel.CurrentRow.Cells["ID"].Value.ToString();
            string sql = "select * from tblMesailerr where PersonelID=@PersonelID";

            // Parametreyi SqlParameter nesnesi olarak ekle
            SqlParameter param = new SqlParameter("@PersonelID", ıd);
            VeriTabanı.ListeleAra(dataGridViewMesai, sql, param);

            lblKayitSayisi.Text = "Toplam " + (dataGridViewMesai.Rows.Count - 1) + " Kayıt Listelendi";

            decimal tutar = 0;

            for (int i = 0; i < dataGridViewMesai.Rows.Count - 1; i++)
            {
                var cellValue = dataGridViewMesai.Rows[i].Cells["Tutar"].Value;

                if (cellValue != null && decimal.TryParse(cellValue.ToString(), out decimal parsedValue))
                {
                    tutar += parsedValue;
                }
            }

            lblTutar.Text = "Toplam Mesai Ücreti = " + tutar.ToString("0,00") + " TL";
        }


        private void txtMesaiIDAra_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from tblMesailerr where MesaiID like @MesaiID";
            SqlParameter param = new SqlParameter("@MesaiID", "%" + txtMesaiIDAra.Text + "%");
            VeriTabanı.ListeleAra(dataGridViewMesai, sql, param);
        }

       
    }
}
