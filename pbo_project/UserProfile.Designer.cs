namespace pbo_project
{
    partial class UserProfile
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
            dgvdonasi = new DataGridView();
            btnupbukti = new Button();
            btnsimpan = new Button();
            btnhps = new Button();
            tbnamadn = new TextBox();
            tbnominal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pbbukti = new PictureBox();
            cbstatus = new ComboBox();
            btnubah = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvdonasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbbukti).BeginInit();
            SuspendLayout();
            // 
            // dgvdonasi
            // 
            dgvdonasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdonasi.Location = new Point(12, 257);
            dgvdonasi.Name = "dgvdonasi";
            dgvdonasi.Size = new Size(472, 130);
            dgvdonasi.TabIndex = 0;
            dgvdonasi.CellContentClick += dgvdonasi_CellContentClick;
            // 
            // btnupbukti
            // 
            btnupbukti.Location = new Point(420, 172);
            btnupbukti.Name = "btnupbukti";
            btnupbukti.Size = new Size(75, 23);
            btnupbukti.TabIndex = 3;
            btnupbukti.Text = "UPLOAD";
            btnupbukti.UseVisualStyleBackColor = true;
            btnupbukti.Click += btnupbukti_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(34, 203);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(75, 23);
            btnsimpan.TabIndex = 4;
            btnsimpan.Text = "SIMPAN";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnhps
            // 
            btnhps.Location = new Point(115, 203);
            btnhps.Name = "btnhps";
            btnhps.Size = new Size(75, 23);
            btnhps.TabIndex = 5;
            btnhps.Text = "HAPUS";
            btnhps.UseVisualStyleBackColor = true;
            btnhps.Click += btnhps_Click;
            // 
            // tbnamadn
            // 
            tbnamadn.Location = new Point(113, 59);
            tbnamadn.Name = "tbnamadn";
            tbnamadn.Size = new Size(117, 23);
            tbnamadn.TabIndex = 6;
            // 
            // tbnominal
            // 
            tbnominal.Location = new Point(113, 95);
            tbnominal.Name = "tbnominal";
            tbnominal.Size = new Size(117, 23);
            tbnominal.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 8;
            label1.Text = "Nama Donatur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 9;
            label2.Text = "Nominal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 59);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 10;
            label3.Text = "Bukti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Status";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // pbbukti
            // 
            pbbukti.Location = new Point(322, 59);
            pbbukti.Name = "pbbukti";
            pbbukti.Size = new Size(173, 107);
            pbbukti.TabIndex = 13;
            pbbukti.TabStop = false;
            // 
            // cbstatus
            // 
            cbstatus.FormattingEnabled = true;
            cbstatus.Location = new Point(113, 143);
            cbstatus.Name = "cbstatus";
            cbstatus.Size = new Size(121, 23);
            cbstatus.TabIndex = 14;
            // 
            // btnubah
            // 
            btnubah.Location = new Point(196, 203);
            btnubah.Name = "btnubah";
            btnubah.Size = new Size(75, 23);
            btnubah.TabIndex = 15;
            btnubah.Text = "UBAH";
            btnubah.UseVisualStyleBackColor = true;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnubah);
            Controls.Add(cbstatus);
            Controls.Add(pbbukti);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbnominal);
            Controls.Add(tbnamadn);
            Controls.Add(btnhps);
            Controls.Add(btnsimpan);
            Controls.Add(btnupbukti);
            Controls.Add(dgvdonasi);
            Name = "UserProfile";
            Size = new Size(514, 432);
            Load += UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdonasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbbukti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdonasi;
        private Button btnupbukti;
        private Button btnsimpan;
        private Button btnhps;
        private TextBox tbnamadn;
        private TextBox tbnominal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private PictureBox pbbukti;
        private ComboBox cbstatus;
        private Button btnubah;
    }
}
