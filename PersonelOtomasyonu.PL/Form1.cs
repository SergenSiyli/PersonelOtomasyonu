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
using System.IO;

namespace PersonelOtomasyonu.PL
{
    public partial class Form1 : Form
    {
        PersonelBilgileriRepository pp = new PersonelBilgileriRepository();
        Personeller tut;
        byte[] foto=null;

        public Form1()
        {
            InitializeComponent();
        }
        string fotografyeri = "";
       
        private void Form1_Load(object sender, EventArgs e)
        {

            VerileriGetir();
        }
        void VerileriGetir()
        {
            dataGridView1.DataSource = pp.TumunuSec().ToList();
        }

        private void Temizle(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tx = (TextBox)item;
                    tx.Clear();
                }
                if(item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }
                if(item is PictureBox)
                {
                    PictureBox px = (PictureBox)item;
                    px.Image = null;
                }
                if (item.Controls.Count > 0)
                {
                    Temizle(item);
                }
            }
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {

            try
            {
               
                Personeller p = new Personeller();
                p.TcNO = tcnotxt.Text;
                p.PersonelAdi = adtxt.Text;
                p.PersonelSoyadi = soyadtxt.Text;
                p.DogumTarihi = dogumtarihipicker.Value;
                p.Telefon = teltxt.Text;
                p.MailAdresi = mailtxt.Text;
                p.Unvan = unvantxt.Text;
                p.EvAdresi = adrestxt.Text;
                p.İseGirisTarihi = ısegirispicker.Value;
                FileStream ff = new FileStream(fotografyeri, FileMode.Open, FileAccess.Read);
                BinaryReader brd = new BinaryReader(ff);
                foto = brd.ReadBytes((int)ff.Length);
                p.Fotografi = foto;
                pp.Ekle(p);
                MessageBox.Show("Yeni Personel Eklendi.");
                Temizle(this);
                VerileriGetir();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void resimsecbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fotografyeri = dialog.FileName.ToString();
                fotopicturebox.ImageLocation = fotografyeri;
            }

            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                tut = (Personeller)dataGridView1.CurrentRow.DataBoundItem;
                tcnotxt.Text = tut.TcNO;
                adtxt.Text = tut.PersonelAdi;
                soyadtxt.Text = tut.PersonelSoyadi;
                dogumtarihipicker.Value = tut.DogumTarihi;
                teltxt.Text = tut.Telefon;
                mailtxt.Text = tut.MailAdresi;
                unvantxt.Text = tut.Unvan;
                adrestxt.Text = tut.EvAdresi;
                ısegirispicker.Value = tut.İseGirisTarihi;
                MemoryStream mst = new MemoryStream(tut.Fotografi);
                fotopicturebox.Image = Image.FromStream(mst);
                VerileriGetir();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Seçiniz");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int silinecek = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                pp.Sil(silinecek);
                MessageBox.Show("Seçilen Personel Başarıyla Silindi.");

                VerileriGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Yaptınız.");

            }
        }

        private void guncbtn_Click(object sender, EventArgs e)
        {
            try
            {
                tut.TcNO = tcnotxt.Text;
                tut.PersonelAdi = adtxt.Text;
                tut.PersonelSoyadi = soyadtxt.Text;
                tut.DogumTarihi = dogumtarihipicker.Value;
                tut.Telefon = teltxt.Text;
                tut.MailAdresi = mailtxt.Text;
                tut.Unvan = unvantxt.Text;
                tut.EvAdresi = adrestxt.Text;
                tut.İseGirisTarihi = ısegirispicker.Value;
                FileStream ff = new FileStream(fotografyeri, FileMode.Open, FileAccess.Read);
                BinaryReader brd = new BinaryReader(ff);
                foto = brd.ReadBytes((int)ff.Length);
                tut.Fotografi = foto;
                pp.Guncelle(tut);
                MessageBox.Show("Seçilen Personel Başarıyla Güncellendi.");

                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelecek = textBox1.Text;
            pp.AramaYap(gelecek).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gelecek = textBox1.Text;
            pp.AramaYap(gelecek).ToList();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string gelecek = textBox1.Text;

            dataGridView1.DataSource = pp.AramaYap(gelecek).ToList();
        }
           
          
        
    }
}
