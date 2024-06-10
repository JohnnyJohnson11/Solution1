using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TubesKPL_WorkersUnion;
using UtilityLibraries;

namespace GUI_Form
{
    public partial class EditProfilPerusahaan : Form
    {
        public EditProfilPerusahaan()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProfilPerusahaan halamanProfilPerusahaan = new ProfilPerusahaan();
            halamanProfilPerusahaan.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnggahPekerjaanConfig config = new UnggahPekerjaanConfig();
            Logged_In logged_in = Logged_In.GetInstance("", "");
            config.UbahDataPerusahaan(logged_in.idPerusahaan, textBox1.Text, comboBox1.SelectedIndex, comboBox2.SelectedIndex, textBox4.Text, textBox2.Text, richTextBox1.Text);
            ProfilPerusahaan halamanProfilPerusahaan = new ProfilPerusahaan();
            halamanProfilPerusahaan.Show();
            this.Hide();
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
    }
}
