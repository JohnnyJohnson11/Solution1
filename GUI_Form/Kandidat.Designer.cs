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
            label4 = new Label();
            richTextBox1 = new RichTextBox();
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
            label2.Location = new Point(46, 23);
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
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(830, 124);
            button3.Name = "button3";
            button3.Size = new Size(89, 36);
            button3.TabIndex = 33;
            button3.Text = "Terima";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(830, 166);
            button1.Name = "button1";
            button1.Size = new Size(89, 36);
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
            label3.Location = new Point(216, 86);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 29;
            label3.Text = "Jawaban:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Desktop;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(19, 9);
            label4.Name = "label4";
            label4.Size = new Size(21, 23);
            label4.TabIndex = 35;
            label4.Text = "<";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(216, 124);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(450, 378);
            richTextBox1.TabIndex = 50;
            richTextBox1.Text = "";
            // 
            // Kandidat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
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
        private Label label4;
        private RichTextBox richTextBox1;
    }
}