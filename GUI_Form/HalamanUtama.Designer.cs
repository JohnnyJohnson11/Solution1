namespace GUI_Form
{
    partial class HalamanUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanUtama));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(978, 574);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(580, 25);
            button1.Name = "button1";
            button1.Size = new Size(181, 36);
            button1.TabIndex = 19;
            button1.Text = "Profil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 47);
            label1.Name = "label1";
            label1.Size = new Size(396, 51);
            label1.TabIndex = 20;
            label1.Text = "Temukan pekerjaan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 98);
            label2.Name = "label2";
            label2.Size = new Size(332, 51);
            label2.TabIndex = 21;
            label2.Text = "impianmu di sini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 149);
            label3.Name = "label3";
            label3.Size = new Size(297, 23);
            label3.TabIndex = 22;
            label3.Text = "Selamat datang di Workers Union,";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 172);
            label4.Name = "label4";
            label4.Size = new Size(420, 23);
            label4.TabIndex = 23;
            label4.Text = "pintu gerbang Anda menuju dunia penuh peluang.";
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(33, 374);
            button2.Name = "button2";
            button2.Size = new Size(181, 36);
            button2.TabIndex = 24;
            button2.Text = "Cari Pekerjaan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(220, 374);
            button4.Name = "button4";
            button4.Size = new Size(181, 36);
            button4.TabIndex = 26;
            button4.Text = "Lokasi";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(767, 25);
            button3.Name = "button3";
            button3.Size = new Size(181, 36);
            button3.TabIndex = 27;
            button3.Text = "Perusahaan";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // HalamanUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "HalamanUtama";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button4;
        private Button button3;
    }
}