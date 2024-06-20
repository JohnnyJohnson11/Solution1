using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesKPL_WorkersUnion;
using UtilityLibraries;

namespace GUI_Form
{
    public partial class VerifikasiPerusahaan : Form
    {
        public VerifikasiPerusahaan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kategori = textBox1.Text;
            string tanggal = textBox2.Text;
            string aset = textBox3.Text;
            string alamat = richTextBox1.Text;
            Logged_In logged_In = Logged_In.GetInstance("", "");
            UnggahVerifikasiConfig unggahVerifikasiConfig = new UnggahVerifikasiConfig();
            unggahVerifikasiConfig.BuatDataVerifikasi(logged_In.idPerusahaan, kategori, tanggal, aset, alamat);
            UnggahPekerjaanConfig unggahPekerjaanConfig = new UnggahPekerjaanConfig();
            unggahPekerjaanConfig.ubahStatus(logged_In.idPerusahaan, "pending");
            MenungguVerifikasi halamanMenungguVerifikasi = new MenungguVerifikasi();
            halamanMenungguVerifikasi.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }
    }
}
