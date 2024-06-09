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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using UtilityLibraries;

namespace GUI_Form
{
    public partial class PostingPekerjaan : Form
    {
        public PostingPekerjaan()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int selectedProvinsi = comboBox1.SelectedIndex;
                string[] kotaList = Lokasi.getKota(selectedProvinsi);
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(kotaList);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PostingPekerjaan_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string judul = textBox1.Text;
            int provinsi = comboBox1.SelectedIndex;
            int kota = comboBox2.SelectedIndex;
            int[] lokasi = new int[2];
            lokasi[0] = provinsi;
            lokasi[1] = kota;
            string deskripsi = richTextBox1.Text;
            string gaji = "Rp." + textBox2.Text + ",00";
            if (radioButton1.Checked)
            {
                gaji = gaji + "/Jam";
            }
            else if (radioButton2.Checked)
            {
                gaji = gaji + "/Hari";
            }
            else if (radioButton3.Checked)
            {
                gaji = gaji + "/Bulan";
            }
            Logged_In logged_In = Logged_In.GetInstance("","");
            UnggahPekerjaanConfig config = new UnggahPekerjaanConfig();
            MessageBox.Show(logged_In.idPerusahaan);
            config.TambahData(logged_In.idPerusahaan, judul, lokasi, gaji, deskripsi);
            iklanPekerjaan halamanIklan = new iklanPekerjaan();
            halamanIklan.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
