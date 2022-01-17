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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=BiletSatisUygulamasi; user ID=postgres; password=12345");
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from musteri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into musteri (adi,soyadi,yas,cinsiyet,tel) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(TxtYas.Text));
            komut.Parameters.AddWithValue("@p4", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@p5", TxtTelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("Delete from musteri where musterino=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
                komut2.ExecuteNonQuery();
                MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update musteri set adi=@p1,soyadi=@p2,yas=@p3,cinsiyet=@p4,tel=@p5 where musterino=@p6", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut3.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(TxtYas.Text));
            komut3.Parameters.AddWithValue("@p4", comboBox1.SelectedItem.ToString());
            komut3.Parameters.AddWithValue("@p5", TxtTelefon.Text);
            komut3.Parameters.AddWithValue("@p6", int.Parse(TxtNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from musteri where adi like '%" + TxtAra.Text + "%'" , baglanti);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();

        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
    }
}
