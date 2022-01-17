using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biletSatisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=BiletSatisUygulamasi; user ID=postgres; password=12345");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void musteriBtn_Click(object sender, EventArgs e)
        {
            Musteri yeni = new Musteri();
            yeni.Show();
            this.Hide();
        }

        private void buttoncikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void biletBtn_Click(object sender, EventArgs e)
        {
            Bilet yeni = new Bilet();
            yeni.Show();
            this.Hide();
        }

        private void personelBtn_Click(object sender, EventArgs e)
        {
            Personel yeni = new Personel();
            yeni.Show();
            this.Hide();
        }

        private void etkinlikBtn_Click(object sender, EventArgs e)
        {
            Etkinlik yeni = new Etkinlik();
            yeni.Show();
            this.Hide();
        }
    }
}
