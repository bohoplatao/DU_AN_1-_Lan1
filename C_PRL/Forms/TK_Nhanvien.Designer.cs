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
            label1 = new Label();
            grb_NhaCC = new GroupBox();
            grb_TacVu = new GroupBox();
            tb_Tk = new TextBox();
            label8 = new Label();
            grb_DSNCC = new GroupBox();
            dtg_ShowNV = new DataGridView();
            grb_TTNCC = new GroupBox();
            txt_MK = new TextBox();
            label7 = new Label();
            ptb_QRCode = new PictureBox();
            dt_ngaysinh = new DateTimePicker();
            ptb_Anh = new PictureBox();
            txt_SDT = new TextBox();
            txt_DiaChi = new TextBox();
            txt_TenNV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_MaNV = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            grb_NhaCC.SuspendLayout();
            grb_TacVu.SuspendLayout();
            grb_DSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowNV).BeginInit();
            grb_TTNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_QRCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Anh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(262, 5);
            label1.Name = "label1";
            label1.Size = new Size(203, 50);
            label1.TabIndex = 16;
            label1.Text = "Nhân Viên";
            // 
            // grb_NhaCC
            // 
            grb_NhaCC.Controls.Add(grb_TacVu);
            grb_NhaCC.Controls.Add(grb_DSNCC);
            grb_NhaCC.Controls.Add(grb_TTNCC);
            grb_NhaCC.Location = new Point(28, 48);
            grb_NhaCC.Name = "grb_NhaCC";
            grb_NhaCC.Size = new Size(733, 608);
            grb_NhaCC.TabIndex = 15;
            grb_NhaCC.TabStop = false;
            // 
            // grb_TacVu
            // 
            grb_TacVu.Controls.Add(tb_Tk);
            grb_TacVu.Controls.Add(label8);
            grb_TacVu.Location = new Point(16, 489);
            grb_TacVu.Name = "grb_TacVu";
            grb_TacVu.Size = new Size(711, 113);
            grb_TacVu.TabIndex = 2;
            grb_TacVu.TabStop = false;
            grb_TacVu.Text = "Tác Vụ";
            // 
            // tb_Tk
            // 
            tb_Tk.Location = new Point(138, 46);
            tb_Tk.Name = "tb_Tk";
            tb_Tk.Size = new Size(215, 27);
            tb_Tk.TabIndex = 1;
            tb_Tk.TextChanged += tb_Tk_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 46);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 0;
            label8.Text = "Tìm Kiếm";
            // 
            // grb_DSNCC
            // 
            grb_DSNCC.Controls.Add(dtg_ShowNV);
            grb_DSNCC.Location = new Point(16, 307);
            grb_DSNCC.Name = "grb_DSNCC";
            grb_DSNCC.Size = new Size(717, 188);
            grb_DSNCC.TabIndex = 1;
            grb_DSNCC.TabStop = false;
            grb_DSNCC.Text = "Danh Sách NV";
            // 
            // dtg_ShowNV
            // 
            dtg_ShowNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ShowNV.Location = new Point(19, 26);
            dtg_ShowNV.Name = "dtg_ShowNV";
            dtg_ShowNV.RowHeadersWidth = 51;
            dtg_ShowNV.RowTemplate.Height = 29;
            dtg_ShowNV.Size = new Size(688, 150);
            dtg_ShowNV.TabIndex = 0;
            dtg_ShowNV.CellClick += dtg_ShowNV_CellClick;
            dtg_ShowNV.CellFormatting += dtg_ShowNV_CellFormatting;
            // 
            // grb_TTNCC
            // 
            grb_TTNCC.Controls.Add(txt_MK);
            grb_TTNCC.Controls.Add(label7);
            grb_TTNCC.Controls.Add(ptb_QRCode);
            grb_TTNCC.Controls.Add(dt_ngaysinh);
            grb_TTNCC.Controls.Add(ptb_Anh);
            grb_TTNCC.Controls.Add(txt_SDT);
            grb_TTNCC.Controls.Add(txt_DiaChi);
            grb_TTNCC.Controls.Add(txt_TenNV);
            grb_TTNCC.Controls.Add(label6);
            grb_TTNCC.Controls.Add(label5);
            grb_TTNCC.Controls.Add(txt_MaNV);
            grb_TTNCC.Controls.Add(label2);
            grb_TTNCC.Controls.Add(label4);
            grb_TTNCC.Controls.Add(label3);
            grb_TTNCC.Location = new Point(16, 26);
            grb_TTNCC.Name = "grb_TTNCC";
            grb_TTNCC.Size = new Size(717, 275);
            grb_TTNCC.TabIndex = 0;
            grb_TTNCC.TabStop = false;
            grb_TTNCC.Text = "Thông Tin Nhân Viên";
            // 
            // txt_MK
            // 
            txt_MK.Location = new Point(105, 205);
            txt_MK.Name = "txt_MK";
            txt_MK.PasswordChar = '*';
            txt_MK.Size = new Size(135, 27);
            txt_MK.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 205);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 19;
            label7.Text = "MK";
            // 
            // ptb_QRCode
            // 
            ptb_QRCode.Location = new Point(555, 43);
            ptb_QRCode.Name = "ptb_QRCode";
            ptb_QRCode.Size = new Size(152, 153);
            ptb_QRCode.TabIndex = 17;
            ptb_QRCode.TabStop = false;
            // 
            // dt_ngaysinh
            // 
            dt_ngaysinh.Location = new Point(105, 169);
            dt_ngaysinh.Name = "dt_ngaysinh";
            dt_ngaysinh.Size = new Size(173, 27);
            dt_ngaysinh.TabIndex = 16;
            // 
            // ptb_Anh
            // 
            ptb_Anh.Location = new Point(354, 43);
            ptb_Anh.Name = "ptb_Anh";
            ptb_Anh.Size = new Size(152, 153);
            ptb_Anh.TabIndex = 14;
            ptb_Anh.TabStop = false;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(105, 136);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(135, 27);
            txt_SDT.TabIndex = 12;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(105, 99);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(135, 27);
            txt_DiaChi.TabIndex = 10;
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(105, 61);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(135, 27);
            txt_TenNV.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 168);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 7;
            label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 134);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 6;
            label5.Text = "Số ĐT";
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(105, 28);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(135, 27);
            txt_MaNV.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "MaNV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 102);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 1;
            label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 63);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "TenNV";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // TK_Nhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 660);
            Controls.Add(label1);
            Controls.Add(grb_NhaCC);
            Name = "TK_Nhanvien";
            Text = "TK_Nhanvien";
            grb_NhaCC.ResumeLayout(false);
            grb_TacVu.ResumeLayout(false);
            grb_TacVu.PerformLayout();
            grb_DSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_ShowNV).EndInit();
            grb_TTNCC.ResumeLayout(false);
            grb_TTNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_QRCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Anh).EndInit();
            ResumeLayout(false);
            PerformLayout();
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