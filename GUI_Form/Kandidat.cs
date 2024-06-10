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
            DataCariPekerja data = new DataCariPekerja();
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            int i;
            bool found= false;
            for (i = 0; i < loginConfig.ListPengguna.pengguna.Count&&!found ; i++)
            {
                if (loginConfig.ListPengguna.pengguna[i].perusahaan.idPerusahaan=="PR"+idPekerjaan.Substring(3,7))
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
                            for (k = 0; k < loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].lamaranDiterima.Count&& loginConfig.ListPengguna.pengguna[i].perusahaan.postinganPekerjaan[j].lamaranDiterima!=null; k++)
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
                for (j = 0; j < loginConfig.ListPengguna.pengguna.Count&&!found; j++)
                {
                    if(kumpulanIdPekerja[i] == loginConfig.ListPengguna.pengguna[j].pekerja.idPekerja)
                    {
                        namaPekerja.Add(loginConfig.ListPengguna.pengguna[j].username);
                        found = true;
                    }
                }
            }
            listBox1.DataSource = namaPekerja;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            iklanPekerjaan halamanIklanPekerjaan = new iklanPekerjaan();
            halamanIklanPekerjaan.Show();
            this.Hide();
        }

    }
    public class DataCariPekerja
    {
        public string idPekerja { get; set; }
        public string namaPekerja { get; set; }
    }
}
