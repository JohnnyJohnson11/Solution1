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
    public partial class Kandidat : Form
    {
        private string idPekerjaan;
        private List<DataCariPekerja> dataCariPekerja = new List<DataCariPekerja>();
        public Kandidat(string idPekerjaan)
        {
            InitializeComponent();
            this.idPekerjaan = idPekerjaan;
            List<string> kumpulanIdPekerja = new List<string>();
            List<string> namaPekerja = new List<string>();
            DataCariPekerja data;
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            int i;
            bool found = false;
            for (i = 0; i < loginConfig.ListPengguna.pengguna.Count && !found; i++)
            {
                if (loginConfig.ListPengguna.pengguna[i].perusahaan.idPerusahaan == "PR" + idPekerjaan.Substring(3, 7))
                {
                    found = true;
                    bool found2 = false;
                    int j;
                    for (j = 0; j < loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan.Count && !found2; j++)
                    {
                        if (loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].idPekerjaan == idPekerjaan)
                        {
                            found2 = true;
                            int k;
                            for (k = 0; k < loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].lamaranDiterima.Count && loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].lamaranDiterima != null; k++)
                            {
                                kumpulanIdPekerja.Add(loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].lamaranDiterima[k].idPekerja);
                            }
                        }
                    }
                }
            }
            for (i = 0; i < kumpulanIdPekerja.Count; i++)
            {
                found = false;
                int j = 0;
                for (j = 0; j < loginConfig.ListPengguna.pengguna.Count && !found; j++)
                {
                    if (kumpulanIdPekerja[i] == loginConfig.ListPengguna.pengguna[j].pekerja.idPekerja)
                    {
                        namaPekerja.Add(loginConfig.ListPengguna.pengguna[j].username);
                        found = true;
                    }
                }
            }
            for (i = 0; i < kumpulanIdPekerja.Count; i++)
            {
                data = new DataCariPekerja(kumpulanIdPekerja[i], namaPekerja[i]);
                dataCariPekerja.Add(data);
                MessageBox.Show(kumpulanIdPekerja[i], namaPekerja[i]);
            }
            listBox1.DataSource = namaPekerja;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            iklanPekerjaan halamanIklanPekerjaan = new iklanPekerjaan();
            halamanIklanPekerjaan.Show();
            this.Hide();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            if (listBox1.SelectedItem != null)
            {
                bool found = false;
                for (int j = 0; j < loginConfig.ListPengguna.pengguna.Count && !found; j++)
                {
                    if (loginConfig.ListPengguna.pengguna[j].pekerja.idPekerja == dataCariPekerja[listBox1.SelectedIndex].idPekerja)
                    {
                        label12.Text = loginConfig.ListPengguna.pengguna[j].fullname;
                        label11.Text = loginConfig.ListPengguna.pengguna[j].pekerja.tanggalLahir;
                        label9.Text = loginConfig.ListPengguna.pengguna[j].email;
                        label10.Text = loginConfig.ListPengguna.pengguna[j].pekerja.noTelepon;
                        if (loginConfig.ListPengguna.pengguna[j].pekerja.Status == State.searching)
                        {
                            label11.Text = "Mencari Pekerjaan";
                        } else if (loginConfig.ListPengguna.pengguna[j].pekerja.Status == State.unemployed)
                        {
                            label11.Text = "Tidak memiliki pekerjaan";
                        }
                        else if (loginConfig.ListPengguna.pengguna[j].pekerja.Status == State.unemployed)
                        {
                            label11.Text = "Sudah memiliki pekerjaan";
                        }
                        found = true;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            int i;
            if (listBox1.SelectedItem != null)
            {
                bool found = false;
                for (int j = 0; j < loginConfig.ListPengguna.pengguna.Count && !found; j++)
                {
                    if (loginConfig.ListPengguna.pengguna[j].pekerja.idPekerja == dataCariPekerja[listBox1.SelectedIndex].idPekerja)
                    {
                        for (int k = 0; k < loginConfig.ListPengguna.pengguna[j].pekerja.lamaranDikirim.Count; k++)
                        {
                            if (loginConfig.ListPengguna.pengguna[j].pekerja.lamaranDikirim[k].idPekerjaan == this.idPekerjaan)
                            {
                                string fileJawaban = loginConfig.ListPengguna.pengguna[j].pekerja.lamaranDikirim[k].jawaban;
                                byte[] fileBytes = Convert.FromBase64String(fileJawaban);
                                string outputFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Jawaban lamaran pekerjaan dari " + loginConfig.ListPengguna.pengguna[j].fullname + loginConfig.ListPengguna.pengguna[j].pekerja.lamaranDikirim[k].idPekerjaan);
                                File.WriteAllBytes(outputFilePath, fileBytes);

                                MessageBox.Show($"File data loaded and saved as {outputFilePath}");
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            string idCv = "";
            int i;
            if (listBox1.SelectedItem != null)
            {
                bool found = false;
                for (int j = 0; j < loginConfig.ListPengguna.pengguna.Count && !found; j++)
                {
                    if (loginConfig.ListPengguna.pengguna[j].pekerja.idPekerja == dataCariPekerja[listBox1.SelectedIndex].idPekerja)
                    {
                        idCv = loginConfig.ListPengguna.pengguna[j].pekerja.Cv.idCv;
                        found = true;
                    }
                }
            }
            LihatCV halamanLihatCV = new LihatCV(idCv, this.idPekerjaan);
            halamanLihatCV.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnggahPekerjaanConfig config = new UnggahPekerjaanConfig();
            config.TerimaOrTolakPekerja(dataCariPekerja[listBox1.SelectedIndex].idPekerja, this.idPekerjaan, true);
            Kandidat halamanKandidat = new Kandidat(idPekerjaan);
            halamanKandidat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnggahPekerjaanConfig config = new UnggahPekerjaanConfig();
            config.TerimaOrTolakPekerja(dataCariPekerja[listBox1.SelectedIndex].idPekerja, this.idPekerjaan, false);
            Kandidat halamanKandidat = new Kandidat(idPekerjaan);
            halamanKandidat.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
    public class DataCariPekerja
    {
        public string idPekerja { get; set; }
        public string namaPekerja { get; set; }
        public DataCariPekerja(string idPekerja, string namaPekerja)
        {
            this.idPekerja = idPekerja;
            this.namaPekerja = namaPekerja;
        }
    }
}
