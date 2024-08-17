using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otomasyon
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string adminad;      
        private void AdminMenu_Load(object sender, EventArgs e)
        {
            label1.Text = adminad;

        }
        private void btnGrup_Click(object sender, EventArgs e)
        {
            GrupYonetim gy = new GrupYonetim();
            gy.Show();
            
        }
        private void btnMarka_Click(object sender, EventArgs e)
        {
            MarkaYonetim my = new MarkaYonetim();
            my.Show();
        }
        private void btnRenk_Click(object sender, EventArgs e)
        {
            RenkYonetim ry = new RenkYonetim();
            ry.Show();
        }
        private void btnNumara_Click(object sender, EventArgs e)
        {
            NumaraYonetim ny = new NumaraYonetim();
            ny.Show();
        }
        private void btnUrun_Click(object sender, EventArgs e)
        {
            UrunOlustur fr = new UrunOlustur();
            fr.Show();
        }
        private void btnStok_Click(object sender, EventArgs e)
        {
            MagazaStok fr = new MagazaStok();
            fr.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminBilgiDuzenle fr = new AdminBilgiDuzenle();
            fr.kullanici = label1.Text;
            fr.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            FrmSatis fr = new FrmSatis();
            fr.kullaniciadi = label1.Text;
            fr.Show();
            
        }

        

        private void btnKasa_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select kasatutar from Tbl_Kasam where islemid=1", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show("Kasa tutarı: " + dr[0].ToString(),"Kasa Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SatisKaydi fr = new SatisKaydi();
            fr.Show();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusteriKaydi fr = new MusteriKaydi();
            fr.Show();
        }

        private void btniade_Click(object sender, EventArgs e)
        {
            Frmiade fr = new Frmiade();
            fr.Show();
        }
    }
}
