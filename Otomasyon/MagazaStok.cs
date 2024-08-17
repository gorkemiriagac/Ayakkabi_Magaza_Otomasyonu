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
    public partial class MagazaStok : Form
    {
        public MagazaStok()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_MagazaStok", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            txtid.Text = "";
            txtstokid.Text = "";
            txtalis.Text = "";
            txtsatis.Text = "";
            txtstok.Text = "";
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtad.Text == String.Empty)
            {
                listView1.Items.Clear();
                SqlCommand komut = new SqlCommand("Select urunid,urunad,urunmarka,urunrenk,urungrup,urunnumara from Tbl_UrunOlustur where urunid like '%" + txtbulid.Text + "%'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = dr["urunid"].ToString();
                    ekle.SubItems.Add(dr["urunad"].ToString());
                    ekle.SubItems.Add(dr["urunmarka"].ToString());
                    ekle.SubItems.Add(dr["urunrenk"].ToString());
                    ekle.SubItems.Add(dr["urungrup"].ToString());
                    ekle.SubItems.Add(dr["urunnumara"].ToString());
                    listView1.Items.Add(ekle);
                }
                bgl.baglanti().Close();
            }
            else
            {
                listView1.Items.Clear();
                SqlCommand komut2 = new SqlCommand("Select urunid,urunad,urunmarka,urunrenk,urungrup,urunnumara from Tbl_UrunOlustur where urunad like '%" + txtad.Text + "%'", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = dr2["urunid"].ToString();
                    ekle.SubItems.Add(dr2["urunad"].ToString());
                    ekle.SubItems.Add(dr2["urunmarka"].ToString());
                    ekle.SubItems.Add(dr2["urunrenk"].ToString());
                    ekle.SubItems.Add(dr2["urungrup"].ToString());
                    ekle.SubItems.Add(dr2["urunnumara"].ToString());
                    listView1.Items.Add(ekle);
                }
                bgl.baglanti().Close();
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select Count(*) from Tbl_UrunOlustur where urunid='" + txtid.Text + "'", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                label9.Text = dr2[0].ToString();
                if (label9.Text == "1")
                {


                    try
                    {
                        SqlCommand komut = new SqlCommand("insert into Tbl_MagazaStok (urunid,alisfiyat,satisfiyat,stok) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", txtid.Text);
                        komut.Parameters.AddWithValue("@p2", txtalis.Text);
                        komut.Parameters.AddWithValue("@p3", txtsatis.Text);
                        komut.Parameters.AddWithValue("@p4", txtstok.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Ürün Stok Girişi Yapıldı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listele();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Ürün ID Stok Girişi Mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir ürün mevcut değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void MagazaStok_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtstokid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtalis.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsatis.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtstok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update Tbl_MagazaStok Set urunid=@p1,alisfiyat=@p2,satisfiyat=@p3,stok=@p4 where stokid=@p5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.Parameters.AddWithValue("@p2", txtalis.Text);
                komut.Parameters.AddWithValue("@p3", txtsatis.Text);
                komut.Parameters.AddWithValue("@p4", txtstok.Text);
                komut.Parameters.AddWithValue("@p5", txtstokid.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün Stok Bilgileri Düzenlendi");
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Ürün ID Çakışıyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtbulid.Text = "";
            txtad.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_MagazaStok where urunid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Stok Bilgileri Silindi");
            listele();
            temizle();
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
