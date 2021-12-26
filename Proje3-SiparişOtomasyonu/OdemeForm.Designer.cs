
namespace Proje3_SiparişOtomasyonu
{
    partial class OdemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeForm));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOdemeCekIsım = new System.Windows.Forms.TextBox();
            this.btnOdemeCek = new System.Windows.Forms.Button();
            this.txtOdemeBankaId = new System.Windows.Forms.MaskedTextBox();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.txtOdemeKartSon = new System.Windows.Forms.MaskedTextBox();
            this.txtOdemeKartCvc = new System.Windows.Forms.MaskedTextBox();
            this.txtOdemeKartNo = new System.Windows.Forms.MaskedTextBox();
            this.BtnOdemeKredi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOdemeNakit = new System.Windows.Forms.Button();
            this.txtOdemeNakitMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "İsim:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(7, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Banka ID:";
            // 
            // txtOdemeCekIsım
            // 
            this.txtOdemeCekIsım.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeCekIsım.Location = new System.Drawing.Point(85, 28);
            this.txtOdemeCekIsım.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdemeCekIsım.Name = "txtOdemeCekIsım";
            this.txtOdemeCekIsım.Size = new System.Drawing.Size(122, 26);
            this.txtOdemeCekIsım.TabIndex = 6;
            // 
            // btnOdemeCek
            // 
            this.btnOdemeCek.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeCek.Location = new System.Drawing.Point(85, 98);
            this.btnOdemeCek.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdemeCek.Name = "btnOdemeCek";
            this.btnOdemeCek.Size = new System.Drawing.Size(122, 26);
            this.btnOdemeCek.TabIndex = 8;
            this.btnOdemeCek.Text = "Çek ile Öde";
            this.btnOdemeCek.UseVisualStyleBackColor = true;
            this.btnOdemeCek.Click += new System.EventHandler(this.btnOdemeCek_Click);
            // 
            // txtOdemeBankaId
            // 
            this.txtOdemeBankaId.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeBankaId.Location = new System.Drawing.Point(85, 63);
            this.txtOdemeBankaId.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdemeBankaId.Mask = "0000000000000000";
            this.txtOdemeBankaId.Name = "txtOdemeBankaId";
            this.txtOdemeBankaId.Size = new System.Drawing.Size(122, 26);
            this.txtOdemeBankaId.TabIndex = 7;
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamUcret.ForeColor = System.Drawing.Color.DimGray;
            this.lblToplamUcret.Location = new System.Drawing.Point(13, 61);
            this.lblToplamUcret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(387, 25);
            this.lblToplamUcret.TabIndex = 33;
            this.lblToplamUcret.Text = "Odemeniz Gereken Miktar: ";
            // 
            // txtOdemeKartSon
            // 
            this.txtOdemeKartSon.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeKartSon.Location = new System.Drawing.Point(146, 130);
            this.txtOdemeKartSon.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdemeKartSon.Mask = "0000";
            this.txtOdemeKartSon.Name = "txtOdemeKartSon";
            this.txtOdemeKartSon.Size = new System.Drawing.Size(42, 26);
            this.txtOdemeKartSon.TabIndex = 4;
            // 
            // txtOdemeKartCvc
            // 
            this.txtOdemeKartCvc.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeKartCvc.Location = new System.Drawing.Point(146, 95);
            this.txtOdemeKartCvc.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdemeKartCvc.Mask = "000";
            this.txtOdemeKartCvc.Name = "txtOdemeKartCvc";
            this.txtOdemeKartCvc.Size = new System.Drawing.Size(42, 26);
            this.txtOdemeKartCvc.TabIndex = 3;
            // 
            // txtOdemeKartNo
            // 
            this.txtOdemeKartNo.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeKartNo.Location = new System.Drawing.Point(146, 61);
            this.txtOdemeKartNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdemeKartNo.Mask = "0000000000000000";
            this.txtOdemeKartNo.Name = "txtOdemeKartNo";
            this.txtOdemeKartNo.Size = new System.Drawing.Size(141, 26);
            this.txtOdemeKartNo.TabIndex = 2;
            // 
            // BtnOdemeKredi
            // 
            this.BtnOdemeKredi.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdemeKredi.Location = new System.Drawing.Point(146, 172);
            this.BtnOdemeKredi.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOdemeKredi.Name = "BtnOdemeKredi";
            this.BtnOdemeKredi.Size = new System.Drawing.Size(141, 26);
            this.BtnOdemeKredi.TabIndex = 5;
            this.BtnOdemeKredi.Text = " Kredi Kartı İle Öde";
            this.BtnOdemeKredi.UseVisualStyleBackColor = true;
            this.BtnOdemeKredi.Click += new System.EventHandler(this.BtnOdemeKredi_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Banka",
            "Kredi"});
            this.comboBox1.Location = new System.Drawing.Point(146, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Son Kullanma Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(107, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tip:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(99, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "CVC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Kart Numarası:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnOdemeKredi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOdemeKartSon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOdemeKartCvc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOdemeKartNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 207);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kredi Kartı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtOdemeBankaId);
            this.groupBox2.Controls.Add(this.txtOdemeCekIsım);
            this.groupBox2.Controls.Add(this.btnOdemeCek);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(322, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 207);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çek";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOdemeNakit);
            this.groupBox3.Controls.Add(this.txtOdemeNakitMiktar);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(175, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 111);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kapıda Ödeme";
            // 
            // btnOdemeNakit
            // 
            this.btnOdemeNakit.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeNakit.Location = new System.Drawing.Point(106, 67);
            this.btnOdemeNakit.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdemeNakit.Name = "btnOdemeNakit";
            this.btnOdemeNakit.Size = new System.Drawing.Size(122, 26);
            this.btnOdemeNakit.TabIndex = 24;
            this.btnOdemeNakit.Text = "Kapıda Öde";
            this.btnOdemeNakit.UseVisualStyleBackColor = true;
            this.btnOdemeNakit.Click += new System.EventHandler(this.btnOdemeNakit_Click_1);
            // 
            // txtOdemeNakitMiktar
            // 
            this.txtOdemeNakitMiktar.Enabled = false;
            this.txtOdemeNakitMiktar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeNakitMiktar.Location = new System.Drawing.Point(106, 33);
            this.txtOdemeNakitMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdemeNakitMiktar.Name = "txtOdemeNakitMiktar";
            this.txtOdemeNakitMiktar.Size = new System.Drawing.Size(122, 26);
            this.txtOdemeNakitMiktar.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(7, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nakit Miktarı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 35);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 45);
            this.panel2.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 516);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 45);
            this.panel3.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblToplamUcret);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OdemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Ekranı";
            this.Load += new System.EventHandler(this.OdemeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOdemeCekIsım;
        private System.Windows.Forms.Button btnOdemeCek;
        private System.Windows.Forms.MaskedTextBox txtOdemeBankaId;
        private System.Windows.Forms.Label lblToplamUcret;
        private System.Windows.Forms.MaskedTextBox txtOdemeKartSon;
        private System.Windows.Forms.MaskedTextBox txtOdemeKartCvc;
        private System.Windows.Forms.MaskedTextBox txtOdemeKartNo;
        private System.Windows.Forms.Button BtnOdemeKredi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOdemeNakit;
        private System.Windows.Forms.TextBox txtOdemeNakitMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}