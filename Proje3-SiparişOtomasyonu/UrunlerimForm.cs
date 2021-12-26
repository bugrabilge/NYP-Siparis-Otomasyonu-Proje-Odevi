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
    public partial class UrunlerimForm : Form
    {
        public UrunlerimForm()
        {
            InitializeComponent();
        }

        public string GirisYapanKullanici;
        public Magaza ListTutanMagaza;
        private void UrunlerimForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Ürünün Adı";
            dataGridView1.Columns[1].Name = "Ürünün Markası";
            dataGridView1.Columns[2].Name = "Ürünün Modeli";
            dataGridView1.Columns[3].Name = "Ürünün Fiyatı";
            dataGridView1.Columns[4].Name = "Satın Alanın Nicki";
            dataGridView1.Columns[5].Name = "Satın Alanın Ismi";
            dataGridView1.Columns[6].Name = "Satın Alanın Soyismi";
            dataGridView1.Columns[7].Name = "Satın Alanın Şehri";

            dataGridView1.Columns[0].Width = 68;
            dataGridView1.Columns[1].Width = 68;
            dataGridView1.Columns[2].Width = 67;
            dataGridView1.Columns[3].Width = 45;
            dataGridView1.Columns[4].Width = 67;
            dataGridView1.Columns[5].Width = 67;
            dataGridView1.Columns[6].Width = 67;
            dataGridView1.Columns[7].Width = 67;

        }
        public string Marka;
        public string Model;
        public string Fiyat;
        public string SilinmesiIstenenUrununAdi;
        public string SatinAlaninNick;
        public string SatinAlaninIsmi;
        public string SatinAlaninSoyismi;
        public string SatinAlaninSehri;

        private void btnUrunlerimYenile_Click(object sender, EventArgs e)
        {
            BilgileriCek();

            dataGridView1.Rows.Clear();
            string fileName = @Application.StartupPath + "\\satilanlar.txt";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            string[] hepsi2 = File.ReadAllLines(Application.StartupPath + "\\satilanlar.txt");
            foreach (string lines in hepsi2)
            {
                foreach (string line in hepsi)
                {
                    if (lines.StartsWith(GirisYapanKullanici) && line.StartsWith(GirisYapanKullanici))
                    {

                        for (int i = 1; i < (lines.Split(' ').Count() - 1) / 5 + 1; i++)
                        {
                            for (int j = 0; j < line.Split(' ').Length; j++)
                            {
                                if (line.Split(' ')[j] == lines.Split(' ')[5 * i - 4])
                                {
                                    Marka = line.Split(' ')[j + 1];
                                    Model = line.Split(' ')[j + 2];
                                    Fiyat = line.Split(' ')[j + 3];
                                    break;
                                }
                            }

                            dataGridView1.Rows.Add(lines.Split(' ')[5 * i - 4], Marka, Model, Fiyat, lines.Split(' ')[5 * i - 3], lines.Split(' ')[5 * i - 2],
                                lines.Split(' ')[5 * i - 1], lines.Split(' ')[5 * i]);
                        }

                    }
                }
            }
        }

        public void BilgileriCek()
        {
            GirisYapanKullanici = Form1.girenkullanici;
            ListTutanMagaza = Form1.GonderilecekNesne;
        }

        private void btnUrunlerimKargo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SilinmesiIstenenUrununAdi = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                SatinAlaninNick = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                SatinAlaninIsmi = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                SatinAlaninSoyismi = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                SatinAlaninSehri = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();


                string tempFile = Path.GetTempFileName();

                using (var sr = new StreamReader(Application.StartupPath + "\\satilanlar.txt"))
                using (var sw = new StreamWriter(tempFile))
                {
                    string satır;

                    while ((satır = sr.ReadLine()) != null)
                    {
                        for (int i = 1; i < (satır.Split(' ').Count() - 1) / 5 + 1; i++)
                        {
                            if (satır != GirisYapanKullanici + " " + SilinmesiIstenenUrununAdi + " " + SatinAlaninNick + " " +
                                SatinAlaninIsmi + " " + SatinAlaninSoyismi + " " + SatinAlaninSehri)
                            {
                                sw.WriteLine(satır);
                            }

                        }

                    }
                }
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                File.Delete(Application.StartupPath + "\\satilanlar.txt");
                File.Move(tempFile, Application.StartupPath + "\\satilanlar.txt");



                MessageBox.Show("Kargoya verip siparişi tamamladığınız içim\nürün listenizden kaldırılmıştır...");
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }
    }
}
