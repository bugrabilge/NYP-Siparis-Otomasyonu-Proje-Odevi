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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        public string GirisYapanKullanici;
        public static string GirisYapanIsim;
        public static string GirisYapanSoyisim;
        private void GirisForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label16.Text = DateTime.Now.ToLongDateString();
            label17.Text = DateTime.Now.ToLongTimeString();

            GirisYapanKullanici = Form1.girenkullanici;
            string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            foreach (string line in hepsi)
            {
                if (line.StartsWith(GirisYapanKullanici))
                {

                        if (line.Split(' ').Count() > 2)
                        {
                            GirisYapanIsim = line.Split(' ')[2];
                            GirisYapanSoyisim = line.Split(' ')[3];
                            break;
                        }

                }
            }

                lblGirisYapanKullanici.Text = "Hoşgeldiniz Sayın " + GirisYapanIsim + " " + GirisYapanSoyisim;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToLongDateString();
            label17.Text = DateTime.Now.ToLongTimeString();
        }

    }
}


