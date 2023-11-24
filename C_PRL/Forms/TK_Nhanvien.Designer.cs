namespace C_PRL.Forms
{
    partial class TK_Nhanvien
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
            this.tb_Tk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grb_DSNCC = new System.Windows.Forms.GroupBox();
            this.dtg_ShowNV = new System.Windows.Forms.DataGridView();
            this.grb_TTNCC = new System.Windows.Forms.GroupBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ptb_QRCode = new System.Windows.Forms.PictureBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
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
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            this.label1.Location = new System.Drawing.Point(262, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhân Viên";
            // 
            // grb_NhaCC
            // 
            this.grb_NhaCC.Controls.Add(this.grb_TacVu);
            this.grb_NhaCC.Controls.Add(this.grb_DSNCC);
            this.grb_NhaCC.Controls.Add(this.grb_TTNCC);
            this.grb_NhaCC.Location = new System.Drawing.Point(28, 48);
            this.grb_NhaCC.Name = "grb_NhaCC";
            this.grb_NhaCC.Size = new System.Drawing.Size(733, 608);
            this.grb_NhaCC.TabIndex = 15;
            this.grb_NhaCC.TabStop = false;
            // 
            // grb_TacVu
            // 
            this.grb_TacVu.Controls.Add(this.tb_Tk);
            this.grb_TacVu.Controls.Add(this.label8);
            this.grb_TacVu.Location = new System.Drawing.Point(16, 489);
            this.grb_TacVu.Name = "grb_TacVu";
            this.grb_TacVu.Size = new System.Drawing.Size(711, 113);
            this.grb_TacVu.TabIndex = 2;
            this.grb_TacVu.TabStop = false;
            this.grb_TacVu.Text = "Tác Vụ";
            // 
            // tb_Tk
            // 
            this.tb_Tk.Location = new System.Drawing.Point(138, 46);
            this.tb_Tk.Name = "tb_Tk";
            this.tb_Tk.Size = new System.Drawing.Size(215, 27);
            this.tb_Tk.TabIndex = 1;
            this.tb_Tk.TextChanged += new System.EventHandler(this.tb_Tk_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm Kiếm";
            // 
            // grb_DSNCC
            // 
            this.grb_DSNCC.Controls.Add(this.dtg_ShowNV);
            this.grb_DSNCC.Location = new System.Drawing.Point(16, 307);
            this.grb_DSNCC.Name = "grb_DSNCC";
            this.grb_DSNCC.Size = new System.Drawing.Size(717, 188);
            this.grb_DSNCC.TabIndex = 1;
            this.grb_DSNCC.TabStop = false;
            this.grb_DSNCC.Text = "Danh Sách NV";
            // 
            // dtg_ShowNV
            // 
            this.dtg_ShowNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowNV.Location = new System.Drawing.Point(19, 26);
            this.dtg_ShowNV.Name = "dtg_ShowNV";
            this.dtg_ShowNV.RowHeadersWidth = 51;
            this.dtg_ShowNV.RowTemplate.Height = 29;
            this.dtg_ShowNV.Size = new System.Drawing.Size(688, 150);
            this.dtg_ShowNV.TabIndex = 0;
            this.dtg_ShowNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowNV_CellClick);
            this.dtg_ShowNV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtg_ShowNV_CellFormatting);
            // 
            // grb_TTNCC
            // 
            this.grb_TTNCC.Controls.Add(this.txt_MK);
            this.grb_TTNCC.Controls.Add(this.label7);
            this.grb_TTNCC.Controls.Add(this.ptb_QRCode);
            this.grb_TTNCC.Controls.Add(this.dt_ngaysinh);
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
            this.grb_TTNCC.Location = new System.Drawing.Point(16, 26);
            this.grb_TTNCC.Name = "grb_TTNCC";
            this.grb_TTNCC.Size = new System.Drawing.Size(717, 275);
            this.grb_TTNCC.TabIndex = 0;
            this.grb_TTNCC.TabStop = false;
            this.grb_TTNCC.Text = "Thông Tin Nhân Viên";
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(105, 205);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(93, 27);
            this.txt_MK.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "MK";
            // 
            // ptb_QRCode
            // 
            this.ptb_QRCode.Location = new System.Drawing.Point(555, 43);
            this.ptb_QRCode.Name = "ptb_QRCode";
            this.ptb_QRCode.Size = new System.Drawing.Size(152, 153);
            this.ptb_QRCode.TabIndex = 17;
            this.ptb_QRCode.TabStop = false;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Location = new System.Drawing.Point(105, 169);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(173, 27);
            this.dt_ngaysinh.TabIndex = 16;
            // 
            // ptb_Anh
            // 
            this.ptb_Anh.Location = new System.Drawing.Point(354, 43);
            this.ptb_Anh.Name = "ptb_Anh";
            this.ptb_Anh.Size = new System.Drawing.Size(152, 153);
            this.ptb_Anh.TabIndex = 14;
            this.ptb_Anh.TabStop = false;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(105, 136);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(93, 27);
            this.txt_SDT.TabIndex = 12;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(105, 99);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(93, 27);
            this.txt_DiaChi.TabIndex = 10;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(105, 61);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(93, 27);
            this.txt_TenNV.TabIndex = 9;
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
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(105, 28);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(93, 27);
            this.txt_MaNV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MaNV";
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
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "TenNV";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // TK_Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_NhaCC);
            this.Name = "TK_Nhanvien";
            this.Text = "TK_Nhanvien";
            this.grb_NhaCC.ResumeLayout(false);
            this.grb_TacVu.ResumeLayout(false);
            this.grb_TacVu.PerformLayout();
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
        private TextBox tb_Tk;
        private Label label8;
        private GroupBox grb_DSNCC;
        private DataGridView dtg_ShowNV;
        private GroupBox grb_TTNCC;
        private TextBox txt_MK;
        private Label label7;
        private PictureBox ptb_QRCode;
        private DateTimePicker dt_ngaysinh;
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
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}