using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class Frmiade : Form
    {

        public Frmiade()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            try
            {
                cmbadet.Items.Clear();
                SqlCommand komut = new SqlCommand("Select madsoyad,mtel,tarih,adet,fiyat,aldigiurun from Tbl_Kayit where fisid='" + txtfisbilgi.Text + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    labelisim.Text = dr[0].ToString();
                    labeltel.Text = dr[1].ToString();
                    labeltarih.Text = dr[2].ToString();
                    labeladet.Text = dr[3].ToString();
                    labelfiyat.Text = dr[4].ToString();
                    txtbarkod2.Text = dr[5].ToString();
                }

                for (int i = 1; i <= Convert.ToInt16(labeladet.Text); i++)
                {
                    cmbadet.Items.Add(i);

                }
            }
            catch (Exception)
            {


            }
            SqlCommand komut2 = new SqlCommand("Select iadeislem from Tbl_Kayit where fisid='" + txtfisbilgi.Text + "'", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                labelsorgu.Text = dr2[0].ToString();
            }


        }

        private void btniade_Click(object sender, EventArgs e)
        {
            if (labelsorgu.Text == "1")
            {
                MessageBox.Show("İade işlemi daha önce yapılmış!!");
            }
            else if(cmbadet.Text=="" || cmbadet.Text == String.Empty)
            {
                MessageBox.Show("Adet Bilgisi boş geçilmez");
            }
            
            else
            {
               
                SqlCommand komut = new SqlCommand("Update Tbl_MagazaStok Set stok=stok+'" + cmbadet.Text + "' where urunid='" + txtbarkod2.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                MessageBox.Show("İade İşlemi Başarılı");
                bgl.baglanti().Close();
                /////islemlimitinisonlandırma
                SqlCommand komut3 = new SqlCommand("Update Tbl_Kayit Set iadeislem='1' where fisid='" + txtfisbilgi.Text + "'", bgl.baglanti());
                komut3.ExecuteNonQuery();
                //tekrarsorgu
                SqlCommand komut2 = new SqlCommand("Select iadeislem from Tbl_Kayit where fisid='" + txtfisbilgi.Text + "'", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    labelsorgu.Text = dr2[0].ToString();
                }
                //iadeyikasaya-bakiye
                int urun = 0, tutars;
                urun = Convert.ToInt16(labelfiyat.Text) / Convert.ToInt16(labeladet.Text);
                labelurun.Text = ((urun * Convert.ToInt16(cmbadet.Text)).ToString());
                tutars = Convert.ToInt16(labelurun.Text);
                SqlCommand komut4 = new SqlCommand("Update Tbl_Kasam Set kasatutar=kasatutar-'" + tutars + "'", bgl.baglanti());
                komut4.ExecuteNonQuery();

            }
        }

        
    }
}
