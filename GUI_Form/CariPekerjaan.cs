using MySql.Data.MySqlClient;
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
    public partial class CariPekerjaan : Form
    {
        private List<DataCariPekerjaan> dataCariPekerjaan = new List<DataCariPekerjaan>();
        public CariPekerjaan()
        {
            InitializeComponent();
            List<string> judulPekerjaan = new List<string>();
            DataCariPekerjaan data;
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            int i;
            for (i = 0; i < loginConfig.ListPengguna.pengguna.Count; i++)
            {
                int j;
                for (j = 0; j < loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan.Count; j++)
                {
                    if (loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan != null)
                    {
                        judulPekerjaan.Add(loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].judulPekerjaan);
                        data = new DataCariPekerjaan(loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].idPekerjaan, 
                            loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].judulPekerjaan);
                        dataCariPekerjaan.Add(data);
                    }
                }
            }
            listBox1.DataSource = judulPekerjaan;
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
                    for (int k = 0; k < loginConfig.ListPengguna.pengguna[j].perusahaan.postinganPekerjaan.Count && !found; k++)
                    {
                        if (loginConfig.ListPengguna.pengguna[j].perusahaan.postinganPekerjaan[k].idPekerjaan == dataCariPekerjaan[listBox1.SelectedIndex].idPekerjaan)
                        {
                            richTextBox2.Text = Enum.GetName(typeof(Lokasi.Provinsi), loginConfig.ListPengguna.pengguna[j].perusahaan.postinganPekerjaan[k].lokasi[0]) + ", " + Lokasi.getKota(loginConfig.ListPengguna.pengguna[j].perusahaan.postinganPekerjaan[k].lokasi[0])[loginConfig.ListPengguna.pengguna[j].perusahaan.postinganPekerjaan[k].lokasi[1]];
                            richTextBox3.Text = loginConfig.ListPengguna.pengguna[j].perusahaan.postinganPekerjaan[k].gaji;
                            richTextBox1.Text = loginConfig.ListPengguna.pengguna[j].perusahaan.postinganPekerjaan[k].deskripsiPekerjaan;
                            found = true;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JawabPertanyaan halamanJawab = new JawabPertanyaan(dataCariPekerjaan.ElementAt(listBox1.SelectedIndex).idPekerjaan);
            halamanJawab.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataCariPekerjaan.Clear();
            string inputPengguna = textBox1.Text;
            LoginConfig loginConfig = new LoginConfig();
            DataCariPekerjaan data;
            List<string> judulPekerjaan = new List<string>();
            loginConfig.ReadConfigFile();
            string kataDicari;
            List<string> hasilPencarian = new List<string>();
            char[] whitespace = new char[] { ' ', '\t' };
            bool verified;
            bool found;
            for (int i = 0; i < loginConfig.ListPengguna.pengguna.Count; i++)
            {
                for (int j = 0; j < loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan.Count; j++)
                {
                    verified = false;
                    found = false;
                    string[] pisahKata = loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].judulPekerjaan.Split(whitespace);
                    for (int l = 0; l < pisahKata.Length; l++)
                    {
                        kataDicari = null;
                        for (int k = l; k < pisahKata.Length && !verified; k++)
                        {
                            kataDicari = kataDicari + " " + pisahKata[k];
                            if (LevenshteinDistance(inputPengguna, kataDicari) <= kataDicari.Length * 2 / 4)
                            {
                                hasilPencarian.Add(loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].judulPekerjaan);
                                data = new DataCariPekerjaan(loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].idPekerjaan, loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].judulPekerjaan);
                                dataCariPekerjaan.Add(data);
                                judulPekerjaan.Add(loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].judulPekerjaan);
                                verified = true;
                            }
                        }
                    }
                }
            }
            listBox1.DataSource = judulPekerjaan;
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox1.Text = "";
        }
        private int LevenshteinDistance(string inputPengguna, string hasilPencarian)
        {
            int panjangInputPengguna = inputPengguna.Length+1;
            int panjangHasilPencarian = hasilPencarian.Length+1;
            int[][] dp = new int[panjangInputPengguna][];

            for (int i = 0; i < panjangInputPengguna; i++)
            {
                dp[i] = new int[panjangHasilPencarian];
            }
            for (int i = 0; i <= inputPengguna.Length; i++)
            {
                for (int j = 0; j <= hasilPencarian.Length; j++)
                {
                    if (i == 0)
                    {
                        dp[i][j] = j;
                    }
                    else if (j == 0)
                    {
                        dp[i][j] = i;
                    }
                    else
                    {
                        dp[i][j] = Math.Min(
                            dp[i - 1][j - 1] + (inputPengguna.ElementAt(i - 1) == hasilPencarian.ElementAt(j - 1) ? 0 : 1),
                            Math.Min(dp[i - 1][j] + 1, dp[i][j - 1] + 1)
                        );
                    }
                }
            }

            return dp[inputPengguna.Length][hasilPencarian.Length];
        }
    }
    public class DataCariPekerjaan
    {
        public string idPekerjaan { get; set; }
        public string judulPekerjaan {  get; set; }
        public DataCariPekerjaan(string idPekerjaan, string judulPekerjaan)
        {
            this.idPekerjaan = idPekerjaan;
            this.judulPekerjaan = judulPekerjaan;
        }
    }


}
