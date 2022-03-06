
namespace KutuphaneDeneme
{
    partial class FormKitapBagisla
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.nudSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.dtpBasimTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnBagisla = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KutuphaneDeneme.Properties.Resources.kitap;
            this.pictureBox1.Location = new System.Drawing.Point(103, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Basım Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Açıklama:";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(155, 162);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(200, 24);
            this.txtKitapAd.TabIndex = 7;
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(155, 207);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(200, 24);
            this.txtYazarAd.TabIndex = 8;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(155, 421);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 114);
            this.txtAciklama.TabIndex = 9;
            // 
            // nudSayfaSayisi
            // 
            this.nudSayfaSayisi.Location = new System.Drawing.Point(155, 339);
            this.nudSayfaSayisi.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSayfaSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSayfaSayisi.Name = "nudSayfaSayisi";
            this.nudSayfaSayisi.Size = new System.Drawing.Size(200, 24);
            this.nudSayfaSayisi.TabIndex = 10;
            this.nudSayfaSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(155, 381);
            this.nudAdet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(200, 24);
            this.nudAdet.TabIndex = 11;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpBasimTarihi
            // 
            this.dtpBasimTarihi.Location = new System.Drawing.Point(155, 251);
            this.dtpBasimTarihi.Name = "dtpBasimTarihi";
            this.dtpBasimTarihi.Size = new System.Drawing.Size(200, 24);
            this.dtpBasimTarihi.TabIndex = 12;
            // 
            // btnBagisla
            // 
            this.btnBagisla.Location = new System.Drawing.Point(198, 557);
            this.btnBagisla.Name = "btnBagisla";
            this.btnBagisla.Size = new System.Drawing.Size(157, 48);
            this.btnBagisla.TabIndex = 13;
            this.btnBagisla.Text = "Bağışla";
            this.btnBagisla.UseVisualStyleBackColor = true;
            this.btnBagisla.Click += new System.EventHandler(this.btnBagisla_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(31, 557);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(157, 48);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Basım Tarihi:";
            // 
            // cboTur
            // 
            this.cboTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTur.FormattingEnabled = true;
            this.cboTur.Location = new System.Drawing.Point(155, 296);
            this.cboTur.Name = "cboTur";
            this.cboTur.Size = new System.Drawing.Size(200, 26);
            this.cboTur.TabIndex = 16;
            // 
            // FormKitapBagisla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 617);
            this.Controls.Add(this.cboTur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnBagisla);
            this.Controls.Add(this.dtpBasimTarihi);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.nudSayfaSayisi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKitapBagisla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormKitapBagisla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.NumericUpDown nudSayfaSayisi;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.DateTimePicker dtpBasimTarihi;
        private System.Windows.Forms.Button btnBagisla;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTur;
    }
}