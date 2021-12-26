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
    public partial class UCikarForm : Form
    {
        public UCikarForm()
        {
            InitializeComponent();
        }
        public string GirisYapanKullanici;
        public static int SilinmesiIstenenUrununSirasi;
        public int SilinmesiIstenenAdet;
        public bool FormKontrol=false;

        private void UCikarForm_Load(object sender, EventArgs e)
        {
            GirisYapanKullanici = Form1.girenkullanici;
            TabloOlustur();
        }

        private void txtUrunCikarGoster_Click(object sender, EventArgs e)
        {
            UrunListele();           
        }

        private void txtUrunCikarCikar_Click(object sender, EventArgs e)
        {
            UrunCikar();
        }


        public void UrunListele()
        {
            dataGridView1.Rows.Clear();
            string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            foreach (string line in hepsi)
            {
                if (line.StartsWith(GirisYapanKullanici))
                {

                    for (int i = 1; i < ((line.Split(' ').Count() - 5) / 6 + 1); i++)
                    {
                        dataGridView1.Rows.Add(line.Split(' ')[6 * i - 1], line.Split(' ')[6 * i], line.Split(' ')[6 * i + 1], 
                            line.Split(' ')[6 * i + 2], line.Split(' ')[6 * i + 3], line.Split(' ')[6 * i + 4]);
                    }
                    break;
                }
            }
        }

        public void UrunCikar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SilinmesiIstenenUrununSirasi = (dataGridView1.SelectedRows[0].Index) + 1;
                SilinecekAdet s = new SilinecekAdet();
                s.Show();
                
                
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        public void TabloOlustur()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Ürünün Adı";
            dataGridView1.Columns[1].Name = "Ürünün Markası";
            dataGridView1.Columns[2].Name = "Ürünün Modeli";
            dataGridView1.Columns[3].Name = "Ürünün Fiyatı";
            dataGridView1.Columns[4].Name = "Ürünün Ağırlığı";
            dataGridView1.Columns[5].Name = "Ürünün Adeti";

            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 62;
            dataGridView1.Columns[4].Width = 62;
            dataGridView1.Columns[5].Width = 62;
        }
    }
}
