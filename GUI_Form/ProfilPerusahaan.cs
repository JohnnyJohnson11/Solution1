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
    public partial class ProfilPerusahaan : Form
    {
        public ProfilPerusahaan()
        {
            InitializeComponent();
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            Logged_In logged_In = Logged_In.GetInstance("", "");
            bool found = false;
            for (int i = 0; i < loginConfig.ListPengguna.pengguna.Count && !found; i++)
            {
                if (loginConfig.ListPengguna.pengguna[i].pekerja.idPekerja == logged_In.idPekerja)
                {
                    label4.Text = loginConfig.ListPengguna.pengguna[i].perusahaan.Nama;
                    label11.Text = loginConfig.ListPengguna.pengguna[i].perusahaan.Email;
                    label12.Text = loginConfig.ListPengguna.pengguna[i].perusahaan.NomorTelepon;
                    if (loginConfig.ListPengguna.pengguna[i].perusahaan.lokasi[0] == -1 || loginConfig.ListPengguna.pengguna[i].perusahaan.lokasi[1] == -1)
                    {
                        label9.Text = "Belum Terdaftar";
                        label10.Text = "Belum Terdaftar";
                    }
                    else
                    {
                        label9.Text = Enum.GetName(typeof(Lokasi.Provinsi), loginConfig.ListPengguna.pengguna[i].perusahaan.lokasi[0]);
                        label10.Text = Lokasi.getKota(loginConfig.ListPengguna.pengguna[i].perusahaan.lokasi[0])[loginConfig.ListPengguna.pengguna[i].perusahaan.lokasi[1]];
                    }
                    richTextBox1.Text = loginConfig.ListPengguna.pengguna[i].perusahaan.Deskripsi;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Perusahaan halamanPerusahaan = new Perusahaan();
            halamanPerusahaan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProfilPerusahaan halamanEditProfilPerusahaan = new EditProfilPerusahaan();
            halamanEditProfilPerusahaan.Show();
            this.Hide();
        }
    }
}
