namespace GUI_Form
{
    partial class iklanPekerjaan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iklanPekerjaan));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button3 = new Button();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(978, 566);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GrayText;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(59, 22);
            label2.Name = "label2";
            label2.Size = new Size(362, 32);
            label2.TabIndex = 23;
            label2.Text = "Iklan pekerjaan terbaru saya";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(22, 83);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 24;
            label1.Text = "Pekerjaan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Desktop;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(390, 83);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 26;
            label4.Text = "Kandidat";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(22, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(362, 378);
            listBox1.TabIndex = 27;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 22;
            listBox2.Location = new Point(390, 124);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(95, 378);
            listBox2.TabIndex = 28;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(526, 124);
            button3.Name = "button3";
            button3.Size = new Size(204, 36);
            button3.TabIndex = 32;
            button3.Text = "Lihat selengkapnya";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(767, 22);
            button1.Name = "button1";
            button1.Size = new Size(181, 36);
            button1.TabIndex = 33;
            button1.Text = "Posting Pekerjaan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Desktop;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(22, 9);
            label3.Name = "label3";
            label3.Size = new Size(21, 23);
            label3.TabIndex = 34;
            label3.Text = "<";
            label3.Click += label3_Click;
            // 
            // iklanPekerjaan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "iklanPekerjaan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button3;
        private Button button1;
        private Label label3;
    }
}