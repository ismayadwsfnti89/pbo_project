namespace pbo_project
{
    partial class UserProgram
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnsimpn = new Button();
            btnedit = new Button();
            btnbatal = new Button();
            btnhapus = new Button();
            dgvProgram = new DataGridView();
            cbStatus = new ComboBox();
            NamaProgram = new TextBox();
            tbDeskripsi = new TextBox();
            tbTarget = new TextBox();
            idProgram = new TextBox();
            label6 = new Label();
            btnkembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProgram).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 154);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 196);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Program";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 240);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Target";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 289);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 447);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // btnsimpn
            // 
            btnsimpn.BackColor = Color.DarkGreen;
            btnsimpn.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsimpn.ForeColor = SystemColors.ButtonHighlight;
            btnsimpn.Location = new Point(154, 493);
            btnsimpn.Name = "btnsimpn";
            btnsimpn.Size = new Size(144, 23);
            btnsimpn.TabIndex = 5;
            btnsimpn.Text = "SIMPAN";
            btnsimpn.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.Gainsboro;
            btnedit.Location = new Point(494, 590);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(144, 23);
            btnedit.TabIndex = 6;
            btnedit.Text = "EDIT";
            btnedit.UseVisualStyleBackColor = false;
            // 
            // btnbatal
            // 
            btnbatal.BackColor = SystemColors.GradientActiveCaption;
            btnbatal.Location = new Point(653, 590);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(144, 23);
            btnbatal.TabIndex = 7;
            btnbatal.Text = "BATAL";
            btnbatal.UseVisualStyleBackColor = false;
            // 
            // btnhapus
            // 
            btnhapus.BackColor = Color.Brown;
            btnhapus.ForeColor = SystemColors.ButtonHighlight;
            btnhapus.Location = new Point(333, 590);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(144, 23);
            btnhapus.TabIndex = 8;
            btnhapus.Text = "HAPUS";
            btnhapus.UseVisualStyleBackColor = false;
            // 
            // dgvProgram
            // 
            dgvProgram.BackgroundColor = Color.Azure;
            dgvProgram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProgram.Location = new Point(333, 151);
            dgvProgram.Name = "dgvProgram";
            dgvProgram.Size = new Size(830, 412);
            dgvProgram.TabIndex = 9;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(154, 444);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(144, 23);
            cbStatus.TabIndex = 10;
            // 
            // NamaProgram
            // 
            NamaProgram.Location = new Point(154, 193);
            NamaProgram.Name = "NamaProgram";
            NamaProgram.Size = new Size(144, 23);
            NamaProgram.TabIndex = 11;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Location = new Point(154, 286);
            tbDeskripsi.Multiline = true;
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(144, 132);
            tbDeskripsi.TabIndex = 12;
            // 
            // tbTarget
            // 
            tbTarget.Location = new Point(154, 237);
            tbTarget.Name = "tbTarget";
            tbTarget.Size = new Size(144, 23);
            tbTarget.TabIndex = 13;
            // 
            // idProgram
            // 
            idProgram.Location = new Point(154, 151);
            idProgram.Name = "idProgram";
            idProgram.Size = new Size(49, 23);
            idProgram.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(425, 33);
            label6.Name = "label6";
            label6.Size = new Size(269, 31);
            label6.TabIndex = 15;
            label6.Text = "PROGRAM DONASI";
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(26, 17);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(75, 23);
            btnkembali.TabIndex = 16;
            btnkembali.Text = "< KEMBALI";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // UserProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(btnkembali);
            Controls.Add(tbDeskripsi);
            Controls.Add(label6);
            Controls.Add(idProgram);
            Controls.Add(tbTarget);
            Controls.Add(NamaProgram);
            Controls.Add(cbStatus);
            Controls.Add(dgvProgram);
            Controls.Add(btnhapus);
            Controls.Add(btnbatal);
            Controls.Add(btnedit);
            Controls.Add(btnsimpn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserProgram";
            Size = new Size(1180, 745);
            ((System.ComponentModel.ISupportInitialize)dgvProgram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnsimpn;
        private Button btnedit;
        private Button btnbatal;
        private Button btnhapus;
        private DataGridView dgvProgram;
        private ComboBox cbStatus;
        private TextBox NamaProgram;
        private TextBox tbDeskripsi;
        private TextBox tbTarget;
        private TextBox idProgram;
        private Label label6;
        private Button btnkembali;
    }
}
