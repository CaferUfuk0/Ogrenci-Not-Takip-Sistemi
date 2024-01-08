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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)  //Kullanıcı giriş bilgileri.
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Giriniz.");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Şifre Giriniz.");
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                OgrenciBilgileri formOgr = new OgrenciBilgileri();
                formOgr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız.");
            }
        }

        private void chckShowPass_CheckedChanged(object sender, EventArgs e) //Şifreyi gizleme veya gösterme.
        {
            if (chckShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
