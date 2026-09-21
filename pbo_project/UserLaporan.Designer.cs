namespace pbo_project
{
    partial class UserLaporan
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
            btnKembali = new Button();
            lblJudul = new Label();
            lblSubjudul = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.LightGray;
            btnKembali.Location = new Point(29, 23);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 30);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "< KEMBALI";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Times New Roman", 22F, FontStyle.Bold);
            lblJudul.ForeColor = Color.Transparent;
            lblJudul.Location = new Point(356, 23);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(346, 35);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "LAPORAN KEUANGAN";
            // 
            // lblSubjudul
            // 
            lblSubjudul.AutoSize = true;
            lblSubjudul.Font = new Font("Calibri", 11F);
            lblSubjudul.ForeColor = Color.DarkGreen;
            lblSubjudul.Location = new Point(29, 107);
            lblSubjudul.Name = "lblSubjudul";
            lblSubjudul.Size = new Size(396, 18);
            lblSubjudul.TabIndex = 2;
            lblSubjudul.Text = "Ringkasan pemasukan, pengeluaran, dan saldo akhir kas masjid";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Ivory;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1112, 591);
            dataGridView1.TabIndex = 3;
            // 
            // UserLaporan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(btnKembali);
            Controls.Add(lblJudul);
            Controls.Add(lblSubjudul);
            Controls.Add(dataGridView1);
            Name = "UserLaporan";
            Size = new Size(1180, 745);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubjudul;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}