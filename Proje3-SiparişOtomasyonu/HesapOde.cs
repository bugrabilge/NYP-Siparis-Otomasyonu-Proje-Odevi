using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje3_SiparişOtomasyonu
{
    public partial class HesapOde : Form
    {
        public HesapOde()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kredi kredi = new Kredi();
            kredi.KartNumarasi = 12121212;
            kredi.Tip = "Banka";

            if (kredi.KartNumarasi ==Convert.ToUInt64( textBox1.Text) && kredi.Tip==textBox2.Text)
            {
                MessageBox.Show("Siparişiniz Başarıyla Oluşturulmuştur");
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz");
            }
            
        }
    }
}
