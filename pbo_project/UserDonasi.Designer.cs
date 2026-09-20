namespace pbo_project
{
    partial class UserDonasi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            date = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbId = new TextBox();
            tbIdUsers = new TextBox();
            tbIDProgram = new TextBox();
            tbNma = new TextBox();
            tbNominal = new TextBox();
            pictureBoxBukti = new PictureBox();
            cbStatus = new ComboBox();
            btnupload = new Button();
            btnsimpan = new Button();
            btnbatal = new Button();
            btnhps = new Button();
            btnedit = new Button();
            dataGridView1 = new DataGridView();
            btnkembali = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBukti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // date
            // 
            date.Location = new Point(311, 128);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 139);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 176);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "ID Users";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 218);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "ID Program";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 173);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 4;
            label4.Text = "Nama Donatur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 136);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 5;
            label5.Text = "Bukti";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 218);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 6;
            label6.Text = "Nominal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(205, 134);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 7;
            label7.Text = "Tanggal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(544, 15);
            label8.Name = "label8";
            label8.Size = new Size(104, 26);
            label8.TabIndex = 8;
            label8.Text = "DONASI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(205, 257);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 9;
            label9.Text = "Status";
            // 
            // tbId
            // 
            tbId.Location = new Point(127, 134);
            tbId.Name = "tbId";
            tbId.Size = new Size(36, 23);
            tbId.TabIndex = 10;
            // 
            // tbIdUsers
            // 
            tbIdUsers.Location = new Point(127, 170);
            tbIdUsers.Name = "tbIdUsers";
            tbIdUsers.Size = new Size(36, 23);
            tbIdUsers.TabIndex = 11;
            // 
            // tbIDProgram
            // 
            tbIDProgram.Location = new Point(127, 215);
            tbIDProgram.Name = "tbIDProgram";
            tbIDProgram.Size = new Size(36, 23);
            tbIDProgram.TabIndex = 12;
            // 
            // tbNma
            // 
            tbNma.Location = new Point(311, 170);
            tbNma.Name = "tbNma";
            tbNma.Size = new Size(200, 23);
            tbNma.TabIndex = 13;
            // 
            // tbNominal
            // 
            tbNominal.Location = new Point(311, 215);
            tbNominal.Name = "tbNominal";
            tbNominal.Size = new Size(200, 23);
            tbNominal.TabIndex = 14;
            // 
            // pictureBoxBukti
            // 
            pictureBoxBukti.Location = new Point(609, 130);
            pictureBoxBukti.Name = "pictureBoxBukti";
            pictureBoxBukti.Size = new Size(186, 133);
            pictureBoxBukti.TabIndex = 15;
            pictureBoxBukti.TabStop = false;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Transfer", "QRIS" });
            cbStatus.Location = new Point(311, 254);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(200, 23);
            cbStatus.TabIndex = 16;
            // 
            // btnupload
            // 
            btnupload.Location = new Point(609, 269);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(75, 23);
            btnupload.TabIndex = 17;
            btnupload.Text = "UPLOAD";
            btnupload.UseVisualStyleBackColor = true;
            btnupload.Click += btnupload_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.BackColor = SystemColors.Highlight;
            btnsimpan.Location = new Point(46, 679);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(133, 23);
            btnsimpan.TabIndex = 18;
            btnsimpan.Text = "SIMPAN";
            btnsimpan.UseVisualStyleBackColor = false;
            // 
            // btnbatal
            // 
            btnbatal.BackColor = Color.Gainsboro;
            btnbatal.Location = new Point(185, 679);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(133, 23);
            btnbatal.TabIndex = 19;
            btnbatal.Text = "BATAL";
            btnbatal.UseVisualStyleBackColor = false;
            btnbatal.Click += btnbatal_Click;
            // 
            // btnhps
            // 
            btnhps.BackColor = Color.Firebrick;
            btnhps.Location = new Point(463, 679);
            btnhps.Name = "btnhps";
            btnhps.Size = new Size(133, 23);
            btnhps.TabIndex = 20;
            btnhps.Text = "HAPUS";
            btnhps.UseVisualStyleBackColor = false;
            btnhps.Click += btnhps_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = SystemColors.GradientActiveCaption;
            btnedit.Location = new Point(324, 679);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(133, 23);
            btnedit.TabIndex = 21;
            btnedit.Text = "UPDATE";
            btnedit.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Ivory;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1105, 357);
            dataGridView1.TabIndex = 22;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(602, 679);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(133, 23);
            btnkembali.TabIndex = 23;
            btnkembali.Text = "KEMBALI";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // UserDonasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(btnkembali);
            Controls.Add(dataGridView1);
            Controls.Add(btnedit);
            Controls.Add(btnhps);
            Controls.Add(btnbatal);
            Controls.Add(btnsimpan);
            Controls.Add(btnupload);
            Controls.Add(cbStatus);
            Controls.Add(pictureBoxBukti);
            Controls.Add(tbNominal);
            Controls.Add(tbNma);
            Controls.Add(tbIDProgram);
            Controls.Add(tbIdUsers);
            Controls.Add(tbId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(date);
            Name = "UserDonasi";
            Size = new Size(1189, 755);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBukti).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker date;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbId;
        private TextBox tbIdUsers;
        private TextBox tbIDProgram;
        private TextBox tbNma;
        private TextBox tbNominal;
        private PictureBox pictureBoxBukti;
        private ComboBox cbStatus;
        private Button btnupload;
        private Button btnsimpan;
        private Button btnbatal;
        private Button btnhps;
        private Button btnedit;
        private DataGridView dataGridView1;
        private Button btnkembali;
    }
}
