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
    public partial class SilinecekAdet : Form
    {
        public SilinecekAdet()
        {
            InitializeComponent();
        }
        public string GirisYapanKullanici;
        public int SilinmesiIstenenUrununSirasi;
        public Magaza ListTutanMagaza;
        public static bool Kapandı = false;
        public int SilinmesiIstenenAdet;
        private void txtSilinecekAdetCikar_Click(object sender, EventArgs e)
        {
            AdetCikar();
            this.Hide();
        }

        private void SilinecekAdet_Load(object sender, EventArgs e)
        {
            GirisYapanKullanici = Form1.girenkullanici;
            ListTutanMagaza = Form1.GonderilecekNesne;
        }

        public void AdetCikar()
        {
            SilinmesiIstenenAdet = Convert.ToInt32(txtSilinecekAdet.Text);
            Kapandı = true;
            SilinmesiIstenenUrununSirasi = UCikarForm.SilinmesiIstenenUrununSirasi;
            string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            foreach (string line in hepsi)
            {
                if (line.StartsWith(GirisYapanKullanici))
                {

                    for (int i = 1; i < ((line.Split(' ').Count() - 5) / 6 + 1); i++)
                    {

                        if (i == (SilinmesiIstenenUrununSirasi))
                        {

                            if (SilinmesiIstenenAdet < Convert.ToInt32(line.Split(' ')[6 * i + 4]))
                            {

                                File.WriteAllText(Application.StartupPath + "\\veri.txt",
                                    File.ReadAllText(Application.StartupPath + "\\veri.txt").Replace(line.Split(' ')[6 * i + 4],
                                    (Convert.ToInt32(line.Split(' ')[6 * i + 4]) - SilinmesiIstenenAdet).ToString()));
                                MessageBox.Show("Ürün Başarıyla Listenizden Çıkarılmıştır...");
                                break;
                            }

                            else
                            {
                                File.WriteAllText(Application.StartupPath + "\\veri.txt", File.ReadAllText(Application.StartupPath + "\\veri.txt").Replace(" " + line.Split(' ')[6 * i - 1], ""));
                                File.WriteAllText(Application.StartupPath + "\\veri.txt", File.ReadAllText(Application.StartupPath + "\\veri.txt").Replace(" " + line.Split(' ')[6 * i], ""));
                                File.WriteAllText(Application.StartupPath + "\\veri.txt", File.ReadAllText(Application.StartupPath + "\\veri.txt").Replace(" " + line.Split(' ')[6 * i + 1], ""));
                                File.WriteAllText(Application.StartupPath + "\\veri.txt", File.ReadAllText(Application.StartupPath + "\\veri.txt").Replace(" " + line.Split(' ')[6 * i + 2], ""));
                                File.WriteAllText(Application.StartupPath + "\\veri.txt", File.ReadAllText(Application.StartupPath + "\\veri.txt").Replace(" " + line.Split(' ')[6 * i + 3], ""));
                                File.WriteAllText(Application.StartupPath + "\\veri.txt", File.ReadAllText(Application.StartupPath + "\\veri.txt").Replace(" " + line.Split(' ')[6 * i + 4], ""));
                                foreach (Müsteriler müsteri in ListTutanMagaza.MusteriListesi)
                                {

                                    if (müsteri.KullaniciAdi == GirisYapanKullanici)
                                    {
                                        müsteri.UrunlerimdenCikar(line.Split(' ')[6 * i - 1], line.Split(' ')[6 * i + 1]);
                                    }
                                    MessageBox.Show("Ürün Başarıyla Listenizden Çıkarılmıştır...");
                                    break;
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
