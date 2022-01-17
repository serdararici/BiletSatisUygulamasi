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
    public partial class Etkinlik : Form
    {
        public Etkinlik()
        {
            InitializeComponent();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
    }
}
