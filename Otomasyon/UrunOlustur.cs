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
    public partial class UrunOlustur : Form
    {
        public UrunOlustur()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            labelgorsel.Text = openFileDialog1.FileName;
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_UrunOlustur", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            cmbgrup.SelectedIndex = -1;
            cmbmarka.SelectedIndex = -1;          
            cmbrenk.SelectedIndex = -1;
            labelgorsel.Text = "";
            txtad.Focus();
            pictureBox1.ImageLocation = "";
        }

        private void UrunOlustur_Load(object sender, EventArgs e)
        {
            listele();
            //marka
            SqlCommand komut = new SqlCommand("Select markaad from Tbl_Marka", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbmarka.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
            //renk
            SqlCommand komut2 = new SqlCommand("Select renkad from Tbl_Renk", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbrenk.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
            //grup
            SqlCommand komut3 = new SqlCommand("Select grupad from Tbl_Grup", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbgrup.Items.Add(dr3[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void cmbgrup_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Select numara from Tbl_Numara where numaraad='" + cmbgrup.Text + "'", bgl.baglanti());
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            cmbnum.DisplayMember = "numara";
            cmbnum.DataSource = dt4;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || cmbgrup.Text == "" || cmbmarka.Text==""||cmbrenk.Text==""||cmbnum.Text==""||
                txtad.Text==String.Empty || cmbgrup.Text==String.Empty||cmbmarka.Text==""||cmbrenk.Text==""||cmbnum.Text=="")
            {
                MessageBox.Show("Boş Alanları Kontrol Ediniz");
            }
            else {
                SqlCommand komut = new SqlCommand("Select Count(*) from Tbl_UrunOlustur where urunad='" + txtad.Text + "' and urunmarka='" + cmbmarka.Text + "' and urunrenk='" + cmbrenk.Text + "' and urungrup='" + cmbgrup.Text + "' and urunnumara='" + cmbnum.Text + "'and urungorsel='" + labelgorsel.Text + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == "1")
                    {
                        MessageBox.Show("Böyle Bir Ürün Mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlCommand komut2 = new SqlCommand("insert into Tbl_UrunOlustur (urunad,urunmarka,urunrenk,urungrup,urunnumara,urungorsel) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                        komut2.Parameters.AddWithValue("@p1", txtad.Text);
                        komut2.Parameters.AddWithValue("@p2", cmbmarka.Text);
                        komut2.Parameters.AddWithValue("@p3", cmbrenk.Text);
                        komut2.Parameters.AddWithValue("@p4", cmbgrup.Text);
                        komut2.Parameters.AddWithValue("@p5", cmbnum.Text);
                        komut2.Parameters.AddWithValue("@p6", labelgorsel.Text);
                        komut2.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Ürün Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listele();

                    }
                }
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || cmbgrup.Text == "" || cmbmarka.Text == "" || cmbrenk.Text == "" || cmbnum.Text == "" ||
                txtad.Text == String.Empty || cmbgrup.Text == String.Empty || cmbmarka.Text == "" || cmbrenk.Text == "" || cmbnum.Text == "")
            {
                MessageBox.Show("Boş Alanlar Var, Ürün Düzenlenemez!");
            }
            else
            {
                SqlCommand komut = new SqlCommand("Select Count(*) from Tbl_UrunOlustur where urunad='" + txtad.Text + "' and urunmarka='" + cmbmarka.Text + "' and urunrenk='" + cmbrenk.Text + "' and urungrup='" + cmbgrup.Text + "' and urunnumara='" + cmbnum.Text + "'and urungorsel='" + labelgorsel.Text + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == "1")
                    {
                        MessageBox.Show("Böyle Bir Ürün Mevcut,Düzenlenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlCommand komut2 = new SqlCommand("Update Tbl_UrunOlustur Set urunad=@p1,urunmarka=@p2,urunrenk=@p3,urungrup=@p4,urunnumara=@p5,urungorsel=@p6 where urunid=@p7", bgl.baglanti());
                        komut2.Parameters.AddWithValue("@p1", txtad.Text);
                        komut2.Parameters.AddWithValue("@p2", cmbmarka.Text);
                        komut2.Parameters.AddWithValue("@p3", cmbrenk.Text);
                        komut2.Parameters.AddWithValue("@p4", cmbgrup.Text);
                        komut2.Parameters.AddWithValue("@p5", cmbnum.Text);
                        komut2.Parameters.AddWithValue("@p6", labelgorsel.Text);
                        komut2.Parameters.AddWithValue("@p7", txtid.Text);
                        komut2.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listele();

                    }
                }
            }
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbmarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbrenk.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbgrup.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbnum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            labelgorsel.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            pictureBox1.ImageLocation = labelgorsel.Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_UrunOlustur where urunid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
