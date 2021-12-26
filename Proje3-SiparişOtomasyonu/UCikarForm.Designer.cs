
namespace Proje3_SiparişOtomasyonu
{
    partial class UCikarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCikarForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUrunCikarGoster = new System.Windows.Forms.Button();
            this.txtUrunCikarCikar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 430);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtUrunCikarGoster
            // 
            this.txtUrunCikarGoster.Location = new System.Drawing.Point(12, 448);
            this.txtUrunCikarGoster.Name = "txtUrunCikarGoster";
            this.txtUrunCikarGoster.Size = new System.Drawing.Size(157, 35);
            this.txtUrunCikarGoster.TabIndex = 2;
            this.txtUrunCikarGoster.Text = "Ürünlerimi Listele";
            this.txtUrunCikarGoster.UseVisualStyleBackColor = true;
            this.txtUrunCikarGoster.Click += new System.EventHandler(this.txtUrunCikarGoster_Click);
            // 
            // txtUrunCikarCikar
            // 
            this.txtUrunCikarCikar.Location = new System.Drawing.Point(415, 448);
            this.txtUrunCikarCikar.Name = "txtUrunCikarCikar";
            this.txtUrunCikarCikar.Size = new System.Drawing.Size(157, 35);
            this.txtUrunCikarCikar.TabIndex = 3;
            this.txtUrunCikarCikar.Text = "Ürünü Çıkar";
            this.txtUrunCikarCikar.UseVisualStyleBackColor = true;
            this.txtUrunCikarCikar.Click += new System.EventHandler(this.txtUrunCikarCikar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UCikarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUrunCikarCikar);
            this.Controls.Add(this.txtUrunCikarGoster);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UCikarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Çıkar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UCikarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtUrunCikarGoster;
        private System.Windows.Forms.Button txtUrunCikarCikar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}