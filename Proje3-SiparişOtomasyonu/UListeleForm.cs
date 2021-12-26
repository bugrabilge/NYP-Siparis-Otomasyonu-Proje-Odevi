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
using System.Collections;


namespace Proje3_SiparişOtomasyonu
{
    public partial class UListeleForm : Form
    {
        public UListeleForm()
        {
            InitializeComponent();
        }
        public string SilinmesiIstenenUrununAdi;
        public int SilinmesiIstenenAdet;
        public static int ToplamUcret;
        public static List<string> SatisYapanKullanicilar = new List<string>();
        public static List<string> SatılanUrunler= new List<string>();
        private void UListeleForm_Load(object sender, EventArgs e)
        {            
            TabloDoldur(dataGridView2);
            TabloDoldur(dataGridView1);
            UrunleriListele();
            dataGridView1.BringToFront();
        }

        private void btnUListeleYenile_Click(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(dataGridView2.SelectedRows[0].Cells[0].Value.ToString(), dataGridView2.SelectedRows[0].Cells[1].Value.ToString(),
            dataGridView2.SelectedRows[0].Cells[2].Value.ToString(), dataGridView2.SelectedRows[0].Cells[3].Value.ToString(), dataGridView2.SelectedRows[0].Cells[4].Value.ToString(),
            1, dataGridView2.SelectedRows[0].Cells[6].Value.ToString());


            SatisYapanKullanicilar.Add(dataGridView2.SelectedRows[0].Cells[6].Value.ToString());
            SatılanUrunler.Add(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            ToplamUcret += Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[3].Value);
        }

        private void btnSepetiOnayla_Click(object sender, EventArgs e)
        {
            AdetCikar();

            OdemeForm odeme = new OdemeForm();
            odeme.Show();
            ToplamUcret = 0;
        }

        public void UrunleriListele()
        {
            dataGridView2.Rows.Clear();
            string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            foreach (string line in hepsi)
            {

                for (int i = 1; i < ((line.Split(' ').Count() - 5) / 6 + 1); i++)
                {
                    dataGridView2.Rows.Add(line.Split(' ')[6 * i - 1], line.Split(' ')[6 * i], line.Split(' ')[6 * i + 1],
                        line.Split(' ')[6 * i + 2], line.Split(' ')[6 * i + 3], line.Split(' ')[6 * i + 4], line.Split(' ')[0]);
                }

            }
        }

        private void txtUListeleSepetCikar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                SatisYapanKullanicilar.Remove(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                SatılanUrunler.Remove(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }

        }

        private void TabloDoldur(DataGridView i)
        {
            i.Columns.Clear();
            i.ColumnCount = 7;
            i.Columns[0].Name = "Ürünün Adı";
            i.Columns[1].Name = "Ürünün Markası";
            i.Columns[2].Name = "Ürünün Modeli";
            i.Columns[3].Name = "Ürünün Fiyatı";
            i.Columns[4].Name = "Ürünün Ağırlığı";
            i.Columns[5].Name = "Ürünün Adeti";
            i.Columns[6].Name = "Satan Kullanıcı";

            i.Columns[0].Width = 95; 
            i.Columns[1].Width = 95; 
            i.Columns[2].Width = 95; 
            i.Columns[3].Width = 45; 
            i.Columns[4].Width = 45; 
            i.Columns[5].Width = 45; 
            i.Columns[6].Width = 95;
        }

        public void AdetCikar()
        {
            SilinmesiIstenenAdet = 1;
            SilinmesiIstenenUrununAdi = (dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");

            foreach (string line in hepsi)
            {
                if (line.StartsWith(dataGridView2.SelectedRows[0].Cells[6].Value.ToString()))
                {

                    for (int i = 1; i < ((line.Split(' ').Count() - 5) / 6 + 1); i++)
                    {

                        if (line.Split(' ')[6 * i - 1] == (SilinmesiIstenenUrununAdi))
                        {

                            if (SilinmesiIstenenAdet < Convert.ToInt32(line.Split(' ')[6 * i + 4]))
                            {

                                File.WriteAllText(Application.StartupPath + "\\veri.txt",
                                    File.ReadAllText(Application.StartupPath + "\\veri.txt").Replace(line.Split(' ')[6 * i + 4],
                                    (Convert.ToInt32(line.Split(' ')[6 * i + 4]) - SilinmesiIstenenAdet).ToString()));
                                MessageBox.Show("Ödeme Sayfasına Yönlendiriliyorsunuz...");
                                UrunleriListele();
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
                                UrunleriListele();
                                MessageBox.Show("Ödeme Sayfasına Yönlendiriliyorsunuz...");
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
