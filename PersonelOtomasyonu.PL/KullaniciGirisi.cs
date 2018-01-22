using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonelOtomasyonu.DAL;
using PersonelOtomasyonu.BLL;

namespace PersonelOtomasyonu.PL
{
    public partial class KullaniciGirisi : Form
    {
        Kullanici kk = new Kullanici();
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void grsyapbtn_Click(object sender, EventArgs e)
        {
                Form1 fm = new Form1();

                string kullaniciadi = kaditxt.Text;
                string sifre = sifretxt.Text;
                bool deger=kk.kullanicigirisi(kullaniciadi, sifre);
            if (deger == true)
            {
                fm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Girişi");
                temizle();
            }

        }
        void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox tx = (TextBox)item;
                    tx.Clear();
                }
            }
        }
    }
}
