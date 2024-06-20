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

namespace GUI_Form
{
    public partial class HalamanAdmin : Form
    {
        public HalamanAdmin()
        {
            InitializeComponent();
            List<string> idPekerjaanDitunjukkan = new List<string>();
            VerifikasiConfig verifikasiConfig = new VerifikasiConfig();
            verifikasiConfig.ReadConfigFile();
            for (int i = 0; i < verifikasiConfig.ListVerifikasi.verifikasi.Count; i++)
            {
                idPekerjaanDitunjukkan.Add(verifikasiConfig.ListVerifikasi.verifikasi[i].idPerusahaan);
            }
            listBox1.DataSource = idPekerjaanDitunjukkan;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();

            VerifikasiConfig verifikasiConfig = new VerifikasiConfig();
            verifikasiConfig.ReadConfigFile();
            if (listBox1.SelectedItem != null)
            {
                bool found = false;
                for (int j = 0; j < verifikasiConfig.ListVerifikasi.verifikasi.Count && !found; j++)
                {
                    if (verifikasiConfig.ListVerifikasi.verifikasi[j].idPerusahaan == (string)listBox1.SelectedItem)
                    {
                        label12.Text = verifikasiConfig.ListVerifikasi.verifikasi[j].kategoriPerusahaan;
                        label11.Text = verifikasiConfig.ListVerifikasi.verifikasi[j].tanggalPerusahaan;
                        label9.Text = verifikasiConfig.ListVerifikasi.verifikasi[j].asetPerusahaan;
                        label10.Text = verifikasiConfig.ListVerifikasi.verifikasi[j].alamatPerusahaan;
                        found = true;
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnggahPekerjaanConfig unggahPekerjaanConfig = new UnggahPekerjaanConfig();
            unggahPekerjaanConfig.ubahStatus((string)listBox1.SelectedItem, "terima");
            UnggahVerifikasiConfig unggahVerifikasiConfig = new UnggahVerifikasiConfig();
            unggahVerifikasiConfig.HapusDataVerifikasi((string)listBox1.SelectedItem);
            HalamanAdmin halamanAdmin = new HalamanAdmin();
            halamanAdmin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnggahPekerjaanConfig unggahPekerjaanConfig=new UnggahPekerjaanConfig();
            unggahPekerjaanConfig.ubahStatus((string)listBox1.SelectedItem, "tolak");
            UnggahVerifikasiConfig unggahVerifikasiConfig=new UnggahVerifikasiConfig();
            unggahVerifikasiConfig.HapusDataVerifikasi((string)listBox1.SelectedItem);
            HalamanAdmin halamanAdmin = new HalamanAdmin();
            halamanAdmin.Show();
            this.Hide();
        }
    }
}
