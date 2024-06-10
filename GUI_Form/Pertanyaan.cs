using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesKPL_WorkersUnion;
using UtilityLibraries;

namespace GUI_Form
{
    public partial class Pertanyaan : Form
    {
        private string idPerusahaan;
        private string judul;
        private int[] lokasi;
        private string gaji;
        private string deskripsi;
        public Pertanyaan(string idPerusahaan, string judul, int[] lokasi, string gaji, string deskripsi)
        {
            InitializeComponent();
            this.idPerusahaan = idPerusahaan;
            this.judul = judul;
            this.lokasi = lokasi;
            this.gaji = gaji;
            this.deskripsi = deskripsi;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                textBox1.Text = selectedFilePath;
                byte[] fileBytes = File.ReadAllBytes(selectedFilePath);
                string base64String = Convert.ToBase64String(fileBytes);
                UnggahPekerjaanConfig config = new UnggahPekerjaanConfig();
                config.TambahData(this.idPerusahaan, this.judul, this.lokasi, this.gaji, this.deskripsi, base64String);
            }
            iklanPekerjaan halamanPekerjaan = new iklanPekerjaan();
            halamanPekerjaan.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PostingPekerjaan halamanPostingPekerjaan = new PostingPekerjaan();
            halamanPostingPekerjaan.Show();
            this.Hide();
        }
    }
}
