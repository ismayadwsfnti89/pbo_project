namespace pbo_project
{
    partial class UserKas
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
            lblJudul = new Label();
            lblId = new Label();
            lblJenis = new Label();
            lblKategori = new Label();
            lblKeterangan = new Label();
            lblNominal = new Label();
            lblTanggal = new Label();
            tbId = new TextBox();
            cbJenis = new ComboBox();
            cbKategori = new ComboBox();
            tbKeterangan = new TextBox();
            tbNominal = new TextBox();
            dtTanggal = new DateTimePicker();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnBatal = new Button();
            btnKembali = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            lblJudul.ForeColor = Color.Transparent;
            lblJudul.Location = new Point(482, 30);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(179, 31);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "KAS MASJID";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(33, 105);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID Kas";
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.Location = new Point(33, 140);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(32, 15);
            lblJenis.TabIndex = 3;
            lblJenis.Text = "Jenis";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(33, 180);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(51, 15);
            lblKategori.TabIndex = 5;
            lblKategori.Text = "Kategori";
            // 
            // lblKeterangan
            // 
            lblKeterangan.AutoSize = true;
            lblKeterangan.Location = new Point(33, 220);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(67, 15);
            lblKeterangan.TabIndex = 7;
            lblKeterangan.Text = "Keterangan";
            // 
            // lblNominal
            // 
            lblNominal.AutoSize = true;
            lblNominal.Location = new Point(33, 260);
            lblNominal.Name = "lblNominal";
            lblNominal.Size = new Size(53, 15);
            lblNominal.TabIndex = 9;
            lblNominal.Text = "Nominal";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(33, 303);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(49, 15);
            lblTanggal.TabIndex = 11;
            lblTanggal.Text = "Tanggal";
            // 
            // tbId
            // 
            tbId.Location = new Point(108, 102);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(150, 23);
            tbId.TabIndex = 2;
            // 
            // cbJenis
            // 
            cbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJenis.Location = new Point(108, 137);
            cbJenis.Name = "cbJenis";
            cbJenis.Size = new Size(150, 23);
            cbJenis.TabIndex = 4;
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.Location = new Point(108, 177);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(150, 23);
            cbKategori.TabIndex = 6;
            // 
            // tbKeterangan
            // 
            tbKeterangan.Location = new Point(108, 212);
            tbKeterangan.Name = "tbKeterangan";
            tbKeterangan.Size = new Size(150, 23);
            tbKeterangan.TabIndex = 8;
            // 
            // tbNominal
            // 
            tbNominal.Location = new Point(108, 257);
            tbNominal.Name = "tbNominal";
            tbNominal.Size = new Size(150, 23);
            tbNominal.TabIndex = 10;
            // 
            // dtTanggal
            // 
            dtTanggal.Format = DateTimePickerFormat.Short;
            dtTanggal.Location = new Point(108, 297);
            dtTanggal.Name = "dtTanggal";
            dtTanggal.Size = new Size(150, 23);
            dtTanggal.TabIndex = 12;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.DarkGreen;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(13, 360);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 30);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gainsboro;
            btnEdit.Location = new Point(139, 360);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 30);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Brown;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(13, 400);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(120, 30);
            btnHapus.TabIndex = 15;
            btnHapus.Text = "HAPUS";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Gainsboro;
            btnBatal.Location = new Point(139, 400);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(120, 30);
            btnBatal.TabIndex = 16;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.LightGray;
            btnKembali.Location = new Point(13, 16);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(97, 26);
            btnKembali.TabIndex = 17;
            btnKembali.Text = "< KEMBALI";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(264, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(900, 623);
            dataGridView1.TabIndex = 99;
            // 
            // UserKas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(lblJudul);
            Controls.Add(lblId);
            Controls.Add(tbId);
            Controls.Add(lblJenis);
            Controls.Add(cbJenis);
            Controls.Add(lblKategori);
            Controls.Add(cbKategori);
            Controls.Add(lblKeterangan);
            Controls.Add(tbKeterangan);
            Controls.Add(lblNominal);
            Controls.Add(tbNominal);
            Controls.Add(lblTanggal);
            Controls.Add(dtTanggal);
            Controls.Add(btnSimpan);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(btnBatal);
            Controls.Add(btnKembali);
            Controls.Add(dataGridView1);
            Name = "UserKas";
            Size = new Size(1180, 745);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblNominal;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox tbKeterangan;
        private System.Windows.Forms.TextBox tbNominal;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}