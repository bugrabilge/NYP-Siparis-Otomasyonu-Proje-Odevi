
namespace Proje3_SiparişOtomasyonu
{
    partial class SilinecekAdet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SilinecekAdet));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSilinecekAdet = new System.Windows.Forms.TextBox();
            this.txtSilinecekAdetCikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çıkarmak İstediğiniz Adet Sayısını Giriniz :";
            // 
            // txtSilinecekAdet
            // 
            this.txtSilinecekAdet.Location = new System.Drawing.Point(121, 136);
            this.txtSilinecekAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtSilinecekAdet.Name = "txtSilinecekAdet";
            this.txtSilinecekAdet.Size = new System.Drawing.Size(148, 27);
            this.txtSilinecekAdet.TabIndex = 1;
            // 
            // txtSilinecekAdetCikar
            // 
            this.txtSilinecekAdetCikar.Location = new System.Drawing.Point(138, 182);
            this.txtSilinecekAdetCikar.Margin = new System.Windows.Forms.Padding(4);
            this.txtSilinecekAdetCikar.Name = "txtSilinecekAdetCikar";
            this.txtSilinecekAdetCikar.Size = new System.Drawing.Size(112, 34);
            this.txtSilinecekAdetCikar.TabIndex = 2;
            this.txtSilinecekAdetCikar.Text = "Çıkar";
            this.txtSilinecekAdetCikar.UseVisualStyleBackColor = true;
            this.txtSilinecekAdetCikar.Click += new System.EventHandler(this.txtSilinecekAdetCikar_Click);
            // 
            // SilinecekAdet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.txtSilinecekAdetCikar);
            this.Controls.Add(this.txtSilinecekAdet);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SilinecekAdet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silinecek Adet";
            this.Load += new System.EventHandler(this.SilinecekAdet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSilinecekAdet;
        private System.Windows.Forms.Button txtSilinecekAdetCikar;
    }
}