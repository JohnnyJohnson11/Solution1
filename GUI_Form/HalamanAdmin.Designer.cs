namespace GUI_Form
{
    partial class HalamanAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanAdmin));
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(978, 561);
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(66, 118);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 378);
            listBox1.TabIndex = 83;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GrayText;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(65, 22);
            label2.Name = "label2";
            label2.Size = new Size(278, 32);
            label2.TabIndex = 85;
            label2.Text = "Verifikasi Perusahaan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(65, 64);
            label4.Name = "label4";
            label4.Size = new Size(596, 25);
            label4.TabIndex = 97;
            label4.Text = "Berikut adalah list perusahaan yang memerlukan tindakan";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(750, 160);
            button1.Name = "button1";
            button1.Size = new Size(198, 36);
            button1.TabIndex = 99;
            button1.Text = "Tolak";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(750, 118);
            button3.Name = "button3";
            button3.Size = new Size(198, 36);
            button3.TabIndex = 98;
            button3.Text = "Terima";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 506);
            button5.Name = "button5";
            button5.Size = new Size(121, 39);
            button5.TabIndex = 100;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(456, 314);
            label10.Name = "label10";
            label10.Size = new Size(81, 23);
            label10.TabIndex = 109;
            label10.Text = "(alamat)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(456, 253);
            label9.Name = "label9";
            label9.Size = new Size(59, 23);
            label9.TabIndex = 108;
            label9.Text = "(aset)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(456, 187);
            label11.Name = "label11";
            label11.Size = new Size(86, 23);
            label11.TabIndex = 107;
            label11.Text = "(tanggal)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(456, 120);
            label12.Name = "label12";
            label12.Size = new Size(95, 23);
            label12.TabIndex = 106;
            label12.Text = "(kategori)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(303, 314);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 105;
            label6.Text = "Alamat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(303, 253);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 104;
            label5.Text = "Aset:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(303, 187);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 103;
            label7.Text = "Tanggal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(303, 120);
            label8.Name = "label8";
            label8.Size = new Size(91, 23);
            label8.TabIndex = 102;
            label8.Text = "Kategori:";
            // 
            // HalamanAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Name = "HalamanAdmin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Label label2;
        private Label label4;
        private Button button1;
        private Button button3;
        private Button button5;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
    }
}