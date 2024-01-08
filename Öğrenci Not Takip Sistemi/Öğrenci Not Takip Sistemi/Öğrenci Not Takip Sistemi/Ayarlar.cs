using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Not_Takip_Sistemi
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        //Bu kısımda temayı değiştiriyorum ancak tercihleri kayıt edemiyorum. Tekrar açınca default şekilde geliyor.
   
        private void radioButtonMavi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
            panel1.BackColor = Color.LightBlue;            
            OgrenciBilgileri ogrenciBilgileri = (OgrenciBilgileri)Application.OpenForms["OgrenciBilgileri"];
            ogrenciBilgileri.BackColor = Color.SkyBlue; 
            ogrenciBilgileri.panel1.BackColor = Color.LightBlue;
            ogrenciBilgileri.panel2.BackColor = Color.LightBlue;
        }

        private void radioButtonGri_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            panel1.BackColor = Color.LightGray;
            OgrenciBilgileri ogrenciBilgileri = (OgrenciBilgileri)Application.OpenForms["OgrenciBilgileri"];
            ogrenciBilgileri.BackColor = Color.Gray;
            ogrenciBilgileri.panel1.BackColor = Color.LightGray;
            ogrenciBilgileri.panel2.BackColor = Color.LightGray;
        }

        private void radioButtonPembe_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleVioletRed;
            panel1.BackColor = Color.Pink;
            OgrenciBilgileri ogrenciBilgileri = (OgrenciBilgileri)Application.OpenForms["OgrenciBilgileri"];
            ogrenciBilgileri.BackColor = Color.PaleVioletRed;
            ogrenciBilgileri.panel1.BackColor = Color.Pink;
            ogrenciBilgileri.panel2.BackColor = Color.Pink;            
        }

        private void radioButtonYesil_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.SeaGreen;
            panel1.BackColor = Color.DarkSeaGreen;
            OgrenciBilgileri ogrenciBilgileri = (OgrenciBilgileri)Application.OpenForms["OgrenciBilgileri"];
            ogrenciBilgileri.BackColor = Color.SeaGreen;
            ogrenciBilgileri.panel1.BackColor = Color.DarkSeaGreen;
            ogrenciBilgileri.panel2.BackColor = Color.DarkSeaGreen;           
        }   
    }
}
