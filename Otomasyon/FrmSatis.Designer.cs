namespace Otomasyon
{
    partial class FrmSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatis));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetir = new System.Windows.Forms.Button();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labeltutar = new System.Windows.Forms.Label();
            this.sorgulabel = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.cmbsorgu = new System.Windows.Forms.Label();
            this.cmbadet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtodeme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelparaustu = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmad = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtmtel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-75, -38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(87, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kasiyer K.Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(592, 171);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnGetir
            // 
            this.btnGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetir.Location = new System.Drawing.Point(348, 132);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(107, 30);
            this.btnGetir.TabIndex = 9;
            this.btnGetir.Text = "Sepete Ekle";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(121, 136);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(147, 22);
            this.txtbarkod.TabIndex = 10;
            this.txtbarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbarkod_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(103, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tutar:";
            // 
            // labeltutar
            // 
            this.labeltutar.AutoSize = true;
            this.labeltutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltutar.ForeColor = System.Drawing.Color.White;
            this.labeltutar.Location = new System.Drawing.Point(175, 342);
            this.labeltutar.Name = "labeltutar";
            this.labeltutar.Size = new System.Drawing.Size(21, 24);
            this.labeltutar.TabIndex = 12;
            this.labeltutar.Text = "0";
            // 
            // sorgulabel
            // 
            this.sorgulabel.AutoSize = true;
            this.sorgulabel.Location = new System.Drawing.Point(1, 99);
            this.sorgulabel.Name = "sorgulabel";
            this.sorgulabel.Size = new System.Drawing.Size(51, 16);
            this.sorgulabel.TabIndex = 14;
            this.sorgulabel.Text = "label5";
            this.sorgulabel.Visible = false;
            // 
            // btnSatis
            // 
            this.btnSatis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatis.Location = new System.Drawing.Point(318, 374);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(105, 35);
            this.btnSatis.TabIndex = 15;
            this.btnSatis.Text = "Satış Yap";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // cmbsorgu
            // 
            this.cmbsorgu.AutoSize = true;
            this.cmbsorgu.Location = new System.Drawing.Point(360, 113);
            this.cmbsorgu.Name = "cmbsorgu";
            this.cmbsorgu.Size = new System.Drawing.Size(78, 16);
            this.cmbsorgu.TabIndex = 17;
            this.cmbsorgu.Text = "adetsorgu";
            this.cmbsorgu.Visible = false;
            // 
            // cmbadet
            // 
            this.cmbadet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbadet.FormattingEnabled = true;
            this.cmbadet.Location = new System.Drawing.Point(274, 134);
            this.cmbadet.Name = "cmbadet";
            this.cmbadet.Size = new System.Drawing.Size(64, 24);
            this.cmbadet.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ürün Barkod";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(286, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Alınan Ödeme:";
            // 
            // txtodeme
            // 
            this.txtodeme.Location = new System.Drawing.Point(165, 383);
            this.txtodeme.Name = "txtodeme";
            this.txtodeme.Size = new System.Drawing.Size(147, 22);
            this.txtodeme.TabIndex = 22;
            this.txtodeme.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtodeme_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(65, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Para Üstü:";
            // 
            // labelparaustu
            // 
            this.labelparaustu.AutoSize = true;
            this.labelparaustu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelparaustu.ForeColor = System.Drawing.Color.White;
            this.labelparaustu.Location = new System.Drawing.Point(175, 418);
            this.labelparaustu.Name = "labelparaustu";
            this.labelparaustu.Size = new System.Drawing.Size(21, 24);
            this.labelparaustu.TabIndex = 24;
            this.labelparaustu.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(598, 427);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(194, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Müşteri Ad Soyad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(185, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Müşteri Telefon No:";
            // 
            // txtmad
            // 
            this.txtmad.Location = new System.Drawing.Point(334, 62);
            this.txtmad.Name = "txtmad";
            this.txtmad.Size = new System.Drawing.Size(147, 22);
            this.txtmad.TabIndex = 1;
            // 
            // btnKayit
            // 
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayit.Location = new System.Drawing.Point(487, 31);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 53);
            this.btnKayit.TabIndex = 30;
            this.btnKayit.Text = "Kayıt Yap";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtmtel
            // 
            this.txtmtel.Location = new System.Drawing.Point(334, 34);
            this.txtmtel.Name = "txtmtel";
            this.txtmtel.Size = new System.Drawing.Size(147, 22);
            this.txtmtel.TabIndex = 0;
            this.txtmtel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmtel_KeyUp);
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmtel);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtmad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelparaustu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtodeme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbadet);
            this.Controls.Add(this.cmbsorgu);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.sorgulabel);
            this.Controls.Add(this.labeltutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satis";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeltutar;
        private System.Windows.Forms.Label sorgulabel;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Label cmbsorgu;
        private System.Windows.Forms.ComboBox cmbadet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtodeme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelparaustu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmad;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtmtel;
    }
}