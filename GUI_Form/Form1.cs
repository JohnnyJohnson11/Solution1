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
    public partial class Form1 : Form
    {
        public Form1()
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
            while (!found)
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                LoginConfig loginConfig = new LoginConfig();
                loginConfig.ReadConfigFile();
                int i;
                for (i = 0; i < loginConfig.ListPengguna.pengguna.Count; i++)
                {
                    if (loginConfig.ListPengguna.pengguna[i].username == username && password == loginConfig.ListPengguna.pengguna[i].password)
                    {
                        //Pindah ke menu utama
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    DialogResult result = MessageBox.Show(this, "Password tidak sesuai", "Wrong password", MessageBoxButtons.OK);
                }
            }
        }
    }
}
