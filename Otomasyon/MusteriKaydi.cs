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
    public partial class MusteriKaydi : Form
    {
        public MusteriKaydi()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Musteri where musteritel like @musteritel", bgl.baglanti());
            {
                komut.Parameters.AddWithValue("@musteritel", "%" + txtara.Text + "%");
                SqlDataAdapter da1 = new SqlDataAdapter(komut);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }

        }

        private void MusteriKaydi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Musteri", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
