using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace Proje3_SiparişOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }

        public static string girenkullanici;
        public static string girensehir;
        public static Magaza GonderilecekNesne;
        public bool kontrol = false;
        public void btnGiris_Click(object sender, EventArgs e)
        {
            
            
            string dosyayolu = @Application.StartupPath + "\\veri.txt";
            string satilandosyayolu = @Application.StartupPath + "\\satilanlar.txt";
            if (File.Exists(dosyayolu) == false)
            {
                StreamWriter SW;
                SW = File.CreateText(Application.StartupPath + "\\veri.txt");
                SW.Close();
            }
            
            else
            {

                if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "admin")
                {
                    AdminForm a = new AdminForm();
                    a.Show();
                    this.Hide();
                    kontrol = true;
                }

                else
                {
                    string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
                    foreach (string line in hepsi)
                    {
                        if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
                        {
                            MessageBox.Show("Lütfen Kullanıcı Adınızı Ve Şifrenizi Giriniz...");
                            kontrol = true;
                            break;

                        }
                        if (line.Contains(txtKullaniciAdi.Text + " " + txtSifre.Text))
                        {
                            MessageBox.Show("Giriş Başarılı!\nHoşgeldiniz...");
                            Müsteriler m = new Müsteriler();
                            m.KullaniciAdi = line.Split(' ')[0];
                            m.Sifre = line.Split(' ')[1];
                            m.Ad = line.Split(' ')[2];
                            m.Soyad = line.Split(' ')[3];
                            m.Sehir = line.Split(' ')[4];
                            Magaza ma = new Magaza();
                            ma.MusteriEkle(m);
                            GonderilecekNesne = ma;
                            girenkullanici = txtKullaniciAdi.Text;
                            girensehir = line.Split(' ')[4];
                            MainForm main = new MainForm();
                            this.Hide();
                            main.Show();
                            kontrol = true;
                            break;
                        }
                        else
                        {
                            kontrol = false;
                        }
                    }
                }

            }

            if (kontrol == false)
            {
                
                MessageBox.Show("Kaydınız Bulunamadı!\nLütfen Kayıt Olunuz...");

            }

            if (File.Exists(satilandosyayolu) == false)
            {
                StreamWriter SW;
                SW = File.CreateText(Application.StartupPath + "\\satilanlar.txt");
                SW.Close();
            }

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayıtForm f2 = new KayıtForm();
            this.Hide();
            f2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Şifreyi Gizle";
                
            }
            else if(checkBox1.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Şifreyi Göster";
            }
        }
    }
}
