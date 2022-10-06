using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        DialogResult secim = new DialogResult();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCinsiyet.SelectedIndex = 0;
            comboBoxDurum.SelectedIndex = 0;
            comboBoxGorev.SelectedIndex = 0;
            comboBoxUyruk.SelectedIndex = 0;
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll(); // Liste Göre 
            renklendirme();
            //dgwProducts.DataSource = _productDal.GetAll2();// Data Table Göre 
        }
        private void AramaProducts(string key)
        {
            var result = _productDal.GetAll().Where(p => p.PERSONEL_AD.ToLower().Contains(key.ToLower())).ToList(); // Personel adından Sorgulama
            dgwProducts.DataSource = result;

        }

        

        #region Seçilen İçeriği Doldurma
        // Tıklayınca satırı seçiyor  
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTcNo.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();// Seçili satırın 1. satırı
            tbxAdi.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString(); 
            tbxSoyadi.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            dateTimeDogum.Text= dgwProducts.CurrentRow.Cells[4].Value.ToString();
            comboBoxCinsiyet.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();
            comboBoxUyruk.Text = dgwProducts.CurrentRow.Cells[6].Value.ToString();
            textBoxTelefon.Text = dgwProducts.CurrentRow.Cells[7].Value.ToString();
            comboBoxGorev.Text = dgwProducts.CurrentRow.Cells[8].Value.ToString();
            textEmail.Text = dgwProducts.CurrentRow.Cells[9].Value.ToString();
            comboBoxDurum.Text = dgwProducts.CurrentRow.Cells[10].Value.ToString();
            
        }
        #endregion

        #region Veri Ekleme

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbxAdi.Text.Trim()) || 
                string.IsNullOrEmpty(tbxSoyadi.Text.Trim()) || 
                string.IsNullOrEmpty(textBoxTcNo.Text.Trim()) || 
                comboBoxCinsiyet.SelectedIndex <= 0 || 
                comboBoxUyruk.SelectedIndex <= 0 || 
                string.IsNullOrEmpty(textBoxTelefon.Text.Trim()) || 
                comboBoxGorev.SelectedIndex <= 0 ||
                string.IsNullOrEmpty(textEmail.Text.Trim()) || 
                comboBoxDurum.SelectedIndex <= 0)
            {
                MessageBox.Show("İçerik Alanları Boş Olamaz", "Uyarı");
            }
            else
            {
                secim = MessageBox.Show("Personeli Eklemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    _productDal.Add(new Product
                    {
                        PERSONEL_TC_NO = textBoxTcNo.Text,
                        PERSONEL_AD = tbxAdi.Text,
                        PERSONEL_SOYAD = tbxSoyadi.Text,
                        PERSONEL_DOGUM_TARIH = dateTimeDogum.Value,
                        PERSONEL_CINSIYET = comboBoxCinsiyet.Text,
                        PERSONEL_UYRUK = comboBoxUyruk.Text,
                        PERSONEL_TELEFON = textBoxTelefon.Text,
                        PERSONEL_GOREV = comboBoxGorev.Text,
                        PERSONEL_EMAIL = textEmail.Text,
                        PERSONEL_DURUM = comboBoxDurum.Text

                    });
                    LoadProducts();
                    MessageBox.Show("Yeni Personel Eklendi!", "Uyarı");

                }
            }
        }
        #endregion

        #region Güncelleme İşlemi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbxAdi.Text == "" || 
                tbxSoyadi.Text == "" || 
                textBoxTcNo.Text == "" || 
                comboBoxCinsiyet.Text == "Seçiniz.." || 
                textBoxTelefon.Text == "" || 
                comboBoxUyruk.Text == "Seçiniz.." || 
                textEmail.Text == ""  ||
                comboBoxGorev.Text == "Seçiniz.." ||
                comboBoxDurum.Text == "Seçiniz..")
            {
                MessageBox.Show("İçerik Alanları Boş Olamaz", "Uyarı");
            }
            else
            {
                secim = MessageBox.Show("Kullanıcı Bilgileri Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {

                    Product product = new Product
                    {
                        PERSONEL_ID = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        PERSONEL_TC_NO = textBoxTcNo.Text,
                        PERSONEL_AD = tbxAdi.Text,
                        PERSONEL_SOYAD = tbxSoyadi.Text,
                        PERSONEL_DOGUM_TARIH = dateTimeDogum.Value,
                        PERSONEL_CINSIYET = comboBoxCinsiyet.Text,
                        PERSONEL_UYRUK = comboBoxUyruk.Text,
                        PERSONEL_TELEFON = textBoxTelefon.Text,
                        PERSONEL_GOREV = comboBoxGorev.Text,
                        PERSONEL_EMAIL = textEmail.Text,
                        PERSONEL_DURUM = comboBoxDurum.Text

                    };
                    _productDal.Update(product);
                    LoadProducts();
                    //MessageBox.Show("Veri Güncellendi.", "Uyarı");
                    Temizle();
                    
                }
            }
        }
        #endregion

        #region Silme İşlemi
        private void btnRemove_Click(object sender, EventArgs e)
        {
                secim = MessageBox.Show("Kullanıcıyı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
                    _productDal.Delete(id);

                    MessageBox.Show("Kullanıcı Silinmiştir.", "Uyarı");
                    Temizle();
                    LoadProducts();
                }
            
        }
        #endregion

        #region Arama İşlemi
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxAdi.Text == "")
            {
                MessageBox.Show("Sadece Personel Adı Üzeriden Arama Yapabilirsiniz.", "Uyarı");
                Temizle();
                LoadProducts();
            }

            else
            {
                AramaProducts(tbxAdi.Text);

            }
        }
        #endregion

        #region İçerik Temizleme İşlemi
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            secim = MessageBox.Show("İçerik Alanlarını Temizlemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {


                Temizle();
                LoadProducts();
                MessageBox.Show("İçerik Alanları Temzilenmiştir.", "Uyarı");

            }
        }
        #endregion
        
        #region İçerik Girme Alanlarını Temizle
        private void Temizle()
        {
            tbxAdi.Text = "";
            tbxSoyadi.Text = "";
            textBoxTcNo.Text = "";
            comboBoxCinsiyet.Text = "Seçiniz..";
            comboBoxUyruk.Text = "Seçiniz..";
            comboBoxGorev.Text = "Seçiniz..";
            textBoxTelefon.Text = "";
            textEmail.Text = "";
            comboBoxDurum.Text = "Seçiniz..";
        }

        #endregion


    private void renklendirme()
        {
            for (int i = 0; i < dgwProducts.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToString(dgwProducts.Rows[i].Cells["PERSONEL_DURUM"].Value) == "AYRILDI")
                {

                    renk.BackColor = Color.White;
                    renk.ForeColor = Color.Red;
                }
                //else
                //{
                //    renk.BackColor = Color.Red;
                //}

                dgwProducts.Rows[i].DefaultCellStyle = renk;

            }

        }

           }
}
