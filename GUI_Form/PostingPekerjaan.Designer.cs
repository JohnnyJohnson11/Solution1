namespace GUI_Form
{
    partial class PostingPekerjaan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostingPekerjaan));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(978, 67);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(227, 23);
            label1.TabIndex = 21;
            label1.Text = "Klasifikasikan peran anda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 22;
            label2.Text = "Judul Pekerjaan";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 30);
            textBox1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 24;
            label3.Text = "Provinsi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 236);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 26;
            label4.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(522, 70);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 28;
            label5.Text = "Gaji";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(522, 158);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(131, 26);
            radioButton1.TabIndex = 29;
            radioButton1.TabStop = true;
            radioButton1.Text = "Gaji per jam";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(522, 190);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(133, 26);
            radioButton2.TabIndex = 30;
            radioButton2.TabStop = true;
            radioButton2.Text = "Gaji per hari";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(522, 222);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(145, 26);
            radioButton3.TabIndex = 31;
            radioButton3.TabStop = true;
            radioButton3.Text = "Gaji per bulan";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(816, 478);
            button1.Name = "button1";
            button1.Size = new Size(111, 39);
            button1.TabIndex = 32;
            button1.Text = "Konfirmasi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Desktop;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(5, 9);
            label6.Name = "label6";
            label6.Size = new Size(21, 23);
            label6.TabIndex = 35;
            label6.Text = "<";
            label6.Click += label6_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 265);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(450, 252);
            richTextBox1.TabIndex = 49;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "NanggroeAcehDarusallam", "SumateraUtara", "SumateraSelatan", "SumateraBarat", "Bengkulu", "Riau", "KepulauanRiau", "Jambi", "Lampung", "BangkaBelitung", "KalimantanBarat", "KalimantanTimur", "KalimantanSelatan", "KalimantanTengah", "KalimantanUtara", "Banten", "DKIJakarta", "JawaBarat", "JawaTengah", "DaerahIstimewaYogyakarta", "JawaTimur", "Bali", "NusaTenggaraTimur ", "NusaTenggaraBarat", "SulawesiBarat", "SulawesiTengah", "SulawesiUtara", "SulawesiTenggara", "SulawesiSelatan", "MalukuUtara", "Maluku", "Papua" });
            comboBox1.Location = new Point(12, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 50;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(310, 190);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(310, 154);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 51;
            label7.Text = "Kota";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(522, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 30);
            textBox2.TabIndex = 53;
            // 
            // PostingPekerjaan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PostingPekerjaan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Label label6;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox textBox2;
    }
}