namespace pbo_project
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.
        /// </param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            lblprogress = new Label();
            progressdonasi = new ProgressBar();
            btnlaporan = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnprogram = new Button();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnDonasi = new Button();
            btnJadwal = new Button();
            btnKegiatan = new Button();
            btnkas = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(btnkas);
            panel1.Controls.Add(lblprogress);
            panel1.Controls.Add(progressdonasi);
            panel1.Controls.Add(btnlaporan);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnprogram);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnDonasi);
            panel1.Controls.Add(btnJadwal);
            panel1.Controls.Add(btnKegiatan);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 722);
            panel1.TabIndex = 0;
            // 
            // lblprogress
            // 
            lblprogress.AutoSize = true;
            lblprogress.Location = new Point(287, 218);
            lblprogress.Name = "lblprogress";
            lblprogress.Size = new Size(91, 15);
            lblprogress.TabIndex = 13;
            lblprogress.Text = "Progress Donasi";
            // 
            // progressdonasi
            // 
            progressdonasi.BackColor = Color.ForestGreen;
            progressdonasi.Enabled = false;
            progressdonasi.ForeColor = SystemColors.HotTrack;
            progressdonasi.Location = new Point(287, 236);
            progressdonasi.Name = "progressdonasi";
            progressdonasi.Size = new Size(425, 23);
            progressdonasi.TabIndex = 12;
            progressdonasi.Click += progressdonasi_Click;
            // 
            // btnlaporan
            // 
            btnlaporan.BackColor = Color.Ivory;
            btnlaporan.Location = new Point(33, 373);
            btnlaporan.Name = "btnlaporan";
            btnlaporan.Size = new Size(165, 24);
            btnlaporan.TabIndex = 11;
            btnlaporan.Text = "LAPORAN";
            btnlaporan.UseVisualStyleBackColor = false;
            btnlaporan.Click += btnlaporan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 130);
            label3.Name = "label3";
            label3.Size = new Size(630, 23);
            label3.TabIndex = 10;
            label3.Text = "Jadwal salat, informasi masjid, donasi, dan laporan keuangan dalam satu tempat.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 98);
            label2.Name = "label2";
            label2.Size = new Size(258, 32);
            label2.TabIndex = 9;
            label2.Text = "Assalamu'alaikum,\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 23);
            label1.Name = "label1";
            label1.Size = new Size(247, 18);
            label1.TabIndex = 8;
            label1.Text = "Cicangkudu · Mangunreja · Tasikmalaya";
            // 
            // btnprogram
            // 
            btnprogram.BackColor = Color.Ivory;
            btnprogram.Location = new Point(33, 334);
            btnprogram.Name = "btnprogram";
            btnprogram.Size = new Size(165, 23);
            btnprogram.TabIndex = 7;
            btnprogram.Text = "PROGRAM";
            btnprogram.UseVisualStyleBackColor = false;
            btnprogram.Click += btnprogram_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.Location = new Point(33, 670);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(165, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDonasi
            // 
            btnDonasi.BackColor = Color.Ivory;
            btnDonasi.Location = new Point(33, 210);
            btnDonasi.Name = "btnDonasi";
            btnDonasi.Size = new Size(165, 23);
            btnDonasi.TabIndex = 2;
            btnDonasi.Text = "DONASI";
            btnDonasi.UseVisualStyleBackColor = false;
            btnDonasi.Click += btnDonasi_Click;
            // 
            // btnJadwal
            // 
            btnJadwal.BackColor = Color.Ivory;
            btnJadwal.Location = new Point(33, 254);
            btnJadwal.Name = "btnJadwal";
            btnJadwal.Size = new Size(165, 23);
            btnJadwal.TabIndex = 3;
            btnJadwal.Text = "JADWAL";
            btnJadwal.UseVisualStyleBackColor = false;
            btnJadwal.Click += btnJadwal_Click;
            // 
            // btnKegiatan
            // 
            btnKegiatan.BackColor = Color.Ivory;
            btnKegiatan.Location = new Point(33, 296);
            btnKegiatan.Name = "btnKegiatan";
            btnKegiatan.Size = new Size(165, 23);
            btnKegiatan.TabIndex = 4;
            btnKegiatan.Text = "KEGIATAN";
            btnKegiatan.UseVisualStyleBackColor = false;
            btnKegiatan.Click += btnKegiatan_Click;
            // 
            // btnkas
            // 
            btnkas.Location = new Point(33, 410);
            btnkas.Name = "btnkas";
            btnkas.Size = new Size(165, 23);
            btnkas.TabIndex = 14;
            btnkas.Text = "KAS";
            btnkas.UseVisualStyleBackColor = true;
            btnkas.Click += btnkas_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 720);
            Controls.Add(panel1);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnDonasi;
        private Button btnJadwal;
        private Button btnKegiatan;
        private Button btnprogram;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnlaporan;
        private ProgressBar progressdonasi;
        private Label lblprogress;
        private Button btnkas;
    }
}