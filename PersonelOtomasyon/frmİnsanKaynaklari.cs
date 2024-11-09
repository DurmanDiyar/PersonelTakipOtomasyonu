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
    public partial class frmİnsanKaynaklari : Form
    {
        private ImageList imageList;
        public string Roladii;
        frmGenel fr = new frmGenel();
        
        public frmİnsanKaynaklari()
        {
            InitializeComponent();
        }

        private void frmİnsanKaynaklari_Load(object sender, EventArgs e)
        {
            InitializeImageList();
            SetupDataGridView();
            LoadData(); // Verileri yükleyen bir metodunuz olmalı
            //fr.RolAdi = Roladi;
        }

        private void InitializeImageList()
        {
            imageList = new ImageList();

            // İkon dosyalarınızı buradan ekleyin
            imageList.Images.Add("delete", Image.FromFile(@"D:\resim\sill.png"));
            imageList.Images.Add("update", Image.FromFile(@"D:\\resim\\Guncelle.png"));
            imageList.Images.Add("view", Image.FromFile(@"D:\\resim\\search.png"));
        }

        private void SetupDataGridView()
        {
            // DataGridView'i yapılandır
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Sütun başlıklarının fontunu ayarlama
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 11);

            // Roller tablosundan veri çekip DataGridView'e ekle
            DataGridViewTextBoxColumn colRolID = new DataGridViewTextBoxColumn
            {
                Name = "RolID",
                HeaderText = "Rol ID",
                DataPropertyName = "RolID"
            };
            dataGridView1.Columns.Add(colRolID);

            DataGridViewTextBoxColumn colRolAdi = new DataGridViewTextBoxColumn
            {
                Name = "RolAdi",
                HeaderText = "Rol Adı",
                DataPropertyName = "RolAdi"
            };
            dataGridView1.Columns.Add(colRolAdi);

            // Silme butonu
            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
            {
                Name = "btnSil",
                HeaderText = "Sil",
                Width = 60,
                Image = imageList.Images["delete"],
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };

            // Güncelleme butonu
            DataGridViewImageColumn updateColumn = new DataGridViewImageColumn
            {
                Name = "btnGuncelle",
                HeaderText = "Güncelle",
                Width = 60,
                Image = imageList.Images["update"],
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };

            //// Görüntüleme butonu
            //DataGridViewImageColumn viewColumn = new DataGridViewImageColumn
            //{
            //    Name = "btnGoruntule",
            //    HeaderText = "Görüntüle",
            //    Width = 60,
            //    Image = imageList.Images["view"],
            //    DefaultCellStyle = new DataGridViewCellStyle
            //    {
            //        Alignment = DataGridViewContentAlignment.MiddleCenter
            //    }
            //};

            // DataGridView'ye kolonları ekleyin
            dataGridView1.Columns.Add(deleteColumn);
            dataGridView1.Columns.Add(updateColumn);
            //dataGridView1.Columns.Add(viewColumn);

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private List<Roller> ConvertDataTableToRollerList(DataTable dt)
        {
            List<Roller> rollerList = new List<Roller>();

            foreach (DataRow row in dt.Rows)
            {
                Roller roller = new Roller
                {
                    RolID = Convert.ToInt32(row["RolID"]),
                    RolAdi = row["RolAdi"].ToString(),
                };

                rollerList.Add(roller);
            }

            return rollerList;
        }
        
        private void LoadData()
        {
            VeriTabanı veriTabanı = new VeriTabanı();
            DataTable rollerDataTable = veriTabanı.GetRollerData();
            List<Roller> rollerList = ConvertDataTableToRollerList(rollerDataTable);

            // BindingList<Roller> kullanarak veri kaynağını ayarlayın
            dataGridView1.DataSource = new BindingList<Roller>(rollerList);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int rolID = Convert.ToInt32(row.Cells["RolID"].Value);
                string rolADİ = row.Cells["RolAdi"].Value.ToString();

                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnGuncelle")
                {
                    // Güncelleme butonuna tıklandığında frmGuncelleRol formu açılsın ve seçilen veriler o forma taşınsın
                    frmGuncelleRol guncelleForm = new frmGuncelleRol();

                    // Verileri frmGuncelleRol formuna taşıma
                    guncelleForm.txtRolID.Text = row.Cells["RolID"].Value.ToString();
                    guncelleForm.txtRolAdi.Text = row.Cells["RolAdi"].Value.ToString();

                    guncelleForm.ShowDialog();

                    // Veritabanını güncelledikten sonra dataGridView'i yeniden yükleyin
                    LoadData();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnSil")
                {
                    // Silme butonuna tıklandığında yapılacak işlemler
                    DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        VeriTabanı veriTabanı = new VeriTabanı();
                        veriTabanı.KayitSilRol(rolID);
                        LoadData();
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnGoruntule")
                {
                    // Görüntüleme butonuna tıklandığında frmGenel formunu açın
                    frmGenel goruntuleForm = new frmGenel();
                    goruntuleForm.RolID = rolID; // Seçili rol ID'sini frmGenel formuna aktarın
                    

                    // Personel verilerini yükleyin ve gösterin
                    goruntuleForm.LoadPersonelData(rolID);

                    goruntuleForm.ShowDialog();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "RolID" || dataGridView1.Columns[e.ColumnIndex].Name == "RolAdi")
                {
                    // RolID veya RolAdi sütunlarına tıklanırsa hata mesajı göster
                    MessageBox.Show("Bu sütunlar üzerinde işlem yapılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmRolEkle fr = new frmRolEkle();
            fr.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            frmRolEkle fr = new frmRolEkle();
            fr.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }
    }
}
