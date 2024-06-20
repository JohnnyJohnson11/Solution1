using GUI_Form;
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
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginConfig loginConfig= new LoginConfig();
            Logged_In logged_In =Logged_In.GetInstance("", "");
            bool found = false;
            string status = "";
            showGUI showGUI=new showGUI();
            for (int i = 0;  i < loginConfig.ListPengguna.pengguna.Count&&!found; i++)
            {
                if (logged_In.idPerusahaan == loginConfig.ListPengguna.pengguna[i].perusahaan.idPerusahaan)
                {
                    if (loginConfig.ListPengguna.pengguna[i].perusahaan.Status==StatusPerusahaan.MemasukkanInfoPerusahaan)
                    {
                        showGUI.pending();
                    } else if (loginConfig.ListPengguna.pengguna[i].perusahaan.Status==StatusPerusahaan.Ditolak)
                    {
                        showGUI.ditolak();
                    }
                    else if (loginConfig.ListPengguna.pengguna[i].perusahaan.Status == StatusPerusahaan.Disetujui)
                    {
                        showGUI.diterima();
                    }
                    this.Hide();
                    found = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CariPekerjaan halamanCariPekerjaan = new CariPekerjaan();
            halamanCariPekerjaan.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profil halamanProfil = new Profil();
            halamanProfil.Show();
            this.Hide();
        }
        private void showGUI(string status)
        {

        }
    }
}
class showGUI
{
    public void ditolak()
    {
        VerifikasiPerusahaan halamanVerifikasiPerusahaan = new VerifikasiPerusahaan();
        halamanVerifikasiPerusahaan.Show();
    }
    public void diterima()
    {
        GUI_Form.Perusahaan halamanPerusahaan = new GUI_Form.Perusahaan();
        halamanPerusahaan.Show();
    }
    public void pending()
    {
        MenungguVerifikasi halamanMenungguVerifikasi = new MenungguVerifikasi();
        halamanMenungguVerifikasi.Show();
    }
}
