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
            richTextBox2 = new RichTextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
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
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(284, 118);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(420, 378);
            richTextBox2.TabIndex = 84;
            richTextBox2.Text = "";
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
            label4.Click += this.label4_Click;
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
            // 
            // HalamanAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(richTextBox2);
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
        private RichTextBox richTextBox2;
        private ListBox listBox1;
        private Label label2;
        private Label label4;
        private Button button1;
        private Button button3;
        private Button button5;
    }
}