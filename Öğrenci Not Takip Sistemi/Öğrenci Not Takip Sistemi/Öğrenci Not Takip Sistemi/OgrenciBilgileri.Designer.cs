namespace Öğrenci_Not_Takip_Sistemi
{
    partial class OgrenciBilgileri
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciBilgileri));
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.listViewKayitlar = new System.Windows.Forms.ListView();
            this.columnHeaderAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSinif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrtalama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNo = new System.Windows.Forms.MaskedTextBox();
            this.txtClass = new System.Windows.Forms.MaskedTextBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelNumara = new System.Windows.Forms.Label();
            this.labeSinif = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSurname = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labelAra = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.MaskedTextBox();
            this.txt1 = new System.Windows.Forms.MaskedTextBox();
            this.txt2 = new System.Windows.Forms.MaskedTextBox();
            this.txt3 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOgrNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.MaskedTextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciEkle.Location = new System.Drawing.Point(17, 211);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(92, 43);
            this.btnOgrenciEkle.TabIndex = 6;
            this.btnOgrenciEkle.Text = "Öğrenciyi Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // listViewKayitlar
            // 
            this.listViewKayitlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAd,
            this.columnHeaderSoyad,
            this.columnHeaderNumara,
            this.columnHeaderSinif,
            this.columnHeaderOrtalama});
            this.listViewKayitlar.FullRowSelect = true;
            this.listViewKayitlar.GridLines = true;
            this.listViewKayitlar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewKayitlar.HideSelection = false;
            this.listViewKayitlar.Location = new System.Drawing.Point(245, 40);
            this.listViewKayitlar.Name = "listViewKayitlar";
            this.listViewKayitlar.Size = new System.Drawing.Size(375, 265);
            this.listViewKayitlar.TabIndex = 9;
            this.listViewKayitlar.UseCompatibleStateImageBehavior = false;
            this.listViewKayitlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderAd
            // 
            this.columnHeaderAd.Text = "Adı";
            this.columnHeaderAd.Width = 90;
            // 
            // columnHeaderSoyad
            // 
            this.columnHeaderSoyad.Text = "Soyadı";
            this.columnHeaderSoyad.Width = 90;
            // 
            // columnHeaderNumara
            // 
            this.columnHeaderNumara.Text = "Numarası";
            this.columnHeaderNumara.Width = 85;
            // 
            // columnHeaderSinif
            // 
            this.columnHeaderSinif.Text = "Sınıfı";
            this.columnHeaderSinif.Width = 50;
            // 
            // columnHeaderOrtalama
            // 
            this.columnHeaderOrtalama.Text = "Ortalama";
            this.columnHeaderOrtalama.Width = 55;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(103, 123);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 3;
            this.txtNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxNumara_KeyPress);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(103, 163);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 5;
            this.txtClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxSinif_KeyPress);
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(55, 51);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(31, 14);
            this.labelAd.TabIndex = 7;
            this.labelAd.Text = "Adı:";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelSoyad.Location = new System.Drawing.Point(34, 87);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(52, 14);
            this.labelSoyad.TabIndex = 8;
            this.labelSoyad.Text = "Soyadı:";
            // 
            // labelNumara
            // 
            this.labelNumara.AutoSize = true;
            this.labelNumara.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelNumara.Location = new System.Drawing.Point(20, 125);
            this.labelNumara.Name = "labelNumara";
            this.labelNumara.Size = new System.Drawing.Size(66, 14);
            this.labelNumara.TabIndex = 9;
            this.labelNumara.Text = "Numarası:";
            // 
            // labeSinif
            // 
            this.labeSinif.AutoSize = true;
            this.labeSinif.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labeSinif.Location = new System.Drawing.Point(45, 165);
            this.labeSinif.Name = "labeSinif";
            this.labeSinif.Size = new System.Drawing.Size(41, 14);
            this.labeSinif.TabIndex = 10;
            this.labeSinif.Text = "Sınıfı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.buttonSil);
            this.panel1.Controls.Add(this.btnOgrenciEkle);
            this.panel1.Controls.Add(this.labeSinif);
            this.panel1.Controls.Add(this.labelNumara);
            this.panel1.Controls.Add(this.labelSoyad);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.labelAd);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 294);
            this.panel1.TabIndex = 11;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(103, 85);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoyad_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAd_KeyPress);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSil.Location = new System.Drawing.Point(117, 211);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(95, 43);
            this.buttonSil.TabIndex = 7;
            this.buttonSil.Text = "Öğrenciyi Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(520, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labelAra
            // 
            this.labelAra.AutoSize = true;
            this.labelAra.Location = new System.Drawing.Point(482, 14);
            this.labelAra.Name = "labelAra";
            this.labelAra.Size = new System.Drawing.Size(26, 13);
            this.labelAra.TabIndex = 14;
            this.labelAra.Text = "Ara:";
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSettings.Location = new System.Drawing.Point(245, 11);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGüncelle.Location = new System.Drawing.Point(752, 262);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(80, 39);
            this.btnGüncelle.TabIndex = 20;
            this.btnGüncelle.Text = "Ortalamayı Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt4);
            this.panel2.Controls.Add(this.txt1);
            this.panel2.Controls.Add(this.txt2);
            this.panel2.Controls.Add(this.txt3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSonuc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelSonuc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(631, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 214);
            this.panel2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Not Ortalaması:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(112, 122);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(64, 20);
            this.txt4.TabIndex = 6;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(112, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(64, 20);
            this.txt1.TabIndex = 3;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(112, 50);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(64, 20);
            this.txt2.TabIndex = 4;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(112, 87);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(64, 20);
            this.txt3.TabIndex = 5;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "1. Sınav";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(111, 163);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(64, 20);
            this.txtSonuc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "2. Sınav";
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(181, 166);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(7, 13);
            this.labelSonuc.TabIndex = 9;
            this.labelSonuc.Text = "\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "3. Sınav";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "4. Sınav";
            // 
            // labelOgrNum
            // 
            this.labelOgrNum.AutoSize = true;
            this.labelOgrNum.Location = new System.Drawing.Point(635, 19);
            this.labelOgrNum.Name = "labelOgrNum";
            this.labelOgrNum.Size = new System.Drawing.Size(94, 13);
            this.labelOgrNum.TabIndex = 19;
            this.labelOgrNum.Text = "Öğrenci Numarası:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(737, 16);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(76, 20);
            this.txtNum.TabIndex = 16;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnHesapla.Location = new System.Drawing.Point(657, 262);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 39);
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // OgrenciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(865, 311);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelOgrNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.labelAra);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewKayitlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(881, 350);
            this.MinimumSize = new System.Drawing.Size(881, 350);
            this.Name = "OgrenciBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Takip Sistemi";
            this.Load += new System.EventHandler(this.OgrenciBilgileri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.ColumnHeader columnHeaderAd;
        private System.Windows.Forms.ColumnHeader columnHeaderSoyad;
        private System.Windows.Forms.ColumnHeader columnHeaderNumara;
        private System.Windows.Forms.ColumnHeader columnHeaderSinif;
        private System.Windows.Forms.ColumnHeader columnHeaderOrtalama;
        private System.Windows.Forms.MaskedTextBox txtNo;
        private System.Windows.Forms.MaskedTextBox txtClass;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelNumara;
        private System.Windows.Forms.Label labeSinif;
        private System.Windows.Forms.Button buttonSil;
        public System.Windows.Forms.ListView listViewKayitlar;
        private System.Windows.Forms.MaskedTextBox txtSurname;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labelAra;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGüncelle;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txt4;
        private System.Windows.Forms.MaskedTextBox txt1;
        private System.Windows.Forms.MaskedTextBox txt2;
        private System.Windows.Forms.MaskedTextBox txt3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOgrNum;
        private System.Windows.Forms.MaskedTextBox txtNum;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Label label5;
    }
}

