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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 halamanRegister = new Form2();
            halamanRegister.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool found = false;
            string username = textBox1.Text;
            string password = textBox2.Text;
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            VerifikasiConfig verifikasiConfig = new VerifikasiConfig();
            int i;
            for (i = 0; i < loginConfig.ListPengguna.pengguna.Count; i++)
            {
                if (loginConfig.ListPengguna.pengguna[i].username == username && password == loginConfig.ListPengguna.pengguna[i].password)
                {
                    //Pindah ke menu utama
                    found = true;
                    Logged_In logged_In = Logged_In.ResetInstance(loginConfig.ListPengguna.pengguna[i].perusahaan.idPerusahaan, loginConfig.ListPengguna.pengguna[i].pekerja.idPekerja);
                    if (loginConfig.ListPengguna.pengguna[0].perusahaan.idPerusahaan==logged_In.idPerusahaan && 
                        loginConfig.ListPengguna.pengguna[0].pekerja.idPekerja== logged_In.idPekerja)
                    {
                        HalamanAdmin halamanAdmin= new HalamanAdmin();
                        halamanAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        HalamanUtama halamanUtama = new HalamanUtama();
                        halamanUtama.Show();
                        this.Hide();
                    }
                }
            }
            if (!found)
            {
                DialogResult result = MessageBox.Show(this, "Password atau email tidak sesuai", "Wrong password or email", MessageBoxButtons.OK);
            }
        }
    }
}
