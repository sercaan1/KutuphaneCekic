
namespace KutuphaneDeneme
{
    partial class FormHesabim
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOduncKitaplar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSonTeslim = new System.Windows.Forms.DateTimePicker();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(17, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(352, 30);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "label1";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdSoyad.Location = new System.Drawing.Point(17, 81);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(352, 33);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "label2";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(17, 138);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(352, 31);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "label3";
            // 
            // lblParola
            // 
            this.lblParola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblParola.Location = new System.Drawing.Point(17, 195);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(352, 32);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblParola);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblKullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 256);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOduncKitaplar);
            this.groupBox2.Location = new System.Drawing.Point(443, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 256);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç Alınan Kitaplar";
            // 
            // dgvOduncKitaplar
            // 
            this.dgvOduncKitaplar.AllowUserToAddRows = false;
            this.dgvOduncKitaplar.AllowUserToDeleteRows = false;
            this.dgvOduncKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOduncKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOduncKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncKitaplar.Location = new System.Drawing.Point(6, 28);
            this.dgvOduncKitaplar.MultiSelect = false;
            this.dgvOduncKitaplar.Name = "dgvOduncKitaplar";
            this.dgvOduncKitaplar.ReadOnly = true;
            this.dgvOduncKitaplar.RowHeadersVisible = false;
            this.dgvOduncKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOduncKitaplar.Size = new System.Drawing.Size(529, 222);
            this.dgvOduncKitaplar.TabIndex = 0;
            this.dgvOduncKitaplar.SelectionChanged += new System.EventHandler(this.dgvOduncKitaplar_SelectionChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(445, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Son Teslim Tarihi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpSonTeslim
            // 
            this.dtpSonTeslim.Location = new System.Drawing.Point(589, 320);
            this.dtpSonTeslim.Name = "dtpSonTeslim";
            this.dtpSonTeslim.Size = new System.Drawing.Size(241, 26);
            this.dtpSonTeslim.TabIndex = 8;
            this.dtpSonTeslim.ValueChanged += new System.EventHandler(this.dtpSonTeslim_ValueChanged);
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Location = new System.Drawing.Point(860, 292);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(124, 60);
            this.btnTeslimEt.TabIndex = 9;
            this.btnTeslimEt.Text = "Kitap Teslim Et";
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Location = new System.Drawing.Point(261, 292);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(146, 51);
            this.btnSifreDegistir.TabIndex = 10;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // FormHesabim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 364);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.dtpSonTeslim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHesabim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHesabim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOduncKitaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSonTeslim;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.Button btnSifreDegistir;
    }
}