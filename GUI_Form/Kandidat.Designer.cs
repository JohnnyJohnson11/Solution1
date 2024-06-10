namespace GUI_Form
{
    partial class Kandidat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kandidat));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            button1 = new Button();
            label3 = new Label();
            button7 = new Button();
            label4 = new Label();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(978, 566);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GrayText;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(71, 24);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 24;
            label2.Text = "Kandidat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(21, 86);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 25;
            label1.Text = "Nama;";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(21, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 378);
            listBox1.TabIndex = 28;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(750, 498);
            button3.Name = "button3";
            button3.Size = new Size(198, 36);
            button3.TabIndex = 33;
            button3.Text = "Terima";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(546, 498);
            button1.Name = "button1";
            button1.Size = new Size(198, 36);
            button1.TabIndex = 34;
            button1.Text = "Tolak";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Desktop;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(552, 86);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 29;
            label3.Text = "Jawaban:";
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(12, 12);
            button7.Name = "button7";
            button7.Size = new Size(37, 29);
            button7.TabIndex = 81;
            button7.Text = "<";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Desktop;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(221, 86);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 82;
            label4.Text = "Profil";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(552, 124);
            button2.Name = "button2";
            button2.Size = new Size(184, 36);
            button2.TabIndex = 85;
            button2.Text = "Download Jawaban";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(221, 318);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 89;
            label6.Text = "No. Telpon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(221, 257);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 88;
            label5.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(221, 191);
            label7.Name = "label7";
            label7.Size = new Size(134, 23);
            label7.TabIndex = 87;
            label7.Text = "Tanggal Lahir:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(221, 124);
            label8.Name = "label8";
            label8.Size = new Size(66, 23);
            label8.TabIndex = 86;
            label8.Text = "Nama:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(374, 318);
            label10.Name = "label10";
            label10.Size = new Size(96, 23);
            label10.TabIndex = 93;
            label10.Text = "(notelpon)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(374, 257);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
            label9.TabIndex = 92;
            label9.Text = "(email)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(374, 191);
            label11.Name = "label11";
            label11.Size = new Size(124, 23);
            label11.TabIndex = 91;
            label11.Text = "(tanggallahir)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(374, 124);
            label12.Name = "label12";
            label12.Size = new Size(69, 23);
            label12.TabIndex = 90;
            label12.Text = "(nama)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Desktop;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Transparent;
            label13.Location = new Point(552, 191);
            label13.Name = "label13";
            label13.Size = new Size(38, 23);
            label13.TabIndex = 94;
            label13.Text = "CV";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(552, 229);
            button4.Name = "button4";
            button4.Size = new Size(97, 36);
            button4.TabIndex = 95;
            button4.Text = "Lihat CV";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Kandidat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(button4);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Kandidat";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private Button button3;
        private Button button1;
        private Label label3;
        private Button button7;
        private Label label4;
        private Button button2;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button4;
    }
}