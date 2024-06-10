using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using TubesKPL_WorkersUnion;
using UtilityLibraries;

namespace GUI_Form
{
    public partial class iklanPekerjaan : Form
    {
        private List<string> judulPekerjaan = new List<string>();
        private List<string> jumlahKandidat = new List<string>();
        private List<string> KumpulanIdPekerjaan = new List<string>();
        public iklanPekerjaan()
        {
            InitializeComponent();
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            Logged_In logged_in = Logged_In.GetInstance("", "");
            int i;
            for (i = 0; i < loginConfig.ListPengguna.pengguna.Count; i++)
            {
                if (loginConfig.ListPengguna.pengguna[i].perusahaan.idPerusahaan == logged_in.idPerusahaan)
                {
                    int j;
                    for (j = 0; j < loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan.Count; j++)
                    {
                        judulPekerjaan.Add(loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].judulPekerjaan);
                        if (loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].lamaranDiterima != null)
                        {
                            jumlahKandidat.Add(loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].lamaranDiterima.Count.ToString());
                        }
                        else
                        {
                            jumlahKandidat.Add("0");
                        }
                        KumpulanIdPekerjaan.Add(loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].idPekerjaan);
                    }
                }
            }
            listBox1.DataSource = judulPekerjaan;
            listBox2.DataSource = jumlahKandidat;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostingPekerjaan halamanPostingPekerjaan = new PostingPekerjaan();
            halamanPostingPekerjaan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kandidat halamanKandidat = new Kandidat(KumpulanIdPekerjaan.ElementAt(listBox1.SelectedIndex));
            halamanKandidat.Show();
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
