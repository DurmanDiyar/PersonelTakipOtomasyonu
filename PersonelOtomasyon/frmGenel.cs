using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class frmGenel : Form
    {
        public frmGenel()
        {
            InitializeComponent();
        }

        public string RolAdi;
        public int RolID { get; set; }
        public int DepartmanID { get; set; }

        private void InitializeToolStripLabels()
        {
            if (toolStrip1 == null)
            {
                MessageBox.Show("ToolStrip1 kontrolü bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ToolStripLabel için görsel ekleme
            ToolStripLabel toolStripLabelDepartman = new ToolStripLabel
            {
                Name = "toolStripLabelDepartman",
                Text = "Departmanlar",
                Image = Image.FromFile(@"D:\resim\zamm.png"),
                ImageAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(5),
                Visible = false,
                Font = new Font("Arial", 12, FontStyle.Regular)
            };
            ToolStripLabel toolStripLabelRoller = new ToolStripLabel
            {
                Name = "toolStripLabelRoller",
                Text = "Roller",
                Image = Image.FromFile(@"D:\resim\Roller.png"),
                ImageAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(5),
                Visible = false,
                Font = new Font("Arial", 12, FontStyle.Regular)
            };

            ToolStripLabel toolStripLabelMesai = new ToolStripLabel
            {
                Name = "toolStripLabelMesai",
                Text = "Mesai İşlemleri",
                Image = Image.FromFile(@"D:\resim\mesaii.png"),
                ImageAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(5),
                Visible = false,
                Font = new Font("Arial", 12, FontStyle.Regular),
            };

            toolStrip1.Items.Add(toolStripLabelDepartman);
            toolStrip1.Items.Add(toolStripLabelMesai);
            toolStrip1.Items.Add(toolStripLabelRoller);

            toolStripLabelRoller.Click += ToolStripLabel_Click;
            toolStripLabelDepartman.Click += ToolStripLabel_Click;
            toolStripLabelMesai.Click += ToolStripLabel_Click;
        }

        private void ToolStripLabel_Click(object sender, EventArgs e)
        {
            ToolStripLabel clickedLabel = sender as ToolStripLabel;

            if (clickedLabel != null)
            {
                if (clickedLabel.Name == "toolStripLabelDepartman")
                {
                    frmDepartmanlar fr = new frmDepartmanlar();
                    fr.ShowDialog();
                }
                else if (clickedLabel.Name == "toolStripLabelMesai")
                {
                    frmMesaiİslemleri fr = new frmMesaiİslemleri();
                    fr.Show();
                }
                else if (clickedLabel.Name == "toolStripLabelRoller")
                {
                    frmİnsanKaynaklari frm = new frmİnsanKaynaklari();
                    frm.Show();
                }
            }
        }

        public void SetFormMode(string mode)
        {
            if (toolStrip1.Items["toolStripLabelDepartman"] == null || toolStrip1.Items["toolStripLabelMesai"] == null || toolStrip1.Items["toolStripLabelRoller"] == null)
            {
                throw new NullReferenceException("ToolStrip öğeleri bulunamadı.");
            }

            if (mode == "IK")
            {
                toolStrip1.Items["toolStripLabelDepartman"].Visible = true;
                toolStrip1.Items["toolStripLabelMesai"].Visible = true;
                toolStrip1.Items["toolStripLabelRoller"].Visible = false;
            }
            else if (mode == "Admin")
            {
                toolStrip1.Items["toolStripLabelRoller"].Visible = true;
                toolStrip1.Items["toolStripLabelDepartman"].Visible = false;
                toolStrip1.Items["toolStripLabelMesai"].Visible = false;
            }
        }

        private void frmGenel_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            LoadPersoneller(); // Tüm personelleri yükle
            AddButtonColumns();
            InitializeToolStripLabels();

            // Kullanıcı rolüne göre formu ayarla
            if (RolAdi == "İnsan Kaynakları") // İnsan Kaynakları
            {
                SetFormMode("IK");
            }
            else if (RolAdi == "Admin") // Admin
            {
                SetFormMode("Admin");
            }
        }

        private void LoadPersoneller()
        {
            VeriTabanı veriTabanı = new VeriTabanı();
            List<Personeller> personeller = veriTabanı.GetPersoneller(); // Tüm personelleri getirin
            dataGridView1.DataSource = new BindingList<Personeller>(personeller);
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }

        private void AddButtonColumns()
        {
            int iconWidth = 16;
            int iconHeight = 16;

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn
            {
                Name = "btnSil",
                HeaderText = "Sil",
                Image = ResizeImage(Image.FromFile(@"D:\resim\delete.png"), iconWidth, iconHeight),
                Width = 30,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };

            DataGridViewImageColumn updateButtonColumn = new DataGridViewImageColumn
            {
                Name = "btnGuncelle",
                HeaderText = "Güncelle",
                Image = ResizeImage(Image.FromFile(@"D:\resim\pencils.png"), iconWidth, iconHeight),
                Width = 30,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };

            dataGridView1.Columns.Add(deleteButtonColumn);
            dataGridView1.Columns.Add(updateButtonColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int personelID = Convert.ToInt32(row.Cells["PersonelID"].Value);

                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnGuncelle")
                {
                    frmGuncellePersonel guncelleForm = new frmGuncellePersonel
                    {
                        PersonelID = personelID
                    };
                    guncelleForm.txtAd.Text = row.Cells["Adi"].Value?.ToString() ?? string.Empty;
                    guncelleForm.txtSoyad.Text = row.Cells["Soyadi"].Value?.ToString() ?? string.Empty;
                    guncelleForm.mskTelefon.Text = row.Cells["Telefon"].Value?.ToString() ?? string.Empty;
                    guncelleForm.txtAdres.Text = row.Cells["Adres"].Value?.ToString() ?? string.Empty;
                    guncelleForm.txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
                    guncelleForm.txtDepartmanID.Text = row.Cells["DepartmanID"].Value?.ToString() ?? string.Empty;
                    guncelleForm.cmbDurum.SelectedItem = row.Cells["Durumu"].Value?.ToString() ?? string.Empty;
                    guncelleForm.mskMaas.Text = row.Cells["Maasi"].Value?.ToString() ?? string.Empty;
                    guncelleForm.txtGiris.Text = row.Cells["GirisTarihi"].Value?.ToString() ?? string.Empty;
                    guncelleForm.txtCikis.Text = row.Cells["CikisTarihi"].Value?.ToString() ?? string.Empty;

                    guncelleForm.ShowDialog();
                    LoadPersoneller();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnSil")
                {
                    var result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        VeriTabanı veriTabanı = new VeriTabanı();
                        veriTabanı.KayitSilPersonel(personelID);
                        LoadPersoneller();
                    }
                }
            }
        }

        public void LoadPersonelData(int rolID)
        {
            VeriTabanı veriTabanı = new VeriTabanı();
            List<Personeller> personeller = veriTabanı.GetPersonellerByRolID(rolID); // RolID'ye göre personelleri getirin
            dataGridView1.DataSource = new BindingList<Personeller>(personeller);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // ToolStripItem click işlemleri burada işlenebilir.
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmPersonelEkle fr = new frmPersonelEkle();
            fr.Show();
        }
    }
}
