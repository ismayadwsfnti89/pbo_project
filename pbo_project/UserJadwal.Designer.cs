namespace pbo_project
{
    partial class UserJadwal
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
            this.btnKembali = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.bulan = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // btnKembali
            this.btnKembali.BackColor = System.Drawing.Color.LightGray;
            this.btnKembali.Location = new System.Drawing.Point(30, 20);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(90, 30);
            this.btnKembali.TabIndex = 0;
            this.btnKembali.Text = "< KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = false;

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Transparent;
            this.lblJudul.Location = new System.Drawing.Point(387, 14);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(267, 35);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "JADWAL SHOLAT";

            // btnPrev
            this.btnPrev.BackColor = System.Drawing.Color.Ivory;
            this.btnPrev.Location = new System.Drawing.Point(633, 87);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(108, 30);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "< SEBELUMNYA";
            this.btnPrev.UseVisualStyleBackColor = false;

            // bulan
            this.bulan.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.bulan.ForeColor = System.Drawing.Color.DarkGreen;
            this.bulan.Location = new System.Drawing.Point(387, 94);
            this.bulan.Name = "bulan";
            this.bulan.Size = new System.Drawing.Size(240, 25);
            this.bulan.TabIndex = 3;
            this.bulan.Text = "Memuat...";
            this.bulan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnNext
            this.btnNext.BackColor = System.Drawing.Color.Ivory;
            this.btnNext.Location = new System.Drawing.Point(259, 89);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 26);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "SELANJUTNYA >";
            this.btnNext.UseVisualStyleBackColor = false;

            // button1 (REFRESH)
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(776, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = false;

            // dataGridView1
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1098, 590);
            this.dataGridView1.TabIndex = 6;

            // UserJadwal
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.bulan);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserJadwal";
            this.Size = new System.Drawing.Size(1180, 745);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label bulan;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}