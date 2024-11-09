using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace PersonelOtomasyon
{
    public partial class frmDepartmanlar : Form
    {
        private BindingList<Departmanlar> departmanlar;
        private VeriTabanı vt;
        private ImageList imageList;

        public frmDepartmanlar()
        {
            InitializeComponent();
            vt = new VeriTabanı();
        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            imageList = new ImageList();

            try
            {
                departmanlar = new BindingList<Departmanlar>(vt.GetDepartmanlar());
                dataGridView1.DataSource = departmanlar;

                dataGridView1.ReadOnly = false;
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;

                // İkon dosya yollarını kontrol edin ve ImageList'e ekleyin
                string deleteIconPath = @"D:\resim\sil.png";
                string updateIconPath = @"D:\resim\kalem.png";

                if (System.IO.File.Exists(deleteIconPath))
                {
                    imageList.Images.Add("sil", Image.FromFile(deleteIconPath));
                }
                else
                {
                    MessageBox.Show("Silme ikonu dosyası bulunamadı: " + deleteIconPath);
                    return;
                }

                if (System.IO.File.Exists(updateIconPath))
                {
                    imageList.Images.Add("guncelle", Image.FromFile(updateIconPath));
                }
                else
                {
                    MessageBox.Show("Güncelleme ikonu dosyası bulunamadı: " + updateIconPath);
                    return;
                }



                // Silme ve Güncelleme sütunlarını ekleyin
                DataGridViewImageColumn imgColumnSil = new DataGridViewImageColumn
                {
                    HeaderText = "Sil",
                    Name = "silImageColumn",
                    Width = 30
                };
                dataGridView1.Columns.Add(imgColumnSil);

                DataGridViewImageColumn imgColumnGuncelle = new DataGridViewImageColumn
                {
                    HeaderText = "Güncelle",
                    Name = "guncelleImageColumn",
                    Width = 70
                };
                dataGridView1.Columns.Add(imgColumnGuncelle);

                // Satırlara ikonları ekleyin
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["silImageColumn"].Value = imageList.Images["sil"];
                    row.Cells["guncelleImageColumn"].Value = imageList.Images["guncelle"];
                }

                // Sütun başlıklarının fontlarını büyüt ve kalın yap
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
                }

                // Event handler ekleyin
                dataGridView1.CellClick += dataGridView1_CellClick;
                dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
                dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // İşlem yapılmasına izin vermek istemediğiniz sütunları kontrol edin
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex != dataGridView1.Columns["silImageColumn"].Index &&
                    e.ColumnIndex != dataGridView1.Columns["guncelleImageColumn"].Index)
                {
                    MessageBox.Show("Bu sütunlar üzerinde işlem yapılamaz.", "İşlem Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (e.ColumnIndex == dataGridView1.Columns["silImageColumn"].Index)
                {
                    DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        int id = (int)dataGridView1.Rows[e.RowIndex].Cells["DepartmanID"].Value;
                        vt.KayitSilDepartman(id);

                        var silinecekDepartman = departmanlar.FirstOrDefault(d => d.DepartmanID == id);
                        if (silinecekDepartman != null)
                        {
                            departmanlar.Remove(silinecekDepartman);
                            MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["guncelleImageColumn"].Index)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["DepartmanID"].Value;
                string departmanAdi = dataGridView1.Rows[e.RowIndex].Cells["DepartmanAdi"].Value.ToString();
                string aciklama = dataGridView1.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();


                using (frmGuncelle guncelleForm = new frmGuncelle(id, departmanAdi, aciklama))
                {
                    if (guncelleForm.ShowDialog() == DialogResult.OK)
                    {
                        int updatedID = int.Parse(guncelleForm.txt_DepartmanID.Text);
                        string updatedDepartmanAdi = guncelleForm.txt_Departman.Text;
                        string updatedAciklama = guncelleForm.txt_Acıklama.Text;


                        var departmanToUpdate = departmanlar.FirstOrDefault(d => d.DepartmanID == updatedID);
                        if (departmanToUpdate != null)
                        {
                            departmanToUpdate.DepartmanAdi = updatedDepartmanAdi;
                            departmanToUpdate.Aciklama = updatedAciklama;
                            //departmanToUpdate.RolID = updatedRolID;

                            vt.KayitGuncelleDepartman(departmanToUpdate);
                            dataGridView1.Refresh();

                            MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["DepartmanID"].Value;
                var guncellenecekDepartman = departmanlar.FirstOrDefault(d => d.DepartmanID == id);

                if (guncellenecekDepartman != null)
                {
                    guncellenecekDepartman.DepartmanAdi = dataGridView1.Rows[e.RowIndex].Cells["DepartmanAdi"].Value.ToString();
                    guncellenecekDepartman.Aciklama = dataGridView1.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();

                    vt.KayitGuncelleDepartman(guncellenecekDepartman);
                    MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void toolStripButtonExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Dosyası|*.xlsx",
                FileName = "Departmanlar.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Departmanlar");

                    worksheet.Cell(1, 1).Value = "DepartmanID";
                    worksheet.Cell(1, 2).Value = "Departman";
                    worksheet.Cell(1, 3).Value = "Açıklama";

                    for (int i = 0; i < departmanlar.Count; i++)
                    {

                        worksheet.Cell(i + 2, 1).Value = departmanlar[i].DepartmanID;
                        worksheet.Cell(i + 2, 2).Value = departmanlar[i].DepartmanAdi;
                        worksheet.Cell(i + 2, 3).Value = departmanlar[i].Aciklama;
                    }

                    workbook.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Veriler başarıyla Excel dosyasına aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void toolStrip_KayıtEkle_Click(object sender, EventArgs e)
        {
            frmDepartmanEkle fr = new frmDepartmanEkle();
            fr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
