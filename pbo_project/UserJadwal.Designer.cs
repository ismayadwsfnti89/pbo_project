namespace pbo_project
{
    partial class UserJadwal
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
            Button button1;
            dataGridView1 = new DataGridView();
            bulan = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            btnKembali = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(559, 764);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(119, 23);
            button1.TabIndex = 11;
            button1.Text = "REFRESH";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1208, 587);
            dataGridView1.TabIndex = 12;
            // 
            // bulan
            // 
            bulan.AutoSize = true;
            bulan.Location = new Point(597, 102);
            bulan.Name = "bulan";
            bulan.Size = new Size(70, 15);
            bulan.TabIndex = 13;
            bulan.Text = "SEPTEMBER";
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(410, 98);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 14;
            btnPrev.Text = "SEBELUMNYA";
            btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(756, 98);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 15;
            btnNext.Text = "SELANJUTNYA";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(23, 16);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 23);
            btnKembali.TabIndex = 16;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // UserJadwal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(btnKembali);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(bulan);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "UserJadwal";
            Size = new Size(1308, 811);
            Load += UserJadwal_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbsubuh;
        private TextBox tbdzuhur;
        private TextBox tbasar;
        private TextBox tbmaghrib;
        private TextBox tbisya;
        private Button button1;
        private DataGridView dataGridView1;
        private Label bulan;
        private Button btnPrev;
        private Button btnNext;
        private Button btnKembali;
    }
}
