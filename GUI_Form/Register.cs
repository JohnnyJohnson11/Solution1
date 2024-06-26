﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            string fullname = textBox3.Text;
            string username = textBox4.Text;
            string email = textBox1.Text;
            string password = textBox2.Text;
            bool exist = false;
            bool semuaAngka = true;
            DialogResult result = new DialogResult();
            for (int i=0; i < loginConfig.ListPengguna.pengguna.Count&&!exist; i++)
            {
                if (loginConfig.ListPengguna.pengguna[i].username==username)
                {
                    exist = true;
                }
            }
            for (int i = 0; i < password.Length - 1 && semuaAngka; i++)
            {
                char c = password[i];
                semuaAngka = semuaAngka && int.TryParse(c.ToString(), out _);
            }
            if (fullname == "" || username == "" || email == "" || password == "")
            {
                result = MessageBox.Show(this, "Isi semua box di atas", "Invalid content", MessageBoxButtons.OK);
            }
            else if (exist)
            {
                result = MessageBox.Show(this, "Username sudah terdaftar", "Invalid username", MessageBoxButtons.OK);
            }
            else if (semuaAngka)
            {
                result = MessageBox.Show(this, "Password tidak boleh semua angka", "Invalid password", MessageBoxButtons.OK);
            }
            else
            {
                UnggahPekerjaanConfig config = new UnggahPekerjaanConfig();
                config.Register(fullname, username, email, password);
                result = MessageBox.Show(this, "Akun Terdaftar", "Success", MessageBoxButtons.OK);
                Login halamanLogin = new Login();
                halamanLogin.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login halamanLogin = new Login();
            halamanLogin.Show();
            this.Hide();
        }
    }
}
