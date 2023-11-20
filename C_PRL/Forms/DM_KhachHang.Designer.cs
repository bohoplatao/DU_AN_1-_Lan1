namespace C_PRL.Forms
{
    partial class DM_KhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.grb_NhaCC = new System.Windows.Forms.GroupBox();
            this.grb_TacVu = new System.Windows.Forms.GroupBox();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Show = new System.Windows.Forms.Button();
            this.grb_DSNCC = new System.Windows.Forms.GroupBox();
            this.dtg_ShowKH = new System.Windows.Forms.DataGridView();
            this.grb_TTNCC = new System.Windows.Forms.GroupBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.bt_ThemAanh = new System.Windows.Forms.Button();
            this.ptb_Anh = new System.Windows.Forms.PictureBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grb_NhaCC.SuspendLayout();
            this.grb_TacVu.SuspendLayout();
            this.grb_DSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowKH)).BeginInit();
            this.grb_TTNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(217, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Khách Hàng";
            // 
            // grb_NhaCC
            // 
            this.grb_NhaCC.Controls.Add(this.grb_TacVu);
            this.grb_NhaCC.Controls.Add(this.grb_DSNCC);
            this.grb_NhaCC.Controls.Add(this.grb_TTNCC);
            this.grb_NhaCC.Location = new System.Drawing.Point(28, 58);
            this.grb_NhaCC.Name = "grb_NhaCC";
            this.grb_NhaCC.Size = new System.Drawing.Size(733, 589);
            this.grb_NhaCC.TabIndex = 11;
            this.grb_NhaCC.TabStop = false;
            // 
            // grb_TacVu
            // 
            this.grb_TacVu.Controls.Add(this.bt_Xoa);
            this.grb_TacVu.Controls.Add(this.bt_Sua);
            this.grb_TacVu.Controls.Add(this.bt_Them);
            this.grb_TacVu.Controls.Add(this.bt_Show);
            this.grb_TacVu.Location = new System.Drawing.Point(16, 476);
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
            this.grb_DSNCC.Controls.Add(this.dtg_ShowKH);
            this.grb_DSNCC.Location = new System.Drawing.Point(16, 281);
            this.grb_DSNCC.Name = "grb_DSNCC";
            this.grb_DSNCC.Size = new System.Drawing.Size(717, 198);
            this.grb_DSNCC.TabIndex = 1;
            this.grb_DSNCC.TabStop = false;
            this.grb_DSNCC.Text = "Danh Sách KH";
            // 
            // dtg_ShowKH
            // 
            this.dtg_ShowKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowKH.Location = new System.Drawing.Point(19, 26);
            this.dtg_ShowKH.Name = "dtg_ShowKH";
            this.dtg_ShowKH.RowHeadersWidth = 51;
            this.dtg_ShowKH.RowTemplate.Height = 29;
            this.dtg_ShowKH.Size = new System.Drawing.Size(688, 169);
            this.dtg_ShowKH.TabIndex = 0;
            this.dtg_ShowKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowKH_CellClick);
            // 
            // grb_TTNCC
            // 
            this.grb_TTNCC.Controls.Add(this.dt_ngaysinh);
            this.grb_TTNCC.Controls.Add(this.bt_ThemAanh);
            this.grb_TTNCC.Controls.Add(this.ptb_Anh);
            this.grb_TTNCC.Controls.Add(this.txt_SDT);
            this.grb_TTNCC.Controls.Add(this.txt_DiaChi);
            this.grb_TTNCC.Controls.Add(this.txt_TenKH);
            this.grb_TTNCC.Controls.Add(this.label6);
            this.grb_TTNCC.Controls.Add(this.label5);
            this.grb_TTNCC.Controls.Add(this.txt_MaKH);
            this.grb_TTNCC.Controls.Add(this.label2);
            this.grb_TTNCC.Controls.Add(this.label4);
            this.grb_TTNCC.Controls.Add(this.label3);
            this.grb_TTNCC.Location = new System.Drawing.Point(16, 26);
            this.grb_TTNCC.Name = "grb_TTNCC";
            this.grb_TTNCC.Size = new System.Drawing.Size(717, 230);
            this.grb_TTNCC.TabIndex = 0;
            this.grb_TTNCC.TabStop = false;
            this.grb_TTNCC.Text = "Thông Tin Khách Hàng";
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Location = new System.Drawing.Point(144, 169);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(250, 27);
            this.dt_ngaysinh.TabIndex = 16;
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
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(144, 136);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(244, 27);
            this.txt_SDT.TabIndex = 12;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(144, 99);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(244, 27);
            this.txt_DiaChi.TabIndex = 10;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(144, 61);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(244, 27);
            this.txt_TenKH.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số ĐT";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(144, 28);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(244, 27);
            this.txt_MaKH.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DM_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_NhaCC);
            this.Name = "DM_KhachHang";
            this.Text = "DM_KhachHang";
            this.grb_NhaCC.ResumeLayout(false);
            this.grb_TacVu.ResumeLayout(false);
            this.grb_DSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowKH)).EndInit();
            this.grb_TTNCC.ResumeLayout(false);
            this.grb_TTNCC.PerformLayout();
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
        private DataGridView dtg_ShowKH;
        private GroupBox grb_TTNCC;
        private Button bt_ThemAanh;
        private PictureBox ptb_Anh;
        private TextBox txt_SDT;
        private TextBox txt_DiaChi;
        private TextBox txt_TenKH;
        private Label label6;
        private Label label5;
        private TextBox txt_MaKH;
        private Label label2;
        private Label label4;
        private Label label3;
        private DateTimePicker dt_ngaysinh;
        private OpenFileDialog openFileDialog1;
    }
}