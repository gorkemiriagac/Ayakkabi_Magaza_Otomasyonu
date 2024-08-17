namespace Otomasyon
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnNumara = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnGrup = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btniade = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(86, 69);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bilgi Düzenle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(-62, -35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUrun);
            this.groupBox2.Controls.Add(this.btnNumara);
            this.groupBox2.Controls.Add(this.btnRenk);
            this.groupBox2.Controls.Add(this.btnMarka);
            this.groupBox2.Controls.Add(this.btnGrup);
            this.groupBox2.Location = new System.Drawing.Point(5, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 244);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ayarlar";
            // 
            // btnUrun
            // 
            this.btnUrun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrun.Location = new System.Drawing.Point(6, 196);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(139, 38);
            this.btnUrun.TabIndex = 4;
            this.btnUrun.Text = "Ürün Yönetim";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnNumara
            // 
            this.btnNumara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumara.Location = new System.Drawing.Point(6, 153);
            this.btnNumara.Name = "btnNumara";
            this.btnNumara.Size = new System.Drawing.Size(139, 38);
            this.btnNumara.TabIndex = 3;
            this.btnNumara.Text = "Numara Yönetim";
            this.btnNumara.UseVisualStyleBackColor = true;
            this.btnNumara.Click += new System.EventHandler(this.btnNumara_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenk.Location = new System.Drawing.Point(6, 109);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(139, 38);
            this.btnRenk.TabIndex = 2;
            this.btnRenk.Text = "Renk Yönetim";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarka.Location = new System.Drawing.Point(6, 65);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(139, 38);
            this.btnMarka.TabIndex = 1;
            this.btnMarka.Text = "Marka Yönetim";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnGrup
            // 
            this.btnGrup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrup.Location = new System.Drawing.Point(6, 21);
            this.btnGrup.Name = "btnGrup";
            this.btnGrup.Size = new System.Drawing.Size(139, 38);
            this.btnGrup.TabIndex = 0;
            this.btnGrup.Text = "Grup Yönetim";
            this.btnGrup.UseVisualStyleBackColor = true;
            this.btnGrup.Click += new System.EventHandler(this.btnGrup_Click);
            // 
            // btnStok
            // 
            this.btnStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStok.Location = new System.Drawing.Point(376, 138);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(139, 38);
            this.btnStok.TabIndex = 4;
            this.btnStok.Text = "Stok Yönetim";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatis.Location = new System.Drawing.Point(207, 138);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(139, 38);
            this.btnSatis.TabIndex = 5;
            this.btnSatis.Text = "Satış";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKasa.Location = new System.Drawing.Point(563, 138);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(139, 38);
            this.btnKasa.TabIndex = 7;
            this.btnKasa.Text = "Kasa Tutarı";
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Location = new System.Drawing.Point(660, 411);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(139, 38);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayit.Location = new System.Drawing.Point(207, 196);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(139, 38);
            this.btnKayit.TabIndex = 9;
            this.btnKayit.Text = "Satış Kaydı";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteri.Location = new System.Drawing.Point(376, 196);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(139, 38);
            this.btnMusteri.TabIndex = 10;
            this.btnMusteri.Text = "Müşteri Liste";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btniade
            // 
            this.btniade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniade.Location = new System.Drawing.Point(563, 196);
            this.btniade.Name = "btniade";
            this.btniade.Size = new System.Drawing.Size(139, 38);
            this.btniade.TabIndex = 11;
            this.btniade.Text = "İade";
            this.btniade.UseVisualStyleBackColor = true;
            this.btniade.Click += new System.EventHandler(this.btniade_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btniade);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNumara;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnGrup;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btniade;
    }
}