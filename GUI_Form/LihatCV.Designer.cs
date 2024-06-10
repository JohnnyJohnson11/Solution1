namespace GUI_Form
{
    partial class LihatCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatCV));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            button7 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(978, 566);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GrayText;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(68, 22);
            label2.Name = "label2";
            label2.Size = new Size(54, 32);
            label2.TabIndex = 45;
            label2.Text = "CV";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(280, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 30);
            textBox1.TabIndex = 50;
            textBox1.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 306);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 49;
            label5.Text = "Skill:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 152);
            label3.Name = "label3";
            label3.Size = new Size(180, 23);
            label3.TabIndex = 48;
            label3.Text = "Riwayat Pekerjaan:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 98);
            label1.Name = "label1";
            label1.Size = new Size(185, 23);
            label1.TabIndex = 47;
            label1.Text = "Riwayat Pendidikan:";
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
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(280, 150);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(450, 127);
            richTextBox1.TabIndex = 82;
            richTextBox1.Text = "";
            richTextBox1.ReadOnly = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(280, 304);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(450, 127);
            richTextBox2.TabIndex = 83;
            richTextBox2.Text = "";
            richTextBox2.ReadOnly = true;
            // 
            // LihatCV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "LihatCV";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
        private Label label1;
        private Button button7;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}