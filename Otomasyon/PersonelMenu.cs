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
    public partial class PersonelMenu : Form
    {
        public PersonelMenu()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string personelad;

        private void PersonelMenu_Load(object sender, EventArgs e)
        {
            label1.Text = personelad;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonelBilgiDuzenle fr = new PersonelBilgiDuzenle();
            fr.kullanici = label1.Text;
            fr.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            FrmSatis fr = new FrmSatis();
            fr.kullaniciadi = label1.Text;
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
