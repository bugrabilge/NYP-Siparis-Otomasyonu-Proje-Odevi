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
    public partial class KayıtForm : Form
    {
        public KayıtForm()
        {
            InitializeComponent();
        }
       
        public bool kontrol = false;
        private void btnKayitTamamla_Click(object sender, EventArgs e)
        {
            KayitTamamla();
        }

        
        public void KayitTamamla()
        {
            string dosyayolu = @Application.StartupPath + "\\veri.txt";
            if (File.Exists(dosyayolu) == false)
            {
                StreamWriter SW;
                SW = File.CreateText(Application.StartupPath + "\\veri.txt");
                SW.Close();
            }

            else
            {
               

                string fileName = @Application.StartupPath + "\\veri.txt";
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();

                string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
                foreach (string line in hepsi)
                {
                    if (line.StartsWith(txtKayitKullaniciAdi.Text))
                    {
                        MessageBox.Show("Bu Kullanıcı Adı Daha Önce Alınmıştır.\nLütfen Başka Bir Kullanıcı Adı Seçiniz...");
                        kontrol = true;
                        break;
                    }
                    else
                    {
                        kontrol = false;
                    }
                }
                if (kontrol == false)
                {
                    var info = new FileInfo(fileName);
                    if (info.Length == 0)
                    {
                        File.AppendAllText(fileName, txtKayitKullaniciAdi.Text + " " + txtKayitSifre.Text +
                        " " + txtKayitIsim.Text + " " + txtKayitSoyisim.Text + " " + txtKayitSehir.Text);
                    }
                    else
                    {
                        File.AppendAllText(fileName, Environment.NewLine + txtKayitKullaniciAdi.Text + " " + txtKayitSifre.Text +
                        " " + txtKayitIsim.Text + " " + txtKayitSoyisim.Text + " " + txtKayitSehir.Text);
                    }

                    

                    
                    
                    MessageBox.Show("Kaydınız Başarıyla Oluşturulmuştur\nGiriş Ekranına Yönlendiriliyorsunuz...");
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.Show();
                }

                
            }
        }

        private void KayıtForm_Load(object sender, EventArgs e)
        {

        }
    }
}
