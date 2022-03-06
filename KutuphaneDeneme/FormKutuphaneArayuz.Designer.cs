
namespace KutuphaneDeneme
{
    partial class FormKutuphaneArayuz
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHesabim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBagis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTurler = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kitapİmhaEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapÖdünçAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHesabim,
            this.tsmiBagis,
            this.tsmiCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiHesabim
            // 
            this.tsmiHesabim.Name = "tsmiHesabim";
            this.tsmiHesabim.Size = new System.Drawing.Size(66, 20);
            this.tsmiHesabim.Text = "Hesabım";
            this.tsmiHesabim.Click += new System.EventHandler(this.tsmiHesabim_Click);
            // 
            // tsmiBagis
            // 
            this.tsmiBagis.Name = "tsmiBagis";
            this.tsmiBagis.Size = new System.Drawing.Size(86, 20);
            this.tsmiBagis.Text = "Kitap Bağışla";
            this.tsmiBagis.Click += new System.EventHandler(this.tsmiBagis_Click);
            // 
            // tsmiCikis
            // 
            this.tsmiCikis.Name = "tsmiCikis";
            this.tsmiCikis.Size = new System.Drawing.Size(66, 20);
            this.tsmiCikis.Text = "Çıkış Yap";
            this.tsmiCikis.Click += new System.EventHandler(this.tsmiCikis_Click);
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AllowUserToAddRows = false;
            this.dgvKitaplar.AllowUserToDeleteRows = false;
            this.dgvKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(12, 84);
            this.dgvKitaplar.MultiSelect = false;
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowHeadersVisible = false;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(983, 395);
            this.dgvKitaplar.TabIndex = 1;
            this.dgvKitaplar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKitaplar_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama";
            // 
            // txtArama
            // 
            this.txtArama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArama.Location = new System.Drawing.Point(416, 36);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(157, 26);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kütüphane";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Türler";
            // 
            // cboTurler
            // 
            this.cboTurler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurler.FormattingEnabled = true;
            this.cboTurler.Location = new System.Drawing.Point(816, 37);
            this.cboTurler.Name = "cboTurler";
            this.cboTurler.Size = new System.Drawing.Size(179, 28);
            this.cboTurler.TabIndex = 6;
            this.cboTurler.SelectedIndexChanged += new System.EventHandler(this.cboTurler_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİmhaEtToolStripMenuItem,
            this.kitapÖdünçAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // kitapİmhaEtToolStripMenuItem
            // 
            this.kitapİmhaEtToolStripMenuItem.Name = "kitapİmhaEtToolStripMenuItem";
            this.kitapİmhaEtToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kitapİmhaEtToolStripMenuItem.Text = "Kitap İmha Et";
            this.kitapİmhaEtToolStripMenuItem.Click += new System.EventHandler(this.kitapİmhaEtToolStripMenuItem_Click);
            // 
            // kitapÖdünçAlToolStripMenuItem
            // 
            this.kitapÖdünçAlToolStripMenuItem.Name = "kitapÖdünçAlToolStripMenuItem";
            this.kitapÖdünçAlToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kitapÖdünçAlToolStripMenuItem.Text = "Kitap Ödünç Al";
            this.kitapÖdünçAlToolStripMenuItem.Click += new System.EventHandler(this.kitapÖdünçAlToolStripMenuItem_Click);
            // 
            // FormKutuphaneArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 491);
            this.Controls.Add(this.cboTurler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKutuphaneArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormKutuphaneArayuz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKutuphaneArayuz_FormClosing);
            this.Load += new System.EventHandler(this.FormKutuphaneArayuz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHesabim;
        private System.Windows.Forms.ToolStripMenuItem tsmiBagis;
        private System.Windows.Forms.ToolStripMenuItem tsmiCikis;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTurler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapİmhaEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapÖdünçAlToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}