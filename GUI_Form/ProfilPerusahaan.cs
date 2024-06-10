using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Form
{
    public partial class ProfilPerusahaan : Form
    {
        public ProfilPerusahaan()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Perusahaan halamanPerusahaan = new Perusahaan();
            halamanPerusahaan.Show();
            this.Hide();
        }
    }
}
