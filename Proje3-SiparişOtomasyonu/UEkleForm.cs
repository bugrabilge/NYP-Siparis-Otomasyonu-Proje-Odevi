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
    public partial class UEkleForm : Form
    {
        public UEkleForm()
        {
            InitializeComponent();
        }
        public string GirisYapanKullanici;
        public Magaza ListTutanMagaza;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle();
            TextboxlariTemizle();
        }

        public void UrunEkle()
        {
            DisardanBilgileriCek();

            string filePath = Application.StartupPath + "\\veri.txt";
            string[] lines = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(GirisYapanKullanici))
                {
                    lines[i] = lines[i] + " " + txtUrunEkleAd.Text + " " + txtUrunEkleMarka.Text + " " + txtUrunEkleModel.Text + " "
                        + txtUrunEkleFiyat.Text + " " + txtUrunEkleAgirlik.Text + " " + txtUrunEkleAdet.Text;
                    MessageBox.Show("Ürününüz Başarıyla Eklenmiştir...");
                    break;
                }
            }

            Urun u = new Urun
            {
                Tanım = txtUrunEkleAd.Text,
                Marka = txtUrunEkleMarka.Text,
                Model = txtUrunEkleModel.Text
            };
            u.MiktarIcinFiyatAl(txtUrunEkleFiyat.Text);
            u.AgirlikAl(txtUrunEkleAgirlik.Text);

            foreach (Müsteriler müsteri in ListTutanMagaza.MusteriListesi)
            {

                if (müsteri.KullaniciAdi == GirisYapanKullanici)
                {
                    müsteri.ListemeUrunEkle(u);                   
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        public void TextboxlariTemizle()
        {
            txtUrunEkleAd.Clear();
            txtUrunEkleMarka.Clear();
            txtUrunEkleModel.Clear();
            txtUrunEkleFiyat.Clear();
            txtUrunEkleAgirlik.Clear();
            txtUrunEkleAdet.Clear();
        }

        private void DisardanBilgileriCek()
        {
            GirisYapanKullanici = Form1.girenkullanici;
            ListTutanMagaza = Form1.GonderilecekNesne;
        }

        private void UEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
