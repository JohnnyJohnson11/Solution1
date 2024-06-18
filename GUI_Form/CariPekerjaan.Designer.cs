namespace GUI_Form
{
    partial class CariPekerjaan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariPekerjaan));
            label3 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            richTextBox3 = new RichTextBox();
            button3 = new Button();
            label2 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Desktop;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(235, 85);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 40;
            label3.Text = "Lokasi:";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(17, 123);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 378);
            listBox1.TabIndex = 39;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(17, 85);
            label1.Name = "label1";
            label1.Size = new Size(155, 23);
            label1.TabIndex = 38;
            label1.Text = "Judul Pekerjaan:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(978, 566);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Desktop;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(513, 85);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 45;
            label5.Text = "Deskripsi:";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(803, 123);
            button1.Name = "button1";
            button1.Size = new Size(145, 61);
            button1.TabIndex = 47;
            button1.Text = "Jawab Pertanyaan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(511, 123);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(268, 378);
            richTextBox1.TabIndex = 48;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(235, 123);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(132, 378);
            richTextBox2.TabIndex = 49;
            richTextBox2.Text = "";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(235, 22);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 30);
            textBox1.TabIndex = 50;
            textBox1.Text = "Cari Pekerjaan";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tertinggi", "Terendah" });
            comboBox1.Location = new Point(502, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(81, 30);
            comboBox1.TabIndex = 51;
            comboBox1.Text = "Gaji";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Desktop;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(373, 85);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 52;
            label6.Text = "Gaji:";
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(373, 123);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(132, 378);
            richTextBox3.TabIndex = 53;
            richTextBox3.Text = "";
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(683, 22);
            button3.Name = "button3";
            button3.Size = new Size(96, 36);
            button3.TabIndex = 54;
            button3.Text = "Cari";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GrayText;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(60, 22);
            label2.Name = "label2";
            label2.Size = new Size(136, 32);
            label2.TabIndex = 37;
            label2.Text = "Pekerjaan";
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(26, 12);
            button7.Name = "button7";
            button7.Size = new Size(37, 29);
            button7.TabIndex = 81;
            button7.Text = "<";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // CariPekerjaan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(richTextBox3);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "CariPekerjaan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private ListBox listBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label6;
        private RichTextBox richTextBox3;
        private Button button3;
        private Label label2;
        private Button button7;
    }
}