using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris fr = new AdminGiris();
            fr.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGiris fr = new PersonelGiris();
            fr.Show();
            this.Hide();
            
        }
    }
}
