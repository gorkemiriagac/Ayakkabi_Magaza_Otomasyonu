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
    public partial class PersonelBilgiDuzenle : Form
    {
        public PersonelBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string kullanici;
        sqlbaglanti bgl = new sqlbaglanti();

        private void PersonelBilgiDuzenle_Load(object sender, EventArgs e)
        {
            txtkad.Text = kullanici;
            SqlCommand komut = new SqlCommand("Select personeladsoyad,personelsifre from Tbl_Personel where personelk_adi='" + txtkad.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtadsoyad.Text = dr[0].ToString();
                txtsifre.Text = dr[1].ToString();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Personel Set personelk_adi=@p1,personelsifre=@p2,personeladsoyad=@p3 where personelk_adi=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            komut.Parameters.AddWithValue("@p3", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtkad.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncellendi");
        }
    }
}
