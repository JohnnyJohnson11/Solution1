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
    public partial class CV : Form
    {
        public CV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            Logged_In logged_in = Logged_In.GetInstance("", "");
            bool found = false;
            int i;
            UnggahPekerjaanConfig config = new UnggahPekerjaanConfig();
            config.TambahCv(logged_in.idPekerja, textBox1.Text, richTextBox1.Text, richTextBox2.Text);
            Profil halamanProfil = new Profil();
            halamanProfil.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Profil halamanProfil = new Profil();
            halamanProfil.Show();
            this.Hide();
        }
    }
}
