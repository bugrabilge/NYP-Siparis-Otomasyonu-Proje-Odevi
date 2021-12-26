
namespace Proje3_SiparişOtomasyonu
{
    partial class UListeleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UListeleForm));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUListeleYenile = new System.Windows.Forms.Button();
            this.btnSepetiOnayla = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.txtUListeleSepetCikar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(560, 266);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnUListeleYenile
            // 
            this.btnUListeleYenile.Location = new System.Drawing.Point(12, 284);
            this.btnUListeleYenile.Name = "btnUListeleYenile";
            this.btnUListeleYenile.Size = new System.Drawing.Size(115, 23);
            this.btnUListeleYenile.TabIndex = 2;
            this.btnUListeleYenile.Text = "Liste Yenile";
            this.btnUListeleYenile.UseVisualStyleBackColor = true;
            this.btnUListeleYenile.Click += new System.EventHandler(this.btnUListeleYenile_Click);
            // 
            // btnSepetiOnayla
            // 
            this.btnSepetiOnayla.Location = new System.Drawing.Point(457, 469);
            this.btnSepetiOnayla.Name = "btnSepetiOnayla";
            this.btnSepetiOnayla.Size = new System.Drawing.Size(115, 23);
            this.btnSepetiOnayla.TabIndex = 6;
            this.btnSepetiOnayla.Text = "Sepeti Onayla";
            this.btnSepetiOnayla.UseVisualStyleBackColor = true;
            this.btnSepetiOnayla.Click += new System.EventHandler(this.btnSepetiOnayla_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(457, 284);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(115, 23);
            this.btnSepeteEkle.TabIndex = 3;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // txtUListeleSepetCikar
            // 
            this.txtUListeleSepetCikar.Location = new System.Drawing.Point(12, 469);
            this.txtUListeleSepetCikar.Name = "txtUListeleSepetCikar";
            this.txtUListeleSepetCikar.Size = new System.Drawing.Size(115, 23);
            this.txtUListeleSepetCikar.TabIndex = 5;
            this.txtUListeleSepetCikar.Text = "Sepetten Çıkar";
            this.txtUListeleSepetCikar.UseVisualStyleBackColor = true;
            this.txtUListeleSepetCikar.Click += new System.EventHandler(this.txtUListeleSepetCikar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUListeleSepetCikar);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnSepetiOnayla);
            this.Controls.Add(this.btnUListeleYenile);
            this.Controls.Add(this.dataGridView2);
            this.Name = "UListeleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Satıştaki Ürünler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UListeleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUListeleYenile;
        private System.Windows.Forms.Button btnSepetiOnayla;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button txtUListeleSepetCikar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}