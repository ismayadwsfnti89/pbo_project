namespace pbo_project
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnlogin = new Button();
            tbpassword = new TextBox();
            label1 = new Label();
            tbemail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(299, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(tbpassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbemail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 447);
            panel1.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(106, 387);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(116, 272);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(153, 23);
            tbpassword.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 127);
            label1.Name = "label1";
            label1.Size = new Size(218, 60);
            label1.TabIndex = 1;
            label1.Text = "SISTEM DIGITAL MASJID JAMI CICANGKUDU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(116, 228);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(153, 23);
            tbemail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 275);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 231);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 187);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Login ke akun anda";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormLogin";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnlogin;
        private TextBox tbpassword;
        private Label label1;
        private TextBox tbemail;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
