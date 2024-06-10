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
    public partial class Perusahaan : Form
    {
        public Perusahaan()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //iklan
            iklanPekerjaan halamanIklan = new iklanPekerjaan();
            halamanIklan.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfilPerusahaan halamanProfilPerusahaan = new ProfilPerusahaan();
            halamanProfilPerusahaan.Show();
            this.Hide();
        }
    }
}
