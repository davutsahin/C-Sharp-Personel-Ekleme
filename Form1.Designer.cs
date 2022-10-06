namespace Personel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.unitPrice = new System.Windows.Forms.Label();
            this.tbxAdi = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxSoyadi = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.buttonArana = new System.Windows.Forms.Button();
            this.Cinsiyetlabel = new System.Windows.Forms.Label();
            this.TcNolabel = new System.Windows.Forms.Label();
            this.labelMediniDurum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.comboBoxDurum = new System.Windows.Forms.ComboBox();
            this.comboBoxGorev = new System.Windows.Forms.ComboBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.dateTimeDogum = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUyruk = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTcNo = new System.Windows.Forms.TextBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 850);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "V1.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1614, 850);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = " © 2022 DAVUT ŞAHİN Tüm hakları saklıdır.";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.jpg");
            this.ımageList1.Images.SetKeyName(1, "ekele.jpg");
            this.ımageList1.Images.SetKeyName(2, "guncelle.jpg");
            this.ımageList1.Images.SetKeyName(3, "clear.png");
            this.ımageList1.Images.SetKeyName(4, "listeli.png");
            this.ımageList1.Images.SetKeyName(5, "sil.png");
            this.ımageList1.Images.SetKeyName(6, "ekle.png");
            this.ımageList1.Images.SetKeyName(7, "ara.png");
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSize = true;
            this.unitPrice.Location = new System.Drawing.Point(4, 96);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(65, 19);
            this.unitPrice.TabIndex = 3;
            this.unitPrice.Text = "SOYAD";
            // 
            // tbxAdi
            // 
            this.tbxAdi.Location = new System.Drawing.Point(72, 34);
            this.tbxAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAdi.Name = "tbxAdi";
            this.tbxAdi.Size = new System.Drawing.Size(201, 27);
            this.tbxAdi.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(4, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ADI*";
            // 
            // tbxSoyadi
            // 
            this.tbxSoyadi.Location = new System.Drawing.Point(72, 90);
            this.tbxSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSoyadi.Name = "tbxSoyadi";
            this.tbxSoyadi.Size = new System.Drawing.Size(201, 27);
            this.tbxSoyadi.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.ImageKey = "listeli.png";
            this.btnUpdate.ImageList = this.ımageList1;
            this.btnUpdate.Location = new System.Drawing.Point(1753, 153);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 89);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(1051, 86);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(215, 27);
            this.textEmail.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.ImageKey = "ekle.png";
            this.btnRemove.ImageList = this.ımageList1;
            this.btnRemove.Location = new System.Drawing.Point(1773, 18);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 89);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Sil";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(939, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-POSTA";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.ImageKey = "ekle.png";
            this.btnAdd.ImageList = this.ımageList1;
            this.btnAdd.Location = new System.Drawing.Point(1628, 153);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 89);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTemizle.ImageKey = "clear.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(129, 153);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 89);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // buttonArana
            // 
            this.buttonArana.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonArana.ImageKey = "ara.png";
            this.buttonArana.ImageList = this.ımageList1;
            this.buttonArana.Location = new System.Drawing.Point(7, 153);
            this.buttonArana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonArana.Name = "buttonArana";
            this.buttonArana.Size = new System.Drawing.Size(77, 89);
            this.buttonArana.TabIndex = 11;
            this.buttonArana.Text = "Ara";
            this.buttonArana.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonArana.UseVisualStyleBackColor = true;
            this.buttonArana.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cinsiyetlabel
            // 
            this.Cinsiyetlabel.AutoSize = true;
            this.Cinsiyetlabel.Location = new System.Drawing.Point(291, 96);
            this.Cinsiyetlabel.Name = "Cinsiyetlabel";
            this.Cinsiyetlabel.Size = new System.Drawing.Size(84, 19);
            this.Cinsiyetlabel.TabIndex = 14;
            this.Cinsiyetlabel.Text = "CİNSİYET";
            // 
            // TcNolabel
            // 
            this.TcNolabel.AutoSize = true;
            this.TcNolabel.Location = new System.Drawing.Point(291, 37);
            this.TcNolabel.Name = "TcNolabel";
            this.TcNolabel.Size = new System.Drawing.Size(58, 19);
            this.TcNolabel.TabIndex = 12;
            this.TcNolabel.Text = "TC NO";
            // 
            // labelMediniDurum
            // 
            this.labelMediniDurum.AutoSize = true;
            this.labelMediniDurum.Location = new System.Drawing.Point(1288, 96);
            this.labelMediniDurum.Name = "labelMediniDurum";
            this.labelMediniDurum.Size = new System.Drawing.Size(78, 19);
            this.labelMediniDurum.TabIndex = 18;
            this.labelMediniDurum.Text = "DURUMU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1288, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "GÖREV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "UYRUK";
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.AccessibleName = "";
            this.comboBoxCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Seçiniz..",
            "ERKEK",
            "KADIN"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(392, 90);
            this.comboBoxCinsiyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(201, 27);
            this.comboBoxCinsiyet.TabIndex = 24;
            this.comboBoxCinsiyet.Tag = "";
            // 
            // comboBoxDurum
            // 
            this.comboBoxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDurum.FormattingEnabled = true;
            this.comboBoxDurum.Items.AddRange(new object[] {
            "Seçiniz..",
            "DEVAM EDİYOR",
            "AYRILDI",
            "İZİNDE"});
            this.comboBoxDurum.Location = new System.Drawing.Point(1407, 89);
            this.comboBoxDurum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDurum.Name = "comboBoxDurum";
            this.comboBoxDurum.Size = new System.Drawing.Size(215, 27);
            this.comboBoxDurum.TabIndex = 25;
            // 
            // comboBoxGorev
            // 
            this.comboBoxGorev.AccessibleName = "";
            this.comboBoxGorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGorev.FormattingEnabled = true;
            this.comboBoxGorev.Items.AddRange(new object[] {
            "Seçiniz..",
            "MEMUR",
            "YAZILIMCI",
            "HEKİM",
            "MİMAR",
            "STATJER"});
            this.comboBoxGorev.Location = new System.Drawing.Point(1407, 34);
            this.comboBoxGorev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGorev.Name = "comboBoxGorev";
            this.comboBoxGorev.Size = new System.Drawing.Size(215, 27);
            this.comboBoxGorev.TabIndex = 26;
            this.comboBoxGorev.Tag = "";
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbxAdd.Controls.Add(this.dateTimeDogum);
            this.gbxAdd.Controls.Add(this.comboBoxUyruk);
            this.gbxAdd.Controls.Add(this.label5);
            this.gbxAdd.Controls.Add(this.textBoxTelefon);
            this.gbxAdd.Controls.Add(this.label8);
            this.gbxAdd.Controls.Add(this.comboBoxGorev);
            this.gbxAdd.Controls.Add(this.comboBoxDurum);
            this.gbxAdd.Controls.Add(this.comboBoxCinsiyet);
            this.gbxAdd.Controls.Add(this.label3);
            this.gbxAdd.Controls.Add(this.label4);
            this.gbxAdd.Controls.Add(this.labelMediniDurum);
            this.gbxAdd.Controls.Add(this.TcNolabel);
            this.gbxAdd.Controls.Add(this.textBoxTcNo);
            this.gbxAdd.Controls.Add(this.Cinsiyetlabel);
            this.gbxAdd.Controls.Add(this.buttonArana);
            this.gbxAdd.Controls.Add(this.btnTemizle);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.btnRemove);
            this.gbxAdd.Controls.Add(this.textEmail);
            this.gbxAdd.Controls.Add(this.btnUpdate);
            this.gbxAdd.Controls.Add(this.tbxSoyadi);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxAdi);
            this.gbxAdd.Controls.Add(this.unitPrice);
            this.gbxAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(28, 11);
            this.gbxAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxAdd.Size = new System.Drawing.Size(1869, 254);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Personel Ekleme, Silme, Güncelleme  ve Arama Paneli";
            // 
            // dateTimeDogum
            // 
            this.dateTimeDogum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeDogum.Location = new System.Drawing.Point(753, 90);
            this.dateTimeDogum.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeDogum.Name = "dateTimeDogum";
            this.dateTimeDogum.Size = new System.Drawing.Size(173, 27);
            this.dateTimeDogum.TabIndex = 32;
            // 
            // comboBoxUyruk
            // 
            this.comboBoxUyruk.AccessibleName = "";
            this.comboBoxUyruk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUyruk.FormattingEnabled = true;
            this.comboBoxUyruk.Items.AddRange(new object[] {
            "Seçiniz..",
            "Türkiye",
            "Diğer",
            "Afganistan",
            "Almanya",
            "Arjantin",
            "Avustralya",
            "Belçika ",
            "Brezilya",
            "Bulgaristan",
            "Cezayir",
            "Çin",
            "Kıbrıs",
            "Mısır",
            "İngiltere",
            "Fransa",
            "Kanada",
            "Şili"});
            this.comboBoxUyruk.Location = new System.Drawing.Point(753, 34);
            this.comboBoxUyruk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUyruk.Name = "comboBoxUyruk";
            this.comboBoxUyruk.Size = new System.Drawing.Size(173, 27);
            this.comboBoxUyruk.TabIndex = 31;
            this.comboBoxUyruk.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(939, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "TELEFON";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(1051, 36);
            this.textBoxTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(215, 27);
            this.textBoxTelefon.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "DOĞUM TARİHİ";
            // 
            // textBoxTcNo
            // 
            this.textBoxTcNo.Location = new System.Drawing.Point(392, 37);
            this.textBoxTcNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTcNo.Name = "textBoxTcNo";
            this.textBoxTcNo.Size = new System.Drawing.Size(201, 27);
            this.textBoxTcNo.TabIndex = 13;
            // 
            // dgwProducts
            // 
            this.dgwProducts.AllowUserToAddRows = false;
            this.dgwProducts.AllowUserToDeleteRows = false;
            this.dgwProducts.AllowUserToOrderColumns = true;
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(27, 270);
            this.dgwProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.RowTemplate.Height = 40;
            this.dgwProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProducts.Size = new System.Drawing.Size(1871, 542);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 879);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "PERSONEL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.TextBox tbxAdi;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxSoyadi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button buttonArana;
        private System.Windows.Forms.Label Cinsiyetlabel;
        private System.Windows.Forms.Label TcNolabel;
        private System.Windows.Forms.Label labelMediniDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.ComboBox comboBoxDurum;
        private System.Windows.Forms.ComboBox comboBoxGorev;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxUyruk;
        private System.Windows.Forms.DateTimePicker dateTimeDogum;
        private System.Windows.Forms.TextBox textBoxTcNo;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}

