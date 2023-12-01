namespace C_PRL.Forms
{
    partial class DM_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DM_NhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.grb_NhaCC = new System.Windows.Forms.GroupBox();
            this.grb_TacVu = new System.Windows.Forms.GroupBox();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Show = new System.Windows.Forms.Button();
            this.grb_DSNCC = new System.Windows.Forms.GroupBox();
            this.dtg_ShowNV = new System.Windows.Forms.DataGridView();
            this.grb_TTNCC = new System.Windows.Forms.GroupBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_ThemQR = new System.Windows.Forms.Button();
            this.ptb_QRCode = new System.Windows.Forms.PictureBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.bt_ThemAanh = new System.Windows.Forms.Button();
            this.ptb_Anh = new System.Windows.Forms.PictureBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grb_NhaCC.SuspendLayout();
            this.grb_TacVu.SuspendLayout();
            this.grb_DSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowNV)).BeginInit();
            this.grb_TTNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(229, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhân Viên";
            // 
            // grb_NhaCC
            // 
            this.grb_NhaCC.Controls.Add(this.grb_TacVu);
            this.grb_NhaCC.Controls.Add(this.grb_DSNCC);
            this.grb_NhaCC.Controls.Add(this.grb_TTNCC);
            this.grb_NhaCC.Location = new System.Drawing.Point(24, 29);
            this.grb_NhaCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_NhaCC.Name = "grb_NhaCC";
            this.grb_NhaCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_NhaCC.Size = new System.Drawing.Size(869, 590);
            this.grb_NhaCC.TabIndex = 13;
            this.grb_NhaCC.TabStop = false;
            // 
            // grb_TacVu
            // 
            this.grb_TacVu.Controls.Add(this.bt_Xoa);
            this.grb_TacVu.Controls.Add(this.bt_Sua);
            this.grb_TacVu.Controls.Add(this.bt_Them);
            this.grb_TacVu.Controls.Add(this.bt_Show);
            this.grb_TacVu.Location = new System.Drawing.Point(6, 501);
            this.grb_TacVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TacVu.Name = "grb_TacVu";
            this.grb_TacVu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TacVu.Size = new System.Drawing.Size(857, 85);
            this.grb_TacVu.TabIndex = 2;
            this.grb_TacVu.TabStop = false;
            this.grb_TacVu.Text = "Tác Vụ";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.Image")));
            this.bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Xoa.Location = new System.Drawing.Point(701, 20);
            this.bt_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(126, 51);
            this.bt_Xoa.TabIndex = 3;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.Image")));
            this.bt_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sua.Location = new System.Drawing.Point(478, 20);
            this.bt_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(126, 51);
            this.bt_Sua.TabIndex = 2;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Image = ((System.Drawing.Image)(resources.GetObject("bt_Them.Image")));
            this.bt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Them.Location = new System.Drawing.Point(260, 20);
            this.bt_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(126, 51);
            this.bt_Them.TabIndex = 1;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Show
            // 
            this.bt_Show.Image = ((System.Drawing.Image)(resources.GetObject("bt_Show.Image")));
            this.bt_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Show.Location = new System.Drawing.Point(40, 20);
            this.bt_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Show.Name = "bt_Show";
            this.bt_Show.Size = new System.Drawing.Size(126, 51);
            this.bt_Show.TabIndex = 0;
            this.bt_Show.Text = "Show";
            this.bt_Show.UseVisualStyleBackColor = true;
            this.bt_Show.Click += new System.EventHandler(this.bt_Show_Click);
            // 
            // grb_DSNCC
            // 
            this.grb_DSNCC.Controls.Add(this.dtg_ShowNV);
            this.grb_DSNCC.Location = new System.Drawing.Point(6, 230);
            this.grb_DSNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_DSNCC.Name = "grb_DSNCC";
            this.grb_DSNCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_DSNCC.Size = new System.Drawing.Size(857, 267);
            this.grb_DSNCC.TabIndex = 1;
            this.grb_DSNCC.TabStop = false;
            this.grb_DSNCC.Text = "Danh Sách NV";
            // 
            // dtg_ShowNV
            // 
            this.dtg_ShowNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowNV.Location = new System.Drawing.Point(17, 20);
            this.dtg_ShowNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_ShowNV.Name = "dtg_ShowNV";
            this.dtg_ShowNV.RowHeadersWidth = 51;
            this.dtg_ShowNV.RowTemplate.Height = 29;
            this.dtg_ShowNV.Size = new System.Drawing.Size(834, 243);
            this.dtg_ShowNV.TabIndex = 0;
            this.dtg_ShowNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowNV_CellClick);
            this.dtg_ShowNV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtg_ShowNV_CellFormatting);
            // 
            // grb_TTNCC
            // 
            this.grb_TTNCC.Controls.Add(this.txt_MK);
            this.grb_TTNCC.Controls.Add(this.label7);
            this.grb_TTNCC.Controls.Add(this.bt_ThemQR);
            this.grb_TTNCC.Controls.Add(this.ptb_QRCode);
            this.grb_TTNCC.Controls.Add(this.dt_ngaysinh);
            this.grb_TTNCC.Controls.Add(this.bt_ThemAanh);
            this.grb_TTNCC.Controls.Add(this.ptb_Anh);
            this.grb_TTNCC.Controls.Add(this.txt_SDT);
            this.grb_TTNCC.Controls.Add(this.txt_DiaChi);
            this.grb_TTNCC.Controls.Add(this.txt_TenNV);
            this.grb_TTNCC.Controls.Add(this.label6);
            this.grb_TTNCC.Controls.Add(this.label5);
            this.grb_TTNCC.Controls.Add(this.txt_MaNV);
            this.grb_TTNCC.Controls.Add(this.label2);
            this.grb_TTNCC.Controls.Add(this.label4);
            this.grb_TTNCC.Controls.Add(this.label3);
            this.grb_TTNCC.Location = new System.Drawing.Point(14, 20);
            this.grb_TTNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TTNCC.Name = "grb_TTNCC";
            this.grb_TTNCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TTNCC.Size = new System.Drawing.Size(843, 206);
            this.grb_TTNCC.TabIndex = 0;
            this.grb_TTNCC.TabStop = false;
            this.grb_TTNCC.Text = "Thông Tin Nhân Viên";
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(92, 154);
            this.txt_MK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(321, 23);
            this.txt_MK.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "MK";
            // 
            // bt_ThemQR
            // 
            this.bt_ThemQR.Location = new System.Drawing.Point(719, 151);
            this.bt_ThemQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ThemQR.Name = "bt_ThemQR";
            this.bt_ThemQR.Size = new System.Drawing.Size(82, 22);
            this.bt_ThemQR.TabIndex = 18;
            this.bt_ThemQR.Text = "Thêm Ảnh";
            this.bt_ThemQR.UseVisualStyleBackColor = true;
            this.bt_ThemQR.Click += new System.EventHandler(this.bt_ThemQR_Click);
            // 
            // ptb_QRCode
            // 
            this.ptb_QRCode.Location = new System.Drawing.Point(693, 26);
            this.ptb_QRCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_QRCode.Name = "ptb_QRCode";
            this.ptb_QRCode.Size = new System.Drawing.Size(133, 115);
            this.ptb_QRCode.TabIndex = 17;
            this.ptb_QRCode.TabStop = false;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Location = new System.Drawing.Point(92, 127);
            this.dt_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(321, 23);
            this.dt_ngaysinh.TabIndex = 16;
            // 
            // bt_ThemAanh
            // 
            this.bt_ThemAanh.Location = new System.Drawing.Point(543, 151);
            this.bt_ThemAanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ThemAanh.Name = "bt_ThemAanh";
            this.bt_ThemAanh.Size = new System.Drawing.Size(82, 22);
            this.bt_ThemAanh.TabIndex = 15;
            this.bt_ThemAanh.Text = "Thêm Ảnh";
            this.bt_ThemAanh.UseVisualStyleBackColor = true;
            this.bt_ThemAanh.Click += new System.EventHandler(this.bt_ThemAanh_Click);
            // 
            // ptb_Anh
            // 
            this.ptb_Anh.Location = new System.Drawing.Point(517, 26);
            this.ptb_Anh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_Anh.Name = "ptb_Anh";
            this.ptb_Anh.Size = new System.Drawing.Size(133, 115);
            this.ptb_Anh.TabIndex = 14;
            this.ptb_Anh.TabStop = false;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(92, 102);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(321, 23);
            this.txt_SDT.TabIndex = 12;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(92, 74);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(321, 23);
            this.txt_DiaChi.TabIndex = 10;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(92, 46);
            this.txt_TenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(321, 23);
            this.txt_TenNV.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số ĐT";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(92, 21);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(321, 23);
            this.txt_MaNV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "MaNV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "TenNV";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DM_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_NhaCC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DM_NhanVien";
            this.Text = "DM_NhanVien";
            this.grb_NhaCC.ResumeLayout(false);
            this.grb_TacVu.ResumeLayout(false);
            this.grb_DSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowNV)).EndInit();
            this.grb_TTNCC.ResumeLayout(false);
            this.grb_TTNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox grb_NhaCC;
        private GroupBox grb_TacVu;
        private Button bt_Xoa;
        private Button bt_Sua;
        private Button bt_Them;
        private Button bt_Show;
        private GroupBox grb_DSNCC;
        private DataGridView dtg_ShowNV;
        private GroupBox grb_TTNCC;
        private DateTimePicker dt_ngaysinh;
        private Button bt_ThemAanh;
        private PictureBox ptb_Anh;
        private TextBox txt_SDT;
        private TextBox txt_DiaChi;
        private TextBox txt_TenNV;
        private Label label6;
        private Label label5;
        private TextBox txt_MaNV;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button bt_ThemQR;
        private PictureBox ptb_QRCode;
        private Label label7;
        private TextBox txt_MK;
        private OpenFileDialog openFileDialog1;
    }
}