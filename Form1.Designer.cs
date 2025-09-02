namespace TopUpGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbnamgame = new ComboBox();
            cmbnom = new ComboBox();
            cmbmet = new ComboBox();
            txtus = new TextBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnbay = new Button();
            txtemail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(322, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 32);
            textBox1.TabIndex = 0;
            textBox1.Text = "Top Up Game";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 92);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Pilih Nama Game :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 156);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Masukkan User ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 214);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 3;
            label3.Text = "Piih Nominal Top Up :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 272);
            label4.Name = "label4";
            label4.Size = new Size(149, 15);
            label4.TabIndex = 4;
            label4.Text = "Pilih Metode Pembayaran :";
            // 
            // cmbnamgame
            // 
            cmbnamgame.FormattingEnabled = true;
            cmbnamgame.Location = new Point(202, 110);
            cmbnamgame.Name = "cmbnamgame";
            cmbnamgame.Size = new Size(174, 23);
            cmbnamgame.TabIndex = 6;
            // 
            // cmbnom
            // 
            cmbnom.FormattingEnabled = true;
            cmbnom.Location = new Point(202, 232);
            cmbnom.Name = "cmbnom";
            cmbnom.Size = new Size(174, 23);
            cmbnom.TabIndex = 7;
            // 
            // cmbmet
            // 
            cmbmet.FormattingEnabled = true;
            cmbmet.Location = new Point(202, 290);
            cmbmet.Name = "cmbmet";
            cmbmet.Size = new Size(174, 23);
            cmbmet.TabIndex = 8;
            // 
            // txtus
            // 
            txtus.Location = new Point(202, 174);
            txtus.Name = "txtus";
            txtus.Size = new Size(174, 23);
            txtus.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diamond_Gems_White_Transparent__Gem_Cartoon_Diamond_Game__Gem_Clipart__Illustration__Cartoon_PNG_Image_For_Free_Download__3___1__removebg_preview;
            pictureBox1.Location = new Point(382, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 92);
            label6.Name = "label6";
            label6.Size = new Size(134, 15);
            label6.TabIndex = 12;
            label6.Text = "Harap Masukkan Email :";
            // 
            // btnbay
            // 
            btnbay.Location = new Point(367, 353);
            btnbay.Name = "btnbay";
            btnbay.Size = new Size(75, 23);
            btnbay.TabIndex = 14;
            btnbay.Text = "Bayar";
            btnbay.UseVisualStyleBackColor = true;
            btnbay.Click += btnbay_Click_1;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(464, 110);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(174, 23);
            txtemail.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(txtemail);
            Controls.Add(btnbay);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(txtus);
            Controls.Add(cmbmet);
            Controls.Add(cmbnom);
            Controls.Add(cmbnamgame);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbnamgame;
        private ComboBox cmbnom;
        private ComboBox cmbmet;
        private TextBox txtus;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnbay;
        private TextBox txtemail;
    }
}
