using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Form
{
    public partial class Pertanyaan : Form
    {
        public Pertanyaan()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            openFileDialog.FilterIndex = 1;

            // Call the ShowDialog method to show the dialog box
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog.FileName;

                // Display the selected file path in the TextBox
                textBox1.Text = selectedFilePath;
            }
        }
    }
}
