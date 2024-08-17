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
//Select Tbl_MagazaStok.urunid,Tbl_UrunOlustur.urunid,Tbl_UrunOlustur.urunad from Tbl_MagazaStok join Tbl_UrunOlustur on Tbl_MagazaStok.urunid=Tbl_UrunOlustur.urunid
//if exists (Select stok from Tbl_MagazaStok where urunid='1' and stok>0) begin UPDATE Tbl_MagazaStok Set stok=stok-5 Where urunid='1' end ELSE begin PRINT 'Stock is low.' end
//kullancam

namespace Otomasyon
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        public string kullaniciadi;

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniciadi;
            dataGridView1.Columns.Add("uid", "Ürün Barkod");
            dataGridView1.Columns.Add("ufiyat", "Fiyat");
            dataGridView1.Columns.Add("umiktar", "Miktar");
        }
        sqlbaglanti bgl = new sqlbaglanti();
        string uid;int ufiyat;
        // int miktar, toplam;

        private void txtbarkod_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                cmbadet.Items.Clear();
                SqlCommand komut = new SqlCommand("Select stok from Tbl_MagazaStok where urunid='" + txtbarkod.Text + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmbsorgu.Text = dr[0].ToString();
                    for (int i = 1; i <= Convert.ToInt16(cmbsorgu.Text); i++)
                    {
                        cmbadet.Items.Add(i);
                    }
                }
                bgl.baglanti().Close();

            }
            catch (Exception)
            {
                
                
                
            }
            
        }
short iade = 0;

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (labelparaustu.Text == "-" ||Convert.ToInt16(labelparaustu.Text) > 0 )
            {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)//extra satırı sil 
                {
                    string urunid = row.Cells["uid"].Value.ToString();
                    int miktar = Convert.ToInt16(row.Cells["umiktar"].Value);
                    SqlCommand komut = new SqlCommand("Update Tbl_MagazaStok Set stok=stok-@miktar where urunid=@urunid", bgl.baglanti());
                    komut.Parameters.AddWithValue("@urunid", urunid);
                    komut.Parameters.AddWithValue("@miktar", miktar);
                    komut.ExecuteNonQuery();
                        DateTime selectedDate = dateTimePicker1.Value;
                        int fiyats = Convert.ToInt16(row.Cells["ufiyat"].Value);
                        SqlCommand komut2 = new SqlCommand("insert into Tbl_Kayit (madsoyad,mtel,tarih,aldigiurun,adet,fiyat,kasiyerad,iadeislem) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                        komut2.Parameters.AddWithValue("@p1", txtmad.Text);
                        komut2.Parameters.AddWithValue("@p2", txtmtel.Text);
                        komut2.Parameters.AddWithValue("@p3", selectedDate);
                        komut2.Parameters.AddWithValue("@p4", urunid);
                        komut2.Parameters.AddWithValue("@p5", miktar);
                        komut2.Parameters.AddWithValue("@p6", fiyats);
                        komut2.Parameters.AddWithValue("@p7", kullaniciadi);
                        komut2.Parameters.AddWithValue("@p8", iade);

                        komut2.ExecuteNonQuery();


                    
                } 
            }
            //kasa
            SqlCommand komut3 = new SqlCommand("Update Tbl_Kasam Set kasatutar=kasatutar+@toplam where islemid=1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@toplam", toplam);
            komut3.ExecuteNonQuery();
            
            // temizle
            MessageBox.Show("Satış Başarılı");
            txtbarkod.Text = "";
            cmbadet.Items.Clear();
            tutar = 0;
            toplam = 0;
            labeltutar.Text = "0";
            txtodeme.Text = "";
            labelparaustu.Text = "0";
            txtmad.Text = "";
            txtmtel.Text = "";
            dataGridView1.Rows.Clear();   
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
        }
        int tutar = 0, toplam = 0;

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Musteri (musteriadsoyad,musteritel) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtmad.Text);
            komut.Parameters.AddWithValue("@p2", txtmtel.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı", "Kayıt Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtmtel_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select musteriadsoyad from Tbl_Musteri where musteritel=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtmtel.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtmad.Text = dr[0].ToString();
            }
        }

        private void txtodeme_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (labeltutar.Text == txtodeme.Text)
                {
                    labelparaustu.Text = "-";
                    //btnSatis.Enabled = true;
                }
                if (Convert.ToInt16(txtodeme.Text) > Convert.ToInt16(labeltutar.Text))
                {
                    labelparaustu.Text = (Convert.ToInt16(txtodeme.Text) - Convert.ToInt16(labeltutar.Text)).ToString();
                    // btnSatis.Enabled = true;
                }
                if (Convert.ToInt16(labeltutar.Text) > Convert.ToInt16(txtodeme.Text))
                {
                    // btnSatis.Enabled = false;
                    labelparaustu.Text = "-" + (Convert.ToInt16(labeltutar.Text) - Convert.ToInt16(txtodeme.Text)).ToString();
                }
            }
            catch (Exception)
            {

               
            }
            
        }
        private void btnSepetCikar_Click(object sender, EventArgs e)
        {
            


        }
        private void btnGetir_Click(object sender, EventArgs e)
        {//sepet
            try
            {
                SqlCommand komut = new SqlCommand("Select Count(*)urunid from Tbl_MagazaStok where urunid='" + txtbarkod.Text + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {//sorgulabel->ürün var mı yok mu
                    sorgulabel.Text = dr[0].ToString();
                    if (sorgulabel.Text == "1")
                    {
                        SqlCommand komut2 = new SqlCommand("Select urunid,satisfiyat,stok from Tbl_MagazaStok where urunid='" + txtbarkod.Text + "'", bgl.baglanti());
                        SqlDataReader dr2 = komut2.ExecuteReader();
                        while (dr2.Read())
                        {
                            uid = dr2[0].ToString();
                            ufiyat = Convert.ToInt16(dr2[1].ToString()) * Convert.ToInt16(cmbadet.Text);
                            if (cmbadet.Text == String.Empty || cmbadet.Text == "0")
                            {
                                label6.ForeColor = Color.Red;
                                MessageBox.Show("Miktar Bilgisi Boş Girilmez");
                                label6.ForeColor = Color.White;
                            }
                            else
                            {
                                dataGridView1.Rows.Add(uid, ufiyat, cmbadet.Text);
                                tutar = ufiyat;
                            }
                            toplam = toplam + tutar;
                            labeltutar.Text = toplam.ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu ürün stoğunuzda mevcut değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Geçerli Değer Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
