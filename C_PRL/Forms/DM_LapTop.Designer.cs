namespace C_PRL.Forms
{
    partial class DM_LapTop
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_NhaCC = new System.Windows.Forms.GroupBox();
            this.grb_TacVu = new System.Windows.Forms.GroupBox();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Show = new System.Windows.Forms.Button();
            this.grb_DSNCC = new System.Windows.Forms.GroupBox();
            this.dtg_ShowLT = new System.Windows.Forms.DataGridView();
            this.grb_TTNCC = new System.Windows.Forms.GroupBox();
            this.bt_ThemAanh = new System.Windows.Forms.Button();
            this.ptb_Anh = new System.Windows.Forms.PictureBox();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.txt_CanNang = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_TenLapTop = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaLapTop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grb_NhaCC.SuspendLayout();
            this.grb_TacVu.SuspendLayout();
            this.grb_DSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowLT)).BeginInit();
            this.grb_TTNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_NhaCC
            // 
            this.grb_NhaCC.Controls.Add(this.grb_TacVu);
            this.grb_NhaCC.Controls.Add(this.grb_DSNCC);
            this.grb_NhaCC.Controls.Add(this.grb_TTNCC);
            this.grb_NhaCC.Location = new System.Drawing.Point(12, 44);
            this.grb_NhaCC.Name = "grb_NhaCC";
            this.grb_NhaCC.Size = new System.Drawing.Size(733, 589);
            this.grb_NhaCC.TabIndex = 9;
            this.grb_NhaCC.TabStop = false;
            // 
            // grb_TacVu
            // 
            this.grb_TacVu.Controls.Add(this.bt_Xoa);
            this.grb_TacVu.Controls.Add(this.bt_Sua);
            this.grb_TacVu.Controls.Add(this.bt_Them);
            this.grb_TacVu.Controls.Add(this.bt_Show);
            this.grb_TacVu.Location = new System.Drawing.Point(16, 433);
            this.grb_TacVu.Name = "grb_TacVu";
            this.grb_TacVu.Size = new System.Drawing.Size(711, 113);
            this.grb_TacVu.TabIndex = 2;
            this.grb_TacVu.TabStop = false;
            this.grb_TacVu.Text = "Tác Vụ";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(602, 41);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(105, 45);
            this.bt_Xoa.TabIndex = 3;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(414, 41);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(105, 45);
            this.bt_Sua.TabIndex = 2;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(218, 41);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(105, 45);
            this.bt_Them.TabIndex = 1;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Show
            // 
            this.bt_Show.Location = new System.Drawing.Point(35, 41);
            this.bt_Show.Name = "bt_Show";
            this.bt_Show.Size = new System.Drawing.Size(105, 45);
            this.bt_Show.TabIndex = 0;
            this.bt_Show.Text = "Show";
            this.bt_Show.UseVisualStyleBackColor = true;
            this.bt_Show.Click += new System.EventHandler(this.bt_Show_Click);
            // 
            // grb_DSNCC
            // 
            this.grb_DSNCC.Controls.Add(this.dtg_ShowLT);
            this.grb_DSNCC.Location = new System.Drawing.Point(16, 281);
            this.grb_DSNCC.Name = "grb_DSNCC";
            this.grb_DSNCC.Size = new System.Drawing.Size(717, 146);
            this.grb_DSNCC.TabIndex = 1;
            this.grb_DSNCC.TabStop = false;
            this.grb_DSNCC.Text = "Danh Sách LapTop";
            // 
            // dtg_ShowLT
            // 
            this.dtg_ShowLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowLT.Location = new System.Drawing.Point(19, 26);
            this.dtg_ShowLT.Name = "dtg_ShowLT";
            this.dtg_ShowLT.RowHeadersWidth = 51;
            this.dtg_ShowLT.RowTemplate.Height = 29;
            this.dtg_ShowLT.Size = new System.Drawing.Size(688, 114);
            this.dtg_ShowLT.TabIndex = 0;
            this.dtg_ShowLT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowLT_CellClick);
            // 
            // grb_TTNCC
            // 
            this.grb_TTNCC.Controls.Add(this.bt_ThemAanh);
            this.grb_TTNCC.Controls.Add(this.ptb_Anh);
            this.grb_TTNCC.Controls.Add(this.txt_TrangThai);
            this.grb_TTNCC.Controls.Add(this.txt_CanNang);
            this.grb_TTNCC.Controls.Add(this.txt_MoTa);
            this.grb_TTNCC.Controls.Add(this.txt_TenLapTop);
            this.grb_TTNCC.Controls.Add(this.txt_MaNV);
            this.grb_TTNCC.Controls.Add(this.label7);
            this.grb_TTNCC.Controls.Add(this.label6);
            this.grb_TTNCC.Controls.Add(this.label5);
            this.grb_TTNCC.Controls.Add(this.txt_MaLapTop);
            this.grb_TTNCC.Controls.Add(this.label2);
            this.grb_TTNCC.Controls.Add(this.label4);
            this.grb_TTNCC.Controls.Add(this.label3);
            this.grb_TTNCC.Location = new System.Drawing.Point(16, 26);
            this.grb_TTNCC.Name = "grb_TTNCC";
            this.grb_TTNCC.Size = new System.Drawing.Size(717, 230);
            this.grb_TTNCC.TabIndex = 0;
            this.grb_TTNCC.TabStop = false;
            this.grb_TTNCC.Text = "Thông Tin LapTop";
            // 
            // bt_ThemAanh
            // 
            this.bt_ThemAanh.Location = new System.Drawing.Point(535, 192);
            this.bt_ThemAanh.Name = "bt_ThemAanh";
            this.bt_ThemAanh.Size = new System.Drawing.Size(94, 29);
            this.bt_ThemAanh.TabIndex = 15;
            this.bt_ThemAanh.Text = "Thêm Ảnh";
            this.bt_ThemAanh.UseVisualStyleBackColor = true;
            this.bt_ThemAanh.Click += new System.EventHandler(this.bt_ThemAanh_Click);
            // 
            // ptb_Anh
            // 
            this.ptb_Anh.Location = new System.Drawing.Point(505, 26);
            this.ptb_Anh.Name = "ptb_Anh";
            this.ptb_Anh.Size = new System.Drawing.Size(152, 153);
            this.ptb_Anh.TabIndex = 14;
            this.ptb_Anh.TabStop = false;
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Location = new System.Drawing.Point(144, 202);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(244, 27);
            this.txt_TrangThai.TabIndex = 13;
            // 
            // txt_CanNang
            // 
            this.txt_CanNang.Location = new System.Drawing.Point(144, 136);
            this.txt_CanNang.Name = "txt_CanNang";
            this.txt_CanNang.Size = new System.Drawing.Size(244, 27);
            this.txt_CanNang.TabIndex = 12;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(144, 169);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(244, 27);
            this.txt_MoTa.TabIndex = 11;
            // 
            // txt_TenLapTop
            // 
            this.txt_TenLapTop.Location = new System.Drawing.Point(144, 99);
            this.txt_TenLapTop.Name = "txt_TenLapTop";
            this.txt_TenLapTop.Size = new System.Drawing.Size(244, 27);
            this.txt_TenLapTop.TabIndex = 10;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(144, 61);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(244, 27);
            this.txt_MaNV.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng Thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mô Tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cân Nặng";
            // 
            // txt_MaLapTop
            // 
            this.txt_MaLapTop.Location = new System.Drawing.Point(144, 28);
            this.txt_MaLapTop.Name = "txt_MaLapTop";
            this.txt_MaLapTop.Size = new System.Drawing.Size(244, 27);
            this.txt_MaLapTop.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã LapTop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên LapTop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(201, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "LAPTOP";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DM_LapTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_NhaCC);
            this.Name = "DM_LapTop";
            this.Text = "DM_LapTop";
            this.grb_NhaCC.ResumeLayout(false);
            this.grb_TacVu.ResumeLayout(false);
            this.grb_DSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowLT)).EndInit();
            this.grb_TTNCC.ResumeLayout(false);
            this.grb_TTNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grb_NhaCC;
        private GroupBox grb_TacVu;
        private Button bt_Xoa;
        private Button bt_Sua;
        private Button bt_Them;
        private Button bt_Show;
        private GroupBox grb_DSNCC;
        private DataGridView dtg_ShowLT;
        private GroupBox grb_TTNCC;
        private TextBox txt_MaLapTop;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button bt_ThemAanh;
        private PictureBox ptb_Anh;
        private TextBox txt_TrangThai;
        private TextBox txt_CanNang;
        private TextBox txt_MoTa;
        private TextBox txt_TenLapTop;
        private TextBox txt_MaNV;
        private Label label7;
        private Label label6;
        private Label label5;
        private OpenFileDialog openFileDialog1;
    }
}