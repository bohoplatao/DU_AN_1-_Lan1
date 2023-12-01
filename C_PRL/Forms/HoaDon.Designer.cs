namespace C_PRL.Forms
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtg_DaTHanhToan = new System.Windows.Forms.DataGridView();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.txt_TennguoiNhan = new System.Windows.Forms.TextBox();
            this.txt_DChi = new System.Windows.Forms.TextBox();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Trangthai = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_MaSerial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_ChuThich = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_ChuaThanhToan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DaTHanhToan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChuaThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtg_DaTHanhToan
            // 
            this.dtg_DaTHanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DaTHanhToan.Location = new System.Drawing.Point(10, 422);
            this.dtg_DaTHanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_DaTHanhToan.Name = "dtg_DaTHanhToan";
            this.dtg_DaTHanhToan.RowHeadersWidth = 51;
            this.dtg_DaTHanhToan.RowTemplate.Height = 29;
            this.dtg_DaTHanhToan.Size = new System.Drawing.Size(895, 126);
            this.dtg_DaTHanhToan.TabIndex = 9;
            this.dtg_DaTHanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DaTHanhToan_CellClick_1);
            // 
            // bt_Them
            // 
            this.bt_Them.Image = ((System.Drawing.Image)(resources.GetObject("bt_Them.Image")));
            this.bt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Them.Location = new System.Drawing.Point(73, 572);
            this.bt_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(126, 51);
            this.bt_Them.TabIndex = 11;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.Image = ((System.Drawing.Image)(resources.GetObject("bt_Luu.Image")));
            this.bt_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Luu.Location = new System.Drawing.Point(273, 572);
            this.bt_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(126, 51);
            this.bt_Luu.TabIndex = 12;
            this.bt_Luu.Text = "Lưu ";
            this.bt_Luu.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.Image")));
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(490, 572);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(126, 51);
            this.bt_sua.TabIndex = 13;
            this.bt_sua.Text = "Hủy";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(701, 572);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(126, 51);
            this.bt_xoa.TabIndex = 14;
            this.bt_xoa.Text = "Hủy";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên Người Nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Địa Chỉ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số Điện Thoại";
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.Location = new System.Drawing.Point(226, 60);
            this.txt_MaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(179, 23);
            this.txt_MaHoaDon.TabIndex = 14;
            // 
            // txt_TennguoiNhan
            // 
            this.txt_TennguoiNhan.Location = new System.Drawing.Point(562, 96);
            this.txt_TennguoiNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TennguoiNhan.Name = "txt_TennguoiNhan";
            this.txt_TennguoiNhan.Size = new System.Drawing.Size(179, 23);
            this.txt_TennguoiNhan.TabIndex = 18;
            // 
            // txt_DChi
            // 
            this.txt_DChi.Location = new System.Drawing.Point(226, 89);
            this.txt_DChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DChi.Name = "txt_DChi";
            this.txt_DChi.Size = new System.Drawing.Size(179, 23);
            this.txt_DChi.TabIndex = 19;
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(226, 120);
            this.txt_Sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(179, 23);
            this.txt_Sdt.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Trangthai);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.txt_MaSerial);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_MaKH);
            this.groupBox1.Controls.Add(this.txt_ChuThich);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Sdt);
            this.groupBox1.Controls.Add(this.txt_DChi);
            this.groupBox1.Controls.Add(this.txt_TennguoiNhan);
            this.groupBox1.Controls.Add(this.txt_MaHoaDon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(902, 270);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Trang Thai";
            // 
            // txt_Trangthai
            // 
            this.txt_Trangthai.Location = new System.Drawing.Point(226, 175);
            this.txt_Trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Trangthai.Name = "txt_Trangthai";
            this.txt_Trangthai.Size = new System.Drawing.Size(179, 23);
            this.txt_Trangthai.TabIndex = 36;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(562, 197);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(179, 23);
            this.txt_gia.TabIndex = 35;
            // 
            // txt_MaSerial
            // 
            this.txt_MaSerial.Location = new System.Drawing.Point(562, 165);
            this.txt_MaSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaSerial.Name = "txt_MaSerial";
            this.txt_MaSerial.Size = new System.Drawing.Size(179, 23);
            this.txt_MaSerial.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mã Serial";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(563, 62);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(178, 23);
            this.txt_MaKH.TabIndex = 31;
            // 
            // txt_ChuThich
            // 
            this.txt_ChuThich.Location = new System.Drawing.Point(226, 148);
            this.txt_ChuThich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ChuThich.Name = "txt_ChuThich";
            this.txt_ChuThich.Size = new System.Drawing.Size(179, 23);
            this.txt_ChuThich.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(106, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chú Thích";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 125);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 23);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ngày Mua";
            // 
            // dtg_ChuaThanhToan
            // 
            this.dtg_ChuaThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ChuaThanhToan.Location = new System.Drawing.Point(10, 9);
            this.dtg_ChuaThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_ChuaThanhToan.Name = "dtg_ChuaThanhToan";
            this.dtg_ChuaThanhToan.RowHeadersWidth = 51;
            this.dtg_ChuaThanhToan.RowTemplate.Height = 29;
            this.dtg_ChuaThanhToan.Size = new System.Drawing.Size(895, 126);
            this.dtg_ChuaThanhToan.TabIndex = 16;
            this.dtg_ChuaThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ChuaThanhToan_CellClick);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 643);
            this.Controls.Add(this.dtg_ChuaThanhToan);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.dtg_DaTHanhToan);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DaTHanhToan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChuaThanhToan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private DataGridView dtg_DaTHanhToan;
        private Button bt_Them;
        private Button bt_Luu;
        private Button bt_sua;
        private Button bt_xoa;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_MaHoaDon;
        private TextBox txt_TennguoiNhan;
        private TextBox txt_DChi;
        private TextBox txt_Sdt;
        private GroupBox groupBox1;
        private DataGridView dtg_ChuaThanhToan;
        private TextBox txt_ChuThich;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox txt_MaKH;
        private TextBox txt_gia;
        private TextBox txt_MaSerial;
        private Label label9;
        private Label label8;
        private Label label10;
        private TextBox txt_Trangthai;
    }
}