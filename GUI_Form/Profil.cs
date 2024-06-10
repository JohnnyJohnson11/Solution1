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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            Logged_In logged_In = Logged_In.GetInstance("", "");
            bool found = false;
            for (int i = 0; i<loginConfig.ListPengguna.pengguna.Count&&!found; i++)
            {
                if (loginConfig.ListPengguna.pengguna[i].pekerja.idPekerja==logged_In.idPekerja)
                {
                    label4.Text = loginConfig.ListPengguna.pengguna[i].fullname;
                    label8.Text= loginConfig.ListPengguna.pengguna[i].pekerja.tanggalLahir;
                    label9.Text = loginConfig.ListPengguna.pengguna[i].email;
                    label10.Text = loginConfig.ListPengguna.pengguna[i].pekerja.noTelepon;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login halamanLogin = new Login();
            halamanLogin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CV halamanCv = new CV();
            halamanCv.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProfilPekerja halamanEditProfilPekerja = new EditProfilPekerja();
            halamanEditProfilPekerja.Show();
            this.Hide();
        }
    }
}
