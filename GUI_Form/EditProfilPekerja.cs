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
    public partial class EditProfilPekerja : Form
    {
        public EditProfilPekerja()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Profil halamanProfil = new Profil();
            halamanProfil.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnggahPekerjaanConfig config=new UnggahPekerjaanConfig();
            Logged_In logged_in = Logged_In.GetInstance("", "");
            config.UbahDataPekerja(logged_in.idPekerja, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            Profil halamanProfil = new Profil();
            halamanProfil.Show();
            this.Hide();
        }
    }
}
