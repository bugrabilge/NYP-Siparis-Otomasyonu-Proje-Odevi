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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            TabloDoldur(dataGridView1);
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            foreach (string line in hepsi)
            {

                dataGridView1.Rows.Add(line.Split(' ')[0], line.Split(' ')[1], line.Split(' ')[2], line.Split(' ')[3], line.Split(' ')[4]);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string tempFile = Path.GetTempFileName();

                using (var sr = new StreamReader(Application.StartupPath + "\\veri.txt"))
                using (var sw = new StreamWriter(tempFile))
                {
                    string satır;

                    while ((satır = sr.ReadLine()) != null)
                    {
                        if (!satır.StartsWith(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                            sw.WriteLine(satır);
                    }
                }
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                File.Delete(Application.StartupPath + "\\veri.txt");
                File.Move(tempFile, Application.StartupPath + "\\veri.txt");
                MessageBox.Show("Kullanıcı Başarıyla Silindi...");


            }

        }
        private void TabloDoldur(DataGridView i)
        {
            i.Columns.Clear();
            i.ColumnCount = 5;
            i.Columns[0].Name = "Nickname";
            i.Columns[1].Name = "Şifre";
            i.Columns[2].Name = "Ad";
            i.Columns[3].Name = "Soyad";
            i.Columns[4].Name = "Şehir";

        }
    }
}
    

