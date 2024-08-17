namespace Otomasyon
{
    partial class MagazaStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazaStok));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstokid = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtalis = new System.Windows.Forms.TextBox();
            this.txtsatis = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtbulid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btntemizle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTemizle2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(3, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 159);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Stok ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Urun ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Alış Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ürün Stok:";
            // 
            // txtstokid
            // 
            this.txtstokid.Enabled = false;
            this.txtstokid.Location = new System.Drawing.Point(119, 7);
            this.txtstokid.Name = "txtstokid";
            this.txtstokid.Size = new System.Drawing.Size(102, 22);
            this.txtstokid.TabIndex = 27;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(119, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(102, 22);
            this.txtid.TabIndex = 28;
            // 
            // txtalis
            // 
            this.txtalis.Location = new System.Drawing.Point(119, 64);
            this.txtalis.Name = "txtalis";
            this.txtalis.Size = new System.Drawing.Size(102, 22);
            this.txtalis.TabIndex = 29;
            // 
            // txtsatis
            // 
            this.txtsatis.Location = new System.Drawing.Point(119, 92);
            this.txtsatis.Name = "txtsatis";
            this.txtsatis.Size = new System.Drawing.Size(102, 22);
            this.txtsatis.TabIndex = 30;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(119, 120);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(102, 22);
            this.txtstok.TabIndex = 31;
            // 
            // btnBul
            // 
            this.btnBul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBul.Location = new System.Drawing.Point(516, 12);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(69, 40);
            this.btnBul.TabIndex = 32;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ürün Bilgileri";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(252, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 120);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İD";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marka";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Renk";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Grup";
            this.columnHeader5.Width = 53;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Num";
            this.columnHeader6.Width = 43;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(409, 33);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(102, 22);
            this.txtad.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(337, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Urun AD:";
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(3, 149);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(77, 31);
            this.btnEkle.TabIndex = 37;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Location = new System.Drawing.Point(86, 149);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(77, 31);
            this.btnGuncelle.TabIndex = 38;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Location = new System.Drawing.Point(169, 149);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 31);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtbulid
            // 
            this.txtbulid.Location = new System.Drawing.Point(409, 8);
            this.txtbulid.Name = "txtbulid";
            this.txtbulid.Size = new System.Drawing.Size(102, 22);
            this.txtbulid.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(337, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Urun ID:";
            // 
            // btntemizle
            // 
            this.btntemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntemizle.Location = new System.Drawing.Point(584, 12);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(71, 40);
            this.btntemizle.TabIndex = 42;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // btnTemizle2
            // 
            this.btnTemizle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle2.Location = new System.Drawing.Point(227, 3);
            this.btnTemizle2.Name = "btnTemizle2";
            this.btnTemizle2.Size = new System.Drawing.Size(77, 31);
            this.btnTemizle2.TabIndex = 44;
            this.btnTemizle2.Text = "Temizle";
            this.btnTemizle2.UseVisualStyleBackColor = true;
            this.btnTemizle2.Click += new System.EventHandler(this.btnTemizle2_Click);
            // 
            // MagazaStok
            // 
            this.AcceptButton = this.btnBul;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(655, 368);
            this.Controls.Add(this.btnTemizle2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.txtbulid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtsatis);
            this.Controls.Add(this.txtalis);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtstokid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MagazaStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mağaza Stok";
            this.Load += new System.EventHandler(this.MagazaStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstokid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtalis;
        private System.Windows.Forms.TextBox txtsatis;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtbulid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTemizle2;
    }
}