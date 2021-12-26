
namespace Proje3_SiparişOtomasyonu
{
    partial class UrunlerimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunlerimForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUrunlerimYenile = new System.Windows.Forms.Button();
            this.btnUrunlerimKargo = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(560, 429);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnUrunlerimYenile
            // 
            this.btnUrunlerimYenile.Location = new System.Drawing.Point(12, 447);
            this.btnUrunlerimYenile.Name = "btnUrunlerimYenile";
            this.btnUrunlerimYenile.Size = new System.Drawing.Size(134, 29);
            this.btnUrunlerimYenile.TabIndex = 2;
            this.btnUrunlerimYenile.Text = "Listeyi Yenile";
            this.btnUrunlerimYenile.UseVisualStyleBackColor = true;
            this.btnUrunlerimYenile.Click += new System.EventHandler(this.btnUrunlerimYenile_Click);
            // 
            // btnUrunlerimKargo
            // 
            this.btnUrunlerimKargo.Location = new System.Drawing.Point(438, 447);
            this.btnUrunlerimKargo.Name = "btnUrunlerimKargo";
            this.btnUrunlerimKargo.Size = new System.Drawing.Size(134, 29);
            this.btnUrunlerimKargo.TabIndex = 3;
            this.btnUrunlerimKargo.Text = "Kargoya Verdim";
            this.btnUrunlerimKargo.UseVisualStyleBackColor = true;
            this.btnUrunlerimKargo.Click += new System.EventHandler(this.btnUrunlerimKargo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UrunlerimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUrunlerimKargo);
            this.Controls.Add(this.btnUrunlerimYenile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunlerimForm";
            this.Text = "Ürün Takip";
            this.Load += new System.EventHandler(this.UrunlerimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunlerimYenile;
        private System.Windows.Forms.Button btnUrunlerimKargo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}