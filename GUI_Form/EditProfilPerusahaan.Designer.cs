namespace GUI_Form
{
    partial class EditProfilPerusahaan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfilPerusahaan));
            button1 = new Button();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            button7 = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(782, 506);
            button1.Name = "button1";
            button1.Size = new Size(166, 39);
            button1.TabIndex = 113;
            button1.Text = "Simpan Profil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(264, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(450, 30);
            textBox4.TabIndex = 112;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(264, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 30);
            textBox1.TabIndex = 109;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(12, 12);
            button7.Name = "button7";
            button7.Size = new Size(37, 29);
            button7.TabIndex = 108;
            button7.Text = "<";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 276);
            label6.Name = "label6";
            label6.Size = new Size(65, 23);
            label6.TabIndex = 107;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 215);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 106;
            label5.Text = "Kota:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 149);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 105;
            label3.Text = "Provinsi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 82);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 104;
            label1.Text = "Nama Perusahaan:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GrayText;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(67, 23);
            label2.Name = "label2";
            label2.Size = new Size(291, 32);
            label2.TabIndex = 103;
            label2.Text = "Edit Profil Perusahaan";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(978, 566);
            pictureBox1.TabIndex = 102;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "NanggroeAcehDarusallam", "SumateraUtara", "SumateraSelatan", "SumateraBarat", "Bengkulu", "Riau", "KepulauanRiau", "Jambi", "Lampung", "BangkaBelitung", "KalimantanBarat", "KalimantanTimur", "KalimantanSelatan", "KalimantanTengah", "KalimantanUtara", "Banten", "DKIJakarta", "JawaBarat", "JawaTengah", "DaerahIstimewaYogyakarta", "JawaTimur", "Bali", "NusaTenggaraTimur ", "NusaTenggaraBarat", "SulawesiBarat", "SulawesiTengah", "SulawesiUtara", "SulawesiTenggara", "SulawesiSelatan", "MalukuUtara", "Maluku", "Papua" });
            comboBox1.Location = new Point(264, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 30);
            comboBox1.TabIndex = 114;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(264, 208);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 30);
            comboBox2.TabIndex = 115;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(264, 330);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(450, 30);
            textBox2.TabIndex = 117;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 337);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 116;
            label4.Text = "No. Telpon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(39, 399);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 118;
            label7.Text = "Deskripsi:";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(264, 397);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(450, 130);
            richTextBox1.TabIndex = 119;
            richTextBox1.Text = "";
            // 
            // EditProfilPerusahaan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(button7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "EditProfilPerusahaan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox4;
        private TextBox textBox1;
        private Button button7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label4;
        private Label label7;
        private RichTextBox richTextBox1;
    }
}