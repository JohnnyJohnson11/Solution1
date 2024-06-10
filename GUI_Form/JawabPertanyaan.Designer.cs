namespace GUI_Form
{
    partial class JawabPertanyaan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JawabPertanyaan));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            button7 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -5);
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
            label2.Location = new Point(64, 29);
            label2.Name = "label2";
            label2.Size = new Size(237, 32);
            label2.TabIndex = 35;
            label2.Text = "Jawab Pertanyaan";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(775, 496);
            button1.Name = "button1";
            button1.Size = new Size(173, 38);
            button1.TabIndex = 48;
            button1.Text = "Kirim Lamaran";
            button1.UseVisualStyleBackColor = false;
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
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(375, 245);
            button3.Name = "button3";
            button3.Size = new Size(229, 36);
            button3.TabIndex = 82;
            button3.Text = "Browse Jawaban";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(206, 288);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(578, 30);
            textBox1.TabIndex = 83;
            textBox1.Text = "Pilih FIle";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(375, 181);
            button2.Name = "button2";
            button2.Size = new Size(229, 36);
            button2.TabIndex = 84;
            button2.Text = "Lihat Pertanyaan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // JawabPertanyaan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "JawabPertanyaan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Button button7;
        private Button button3;
        private TextBox textBox1;
        private Button button2;
    }
}