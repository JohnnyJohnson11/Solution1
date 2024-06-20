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
    public partial class JawabPertanyaan : Form
    {
        private string idPerusahaan;
        private string idPekerjaan;
        public JawabPertanyaan(string idPekerjaan)
        {
            InitializeComponent();
            this.idPerusahaan = "PR" + idPekerjaan.Substring(3, 7);
            this.idPekerjaan = idPekerjaan;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            //kirim file jawaban
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool found = false;
                string idCv = "";
                string selectedFilePath = openFileDialog.FileName;
                textBox1.Text = selectedFilePath;
                byte[] fileBytes = File.ReadAllBytes(selectedFilePath);
                string base64String = Convert.ToBase64String(fileBytes);
                UnggahPekerjaanConfig config = new UnggahPekerjaanConfig();
                Logged_In logged_in = Logged_In.GetInstance("", "");
                for (int i = 0; i < loginConfig.ListPengguna.pengguna.Count && !found; i++)
                {
                    if (loginConfig.ListPengguna.pengguna[i].pekerja.idPekerja == logged_in.idPekerja)
                    {
                        idCv = loginConfig.ListPengguna.pengguna[i].pekerja.Cv.idCv;
                        found = true;
                    }
                }
                MessageBox.Show(logged_in.idPekerja + " " + idCv);
                config.TambahLamaran(logged_in.idPekerja, this.idPekerjaan, idCv, base64String);
                found = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            int i;
            for (i = 0; i < loginConfig.ListPengguna.pengguna.Count; i++)
            {
                if (loginConfig.ListPengguna.pengguna[i].perusahaan.idPerusahaan == this.idPerusahaan)
                {
                    int j;
                    for (j = 0; j < loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan.Count; j++)
                    {
                        if (loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].idPekerjaan == this.idPekerjaan)
                        {
                            string fileJawaban = loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].pertanyaan;
                            byte[] fileBytes = Convert.FromBase64String(fileJawaban);
                            string outputFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), 
                                "Pertanyaan lamaran pekerjaan " + loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].judulPekerjaan + 
                                " Perusahaan " + loginConfig.ListPengguna.pengguna[i].perusahaan.Nama);
                            File.WriteAllBytes(outputFilePath, fileBytes);

                            MessageBox.Show($"File data loaded and saved as {outputFilePath}");
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CariPekerjaan halamanCariPekerjaan = new CariPekerjaan();
            halamanCariPekerjaan.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }
    }
}
