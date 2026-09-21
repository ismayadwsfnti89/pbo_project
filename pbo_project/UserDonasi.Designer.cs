namespace pbo_project
{
    partial class UserDonasi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            date = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbId = new TextBox();
            cbProgram = new ComboBox();
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
            date.Location = new Point(146, 175);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 123);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 33;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 152);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 31;
            label3.Text = "Program";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 207);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 30;
            label4.Text = "Nama Donatur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 307);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 29;
            label5.Text = "Bukti";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 237);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 28;
            label6.Text = "Nominal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 181);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 27;
            label7.Text = "Tanggal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.GhostWhite;
            label8.Location = new Point(463, 23);
            label8.Name = "label8";
            label8.Size = new Size(125, 32);
            label8.TabIndex = 26;
            label8.Text = "DONASI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 267);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 25;
            label9.Text = "Metode";
            // 
            // tbId
            // 
            tbId.Location = new Point(146, 120);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(36, 23);
            tbId.TabIndex = 10;
            // 
            // cbProgram
            // 
            cbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProgram.Location = new Point(146, 149);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(60, 23);
            cbProgram.TabIndex = 12;
            // 
            // tbNma
            // 
            tbNma.Location = new Point(146, 204);
            tbNma.Name = "tbNma";
            tbNma.Size = new Size(200, 23);
            tbNma.TabIndex = 13;
            // 
            // tbNominal
            // 
            tbNominal.Location = new Point(146, 234);
            tbNominal.Name = "tbNominal";
            tbNominal.Size = new Size(200, 23);
            tbNominal.TabIndex = 14;
            // 
            // pictureBoxBukti
            // 
            pictureBoxBukti.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxBukti.Location = new Point(146, 307);
            pictureBoxBukti.Name = "pictureBoxBukti";
            pictureBoxBukti.Size = new Size(200, 80);
            pictureBoxBukti.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBukti.TabIndex = 15;
            pictureBoxBukti.TabStop = false;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Calibri", 9.75F);
            cbStatus.Location = new Point(146, 268);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(200, 23);
            cbStatus.TabIndex = 16;
            // 
            // btnupload
            // 
            btnupload.Location = new Point(246, 393);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(100, 23);
            btnupload.TabIndex = 17;
            btnupload.Text = "UPLOAD";
            btnupload.UseVisualStyleBackColor = true;
            btnupload.Click += btnupload_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.BackColor = SystemColors.Highlight;
            btnsimpan.ForeColor = Color.White;
            btnsimpan.Location = new Point(46, 464);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(133, 30);
            btnsimpan.TabIndex = 18;
            btnsimpan.Text = "SIMPAN";
            btnsimpan.UseVisualStyleBackColor = false;
            // 
            // btnbatal
            // 
            btnbatal.BackColor = Color.Gainsboro;
            btnbatal.Location = new Point(46, 500);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(133, 30);
            btnbatal.TabIndex = 19;
            btnbatal.Text = "BATAL";
            btnbatal.UseVisualStyleBackColor = false;
            // 
            // btnhps
            // 
            btnhps.BackColor = Color.Firebrick;
            btnhps.ForeColor = Color.White;
            btnhps.Location = new Point(185, 500);
            btnhps.Name = "btnhps";
            btnhps.Size = new Size(133, 30);
            btnhps.TabIndex = 20;
            btnhps.Text = "HAPUS";
            btnhps.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            btnedit.BackColor = SystemColors.GradientActiveCaption;
            btnedit.Location = new Point(185, 464);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(133, 30);
            btnedit.TabIndex = 21;
            btnedit.Text = "UPDATE";
            btnedit.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Ivory;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(780, 540);
            dataGridView1.TabIndex = 22;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(18, 12);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(97, 25);
            btnkembali.TabIndex = 23;
            btnkembali.Text = "KEMBALI";
            btnkembali.UseVisualStyleBackColor = true;
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
            Controls.Add(cbProgram);
            Controls.Add(tbId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(date);
            Name = "UserDonasi";
            Size = new Size(1180, 745);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBukti).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.TextBox tbNma;
        private System.Windows.Forms.TextBox tbNominal;
        private System.Windows.Forms.PictureBox pictureBoxBukti;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.Button btnhps;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkembali;
    }
}