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
    public partial class LihatCV : Form
    {
        private string idCv;
        private string idPekerjaan;
        public LihatCV(string idCv, string idPekerjaan)
        {
            InitializeComponent();
            this.idCv= idCv;
            this.idPekerjaan= idPekerjaan;
            MessageBox.Show(this.idCv);
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            for (int i = 0; i<loginConfig.ListPengguna.pengguna.Count; i++)
            {
                if (this.idCv == loginConfig.ListPengguna.pengguna[i].pekerja.Cv.idCv)
                {
                    textBox1.Text = loginConfig.ListPengguna.pengguna[i].pekerja.Cv.riwayatPendidikan;
                    richTextBox1.Text = loginConfig.ListPengguna.pengguna[i].pekerja.Cv.riwayatPekerjaan;
                    richTextBox2.Text = loginConfig.ListPengguna.pengguna[i].pekerja.Cv.skill;
                }
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Kandidat halamanKandidat = new Kandidat(this.idPekerjaan);
            halamanKandidat.Show();
            this.Hide();
        }
    }
}
