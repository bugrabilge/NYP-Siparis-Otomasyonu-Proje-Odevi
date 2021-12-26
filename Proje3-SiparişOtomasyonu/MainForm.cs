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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Form form1 = new GirisForm();
            ShowForm(ref form1);
        }



        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            Form ActiveMdiChild = this.ActiveMdiChild;
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (ActiveMdiChild.Text == tabPage.Text)
                {
                    tabControl1.SelectedTab = tabPage;
                    break;
                }
            }
        }

        private void tabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            tabControl1.Visible = tabControl1.TabPages.Count > 0;
        }

        private void tabControl1_ControlRemoved(object sender, ControlEventArgs e)
        {
            tabControl1.Visible = tabControl1.TabPages.Count > 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;
            if (selectedTab == null)
            {
                return;
            }

            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == selectedTab.Text)
                {
                    mdiChild.BringToFront();
                    break;
                }
            }
        }
        void ShowForm(ref Form form)
        {
            Form f = form;
            Form tempForm = null;

            foreach (Form child in this.MdiChildren)
            {
                if (child.Text == f.Text)
                {
                    tempForm = child;
                    break;
                }
            }
            if (tempForm != null)
            {
                tempForm.BringToFront();
            }
            else
            {
                f.MdiParent = this;
                f.Show();
                f.FormClosed += MainForm_FormClosed;

                TabPage tabPage = new TabPage();
                tabPage.Text = f.Text;
                tabPage.Parent = tabControl1;
                tabControl1.TabPages.Remove(tabPage);
            }
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form4 = new UListeleForm();
            ShowForm(ref form4);
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new GirisForm();
            ShowForm(ref form1);
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new UEkleForm();
            ShowForm(ref form2);
        }

        private void ürünÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new UCikarForm();
            ShowForm(ref form3);
        }

        private void ürünlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form5 = new UrunlerimForm();
            ShowForm(ref form5);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;
            TabPage deleteTabPage = null;
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Text == form.Text)
                {
                    deleteTabPage = tabPage;
                    break;
                }
            }
            if (deleteTabPage != null)
                tabControl1.TabPages.Remove(deleteTabPage);
        }

        
    }
}

