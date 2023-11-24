namespace C_PRL.Forms
{
    partial class TK_LapTop
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
            this.tb_Timkiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grb_DSNCC = new System.Windows.Forms.GroupBox();
            this.dtg_ShowLT = new System.Windows.Forms.DataGridView();
            this.grb_TTNCC = new System.Windows.Forms.GroupBox();
            this.txt_Soluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptb_Anh = new System.Windows.Forms.PictureBox();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.txt_CanNang = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_TenLapTop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaLapTop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grb_NhaCC.SuspendLayout();
            this.grb_TacVu.SuspendLayout();
            this.grb_DSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowLT)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "LAPTOP";
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
            this.grb_TacVu.Controls.Add(this.tb_Timkiem);
            this.grb_TacVu.Controls.Add(this.label9);
            this.grb_TacVu.Location = new System.Drawing.Point(16, 433);
            this.grb_TacVu.Name = "grb_TacVu";
            this.grb_TacVu.Size = new System.Drawing.Size(711, 113);
            this.grb_TacVu.TabIndex = 2;
            this.grb_TacVu.TabStop = false;
            this.grb_TacVu.Text = "Tác Vụ";
            // 
            // tb_Timkiem
            // 
            this.tb_Timkiem.Location = new System.Drawing.Point(144, 39);
            this.tb_Timkiem.Name = "tb_Timkiem";
            this.tb_Timkiem.Size = new System.Drawing.Size(173, 27);
            this.tb_Timkiem.TabIndex = 2;
            this.tb_Timkiem.TextChanged += new System.EventHandler(this.tb_Timkiem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tìm Kiếm";
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
            this.dtg_ShowLT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowLT_CellClick_1);
            // 
            // grb_TTNCC
            // 
            this.grb_TTNCC.Controls.Add(this.txt_Soluong);
            this.grb_TTNCC.Controls.Add(this.label3);
            this.grb_TTNCC.Controls.Add(this.ptb_Anh);
            this.grb_TTNCC.Controls.Add(this.txt_TrangThai);
            this.grb_TTNCC.Controls.Add(this.txt_CanNang);
            this.grb_TTNCC.Controls.Add(this.txt_MoTa);
            this.grb_TTNCC.Controls.Add(this.txt_TenLapTop);
            this.grb_TTNCC.Controls.Add(this.label7);
            this.grb_TTNCC.Controls.Add(this.label6);
            this.grb_TTNCC.Controls.Add(this.label5);
            this.grb_TTNCC.Controls.Add(this.txt_MaLapTop);
            this.grb_TTNCC.Controls.Add(this.label2);
            this.grb_TTNCC.Controls.Add(this.label4);
            this.grb_TTNCC.Location = new System.Drawing.Point(16, 26);
            this.grb_TTNCC.Name = "grb_TTNCC";
            this.grb_TTNCC.Size = new System.Drawing.Size(717, 249);
            this.grb_TTNCC.TabIndex = 0;
            this.grb_TTNCC.TabStop = false;
            this.grb_TTNCC.Text = "Thông Tin LapTop";
            // 
            // txt_Soluong
            // 
            this.txt_Soluong.Location = new System.Drawing.Point(144, 212);
            this.txt_Soluong.Name = "txt_Soluong";
            this.txt_Soluong.Size = new System.Drawing.Size(244, 27);
            this.txt_Soluong.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số Lượng";
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
            this.txt_TrangThai.Location = new System.Drawing.Point(144, 174);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(244, 27);
            this.txt_TrangThai.TabIndex = 13;
            // 
            // txt_CanNang
            // 
            this.txt_CanNang.Location = new System.Drawing.Point(144, 105);
            this.txt_CanNang.Name = "txt_CanNang";
            this.txt_CanNang.Size = new System.Drawing.Size(244, 27);
            this.txt_CanNang.TabIndex = 12;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(144, 141);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(244, 27);
            this.txt_MoTa.TabIndex = 11;
            // 
            // txt_TenLapTop
            // 
            this.txt_TenLapTop.Location = new System.Drawing.Point(144, 67);
            this.txt_TenLapTop.Name = "txt_TenLapTop";
            this.txt_TenLapTop.Size = new System.Drawing.Size(244, 27);
            this.txt_TenLapTop.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng Thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mô Tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 105);
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
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên LapTop";
            // 
            // TK_LapTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_NhaCC);
            this.Name = "TK_LapTop";
            this.Text = "TK_LapTop";
            this.grb_NhaCC.ResumeLayout(false);
            this.grb_TacVu.ResumeLayout(false);
            this.grb_TacVu.PerformLayout();
            this.grb_DSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowLT)).EndInit();
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
        private GroupBox grb_DSNCC;
        private DataGridView dtg_ShowLT;
        private GroupBox grb_TTNCC;
        private TextBox txt_Soluong;
        private Label label3;
        private PictureBox ptb_Anh;
        private TextBox txt_TrangThai;
        private TextBox txt_CanNang;
        private TextBox txt_MoTa;
        private TextBox txt_TenLapTop;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_MaLapTop;
        private Label label2;
        private Label label4;
        private TextBox txt_TimKiem;
        private Label label8;
        private Button bt_TimKiem;
        private Label label9;
        private TextBox tb_Timkiem;
    }
}