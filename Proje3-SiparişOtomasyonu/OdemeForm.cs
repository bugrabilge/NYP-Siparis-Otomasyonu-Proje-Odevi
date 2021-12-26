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
    public partial class OdemeForm : Form
    {
        public OdemeForm()
        {
            InitializeComponent();
        }

        public string GirisYapanKullanici;
        public string GirisYapanSehir;
        public string GirisYapanIsim;
        public string GirisYapanSoyisim;
        public Magaza ListTutanMagaza;
        public int ToplamUcret;
        public List<string> SatanKullanıcılarList;
        public List<string> SatılanUrunler;
        private void BtnOdemeKredi_Click_1(object sender, EventArgs e)
        {
            DisardanBilgileriCek();
            foreach (Müsteriler müsteri in ListTutanMagaza.MusteriListesi)
            {

                if (müsteri.KullaniciAdi == GirisYapanKullanici)
                {
                    müsteri.Kredi.KartNumarasi = Convert.ToUInt64(txtOdemeKartNo.Text);
                    müsteri.Kredi.CVC = Convert.ToInt32(txtOdemeKartCvc.Text);
                    müsteri.Kredi.Tip = comboBox1.SelectedItem.ToString();
                    müsteri.Kredi.SonKullanmaTarih = Convert.ToInt32(txtOdemeKartSon.Text);
                    müsteri.Siparis.Tarih = DateTime.Now;
                    müsteri.Siparis.Durum = "Kargo Bekleniyor";
                    MessageBox.Show("Siparişiniz Oluşturulmuştur...");
                    ToplamUcret = 0;

                }


                DosyaIslemleri(müsteri);


            }
            FormGecis();
        }

        private void btnOdemeCek_Click(object sender, EventArgs e)
        {

            DisardanBilgileriCek();

            foreach (Müsteriler müsteri in ListTutanMagaza.MusteriListesi)
            {

                if (müsteri.KullaniciAdi == GirisYapanKullanici)
                {
                    müsteri.Cek.BankaID = Convert.ToUInt64(txtOdemeBankaId.Text);
                    müsteri.Cek.CekAd = txtOdemeCekIsım.Text;
                    MessageBox.Show("Siparişiniz Oluşturulmuştur...");
                    ToplamUcret = 0;

                }

                DosyaIslemleri(müsteri);
            }
            FormGecis();
        }

        private void btnOdemeNakit_Click_1(object sender, EventArgs e)
        {
            DisardanBilgileriCek();

            foreach (Müsteriler müsteri in ListTutanMagaza.MusteriListesi)
            {
                müsteri.Nakit.Miktar = Convert.ToDecimal(ToplamUcret);
                MessageBox.Show("Siparişiniz Oluşturulmuştur...");
                ToplamUcret = 0;
                DosyaIslemleri(müsteri);
                FormGecis();
            }
        }
        private void FormGecis()
        {
            this.Hide();
        }
        private void OdemeForm_Load(object sender, EventArgs e)
        {
            ToplamUcret = UListeleForm.ToplamUcret;
            lblToplamUcret.Text = "Ödemeniz Gereken Ücret :" + ToplamUcret + " " + "TL'dir";
            txtOdemeNakitMiktar.Text = ToplamUcret.ToString();
        }

        private void DisardanBilgileriCek()
        {
            GirisYapanKullanici = Form1.girenkullanici;
            GirisYapanIsim = GirisForm.GirisYapanIsim;
            GirisYapanSoyisim = GirisForm.GirisYapanSoyisim;
            GirisYapanSehir = Form1.girensehir;
            ListTutanMagaza = Form1.GonderilecekNesne;
            SatanKullanıcılarList = UListeleForm.SatisYapanKullanicilar;
            SatılanUrunler = UListeleForm.SatılanUrunler;
        }

        private void DosyaIslemleri(Müsteriler m)
        {
            string fileName = @Application.StartupPath + "\\satilanlar.txt";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            string[] lines = File.ReadAllLines(Application.StartupPath + "\\satilanlar.txt");
            foreach (string satan in SatanKullanıcılarList)
            {
                var info = new FileInfo(fileName);

                if (m.KullaniciAdi == satan)
                {
                    m.UrunlerimeAtamaYap(SatılanUrunler, GirisYapanKullanici, GirisYapanSehir, GirisYapanIsim, GirisYapanSoyisim);
                }

                foreach (string satilanurun in SatılanUrunler)
                {
                    foreach (string line in hepsi)
                    {
                        if (line.StartsWith(satan) && line.Contains(satilanurun))
                        {
                            if (info.Length == 0)
                            {
                                File.AppendAllText(fileName, satan + " " + satilanurun + " " + GirisYapanKullanici + " " + GirisYapanIsim +
                                            " " + GirisYapanSoyisim + " " + GirisYapanSehir);
                            }
                            else
                            {

                                for (int i = 0; i < lines.Length; i++)
                                {

                                    if (i == lines.Length - 1)
                                    {
                                        File.AppendAllText(fileName, Environment.NewLine + satan + " " + satilanurun + " " + GirisYapanKullanici + " " + GirisYapanIsim +
                                            " " + GirisYapanSoyisim + " " + GirisYapanSehir);
                                        break;
                                    }
                                }

                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
