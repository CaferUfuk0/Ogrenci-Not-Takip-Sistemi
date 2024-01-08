using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Öğrenci_Not_Takip_Sistemi
{
    public partial class OgrenciBilgileri : Form
    {
        // Ögrencinin bilgilerini temsil eden sınıf.
        public class ogrenci
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Number {  get; set; }
            public string Class { get; set; }
            public double Average { get; set; }


            public ogrenci(string ad, string soyad, string numara, string sinif)
            {
                Name = ad;
                Surname = soyad;
                Number = numara;
                Class = sinif;
                Average = 0;
            }          
        }
        private List<ogrenci> ogrenciListesi = new List<ogrenci>();
        
        public OgrenciBilgileri()
        {
            InitializeComponent();
            txtLoad();
        }
        public string studentNo;
        public string avgPoint;

        private void btnOgrenciEkle_Click(object sender, EventArgs e) //Öğrenci ekleme kısmı.
        {
            try
            {
                string ad = txtName.Text;
                string soyad = txtSurname.Text;
                string numara = txtNo.Text;
                string sinif = txtClass.Text;

                // Bilgilerin eksiksiz olup olmadığını kontrol et.
                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(numara) || string.IsNullOrEmpty(sinif))
                {
                    MessageBox.Show("Lütfen tüm bilgileri doldurunuz.");
                    return;
                }
                // Aynı numaraya sahip öğrenci olup olmadığını kontrol et.
                if (ogrenciListesi.Any(ogrenci => ogrenci.Number == numara))
                {
                    MessageBox.Show("Bu numaraya sahip öğrenci zaten var.");
                    return;
                }
                // Yeni öğrenci oluştur ve listeye ekle
                ogrenci yeniOgrenci = new ogrenci(ad, soyad, numara, sinif);
                ogrenciListesi.Add(yeniOgrenci);

                ListViewItem item = new ListViewItem(new string[] { yeniOgrenci.Name, yeniOgrenci.Surname, yeniOgrenci.Number, yeniOgrenci.Class });
                listViewKayitlar.Items.Add(item);

                txtName.Clear();
                txtSurname.Clear();
                txtNo.Clear();
                txtClass.Clear();

                MessageBox.Show("Öğrenci eklendi.");

                txtSave();
                txtLoad();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)  //Öğrenci silme kısmı.
        {
            
            if (listViewKayitlar.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewKayitlar.SelectedItems[0];
                string numara = selectedItem.SubItems[2].Text;

                ogrenci silinecekOgrenci = ogrenciListesi.Find(o => o.Number == numara);
                if (silinecekOgrenci != null)
                {
                    ogrenciListesi.Remove(silinecekOgrenci);
                    listViewKayitlar.Items.Remove(selectedItem);

                    MessageBox.Show("Öğrenci silindi.");
                }
            }
            else
            {
                MessageBox.Show("Silinecek öğrenciyi seçiniz.");
            }
            txtSave();
            txtLoad();
        }

        private void txtSave()  // Öğrenci bilgilerini dosyaya kaydetme.
        {
            using (StreamWriter sw = new StreamWriter("ogrencikayitlari.txt"))
            {
                CultureInfo culture = CultureInfo.InvariantCulture; // Öğrencinin ortalamasını virgüllü değil noktalı şekilde kaydetmek için ekledim.

                foreach (var ogrenci in ogrenciListesi)
                {
                    sw.WriteLine($"{ogrenci.Name},{ogrenci.Surname},{ogrenci.Number},{ogrenci.Class},{ogrenci.Average.ToString(culture)}");
                }
            }
        }
        
        private void txtLoad()  // Kayıtları dosyadan yükleme.
        {
            ogrenciListesi.Clear();
            listViewKayitlar.Items.Clear();
            try
            {
                CultureInfo culture = CultureInfo.InvariantCulture; 

                using (StreamReader sr = new StreamReader("ogrencikayitlari.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 5)
                        {
                            ogrenci loadedOgrenci = new ogrenci(parts[0], parts[1], parts[2], parts[3]);

                            if (double.TryParse(parts[4], NumberStyles.Any, culture, out double average))
                            {
                                loadedOgrenci.Average = average;
                            }
                            ogrenciListesi.Add(loadedOgrenci);

                            ListViewItem item = new ListViewItem(new string[] { loadedOgrenci.Name, loadedOgrenci.Surname, loadedOgrenci.Number, loadedOgrenci.Class, loadedOgrenci.Average.ToString(culture) });
                            listViewKayitlar.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıtlar yüklenirken hata oluştu: {ex.Message}");
            }
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)  // Arama kutusuna girilen metne göre öğrenciyi bul.
        {
            string search = txtSearch.Text.ToLower();

            
            foreach (ListViewItem item in listViewKayitlar.Items)
            {
                bool findtxt = item.SubItems.Cast<ListViewItem.ListViewSubItem>()
                    .Any(subitem => subitem.Text.ToLower().Contains(search));

                item.BackColor = findtxt ? System.Drawing.Color.LightSkyBlue : System.Drawing.Color.White;
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e) //Öğrencinin ortalamasının hesaplandığı kısım.
        {
            double not1, not2, not3, not4, ortalama;

            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt2.Text) || string.IsNullOrWhiteSpace(txt3.Text) || string.IsNullOrWhiteSpace(txt4.Text))
            {
                MessageBox.Show("Lütfen tüm sınav notlarını doldurun.");
                return;
            }
            not1 = Convert.ToDouble(txt1.Text);
            not2 = Convert.ToDouble(txt2.Text);
            not3 = Convert.ToDouble(txt3.Text);
            not4 = Convert.ToDouble(txt4.Text);
            ortalama = (not1 + not2 + not3 + not4) / 4;
            txtSonuc.Text = ortalama.ToString();

            foreach (var ogrenci in ogrenciListesi)
            {
                if (ogrenci.Number == studentNo)
                {
                    ogrenci.Average = ortalama;
                    break;
                }
            }
            if (ortalama >= 50)
            {
                labelSonuc.Text = "Geçti.";
                labelSonuc.ForeColor = Color.Green;
            }
            else
            {
                labelSonuc.Text = "Kaldı.";
                labelSonuc.ForeColor = Color.Red;
            }
            txtSave();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)  // Öğrencinin not ortalamasını günceller.
        {
            studentNo = txtNum.Text;
            avgPoint = txtSonuc.Text;

            ListViewItem existingItem = FindItemByStudentNumber(studentNo);

            if (existingItem != null)
            {
                
                existingItem.SubItems[4].Text = avgPoint;

                foreach (var ogrenci in ogrenciListesi)
                {
                    if (ogrenci.Number == studentNo)
                    {
                        ogrenci.Average = Convert.ToDouble(avgPoint); 
                        break;
                    }
                }
                txtSave();           
            }
            else
            {
                MessageBox.Show("Kayıtlı öğrenci numarası bulunamadı.");
            }
        }
        public ListViewItem FindItemByStudentNumber(string studentNumber) // ListView'de öğrenci numarasına göre öğrenciyi bulan metot
        {
            foreach (ListViewItem item in listViewKayitlar.Items)
            {
                if (item.SubItems[2].Text == studentNumber)
                {
                    return item;
                }
            }
            return null;
        }

        private void OgrenciBilgileri_Load(object sender, EventArgs e) //Küçük tooltipler.
        {
            toolTip1.SetToolTip(btnOgrenciEkle, "Öğrenciyi listeye ekler.");
            toolTip2.SetToolTip(buttonSil, "Öğrenciyi listeden siler.");
            toolTip3.SetToolTip(btnHesapla, "Öğrencinin not ortalamasını hesaplar.");
            toolTip4.SetToolTip(btnGüncelle, "Öğrencinin not ortalamasını listeye ekler.");
            toolTip5.SetToolTip(btnSettings, "Kullanıcı ayarlarını açar.");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Ayarlar formSettings = new Ayarlar();
            formSettings.Show();
        }


        //TextBoxlara girilebilecekler.
        private void textBoxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxNumara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxSinif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}

