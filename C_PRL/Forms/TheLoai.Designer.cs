﻿namespace C_PRL.Forms
{
    partial class TheLoai
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
            this.grb_TacVu = new System.Windows.Forms.GroupBox();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Show = new System.Windows.Forms.Button();
            this.grb_DSNCC = new System.Windows.Forms.GroupBox();
            this.dtg_ShowTL = new System.Windows.Forms.DataGridView();
            this.grb_TTNCC = new System.Windows.Forms.GroupBox();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.txt_TenLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_TacVu.SuspendLayout();
            this.grb_DSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowTL)).BeginInit();
            this.grb_TTNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_TacVu
            // 
            this.grb_TacVu.Controls.Add(this.bt_Xoa);
            this.grb_TacVu.Controls.Add(this.bt_Sua);
            this.grb_TacVu.Controls.Add(this.bt_Them);
            this.grb_TacVu.Controls.Add(this.bt_Show);
            this.grb_TacVu.Location = new System.Drawing.Point(2, 373);
            this.grb_TacVu.Name = "grb_TacVu";
            this.grb_TacVu.Size = new System.Drawing.Size(753, 113);
            this.grb_TacVu.TabIndex = 5;
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
            this.grb_DSNCC.Controls.Add(this.dtg_ShowTL);
            this.grb_DSNCC.Location = new System.Drawing.Point(2, 196);
            this.grb_DSNCC.Name = "grb_DSNCC";
            this.grb_DSNCC.Size = new System.Drawing.Size(753, 171);
            this.grb_DSNCC.TabIndex = 4;
            this.grb_DSNCC.TabStop = false;
            this.grb_DSNCC.Text = "Danh Sách Loại";
            // 
            // dtg_ShowTL
            // 
            this.dtg_ShowTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowTL.Location = new System.Drawing.Point(19, 26);
            this.dtg_ShowTL.Name = "dtg_ShowTL";
            this.dtg_ShowTL.RowHeadersWidth = 51;
            this.dtg_ShowTL.RowTemplate.Height = 29;
            this.dtg_ShowTL.Size = new System.Drawing.Size(721, 131);
            this.dtg_ShowTL.TabIndex = 0;
            this.dtg_ShowTL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowTL_CellClick);
            // 
            // grb_TTNCC
            // 
            this.grb_TTNCC.Controls.Add(this.txt_MaLoai);
            this.grb_TTNCC.Controls.Add(this.label2);
            this.grb_TTNCC.Controls.Add(this.txt_TrangThai);
            this.grb_TTNCC.Controls.Add(this.txt_TenLoai);
            this.grb_TTNCC.Controls.Add(this.label4);
            this.grb_TTNCC.Controls.Add(this.label3);
            this.grb_TTNCC.Location = new System.Drawing.Point(2, 26);
            this.grb_TTNCC.Name = "grb_TTNCC";
            this.grb_TTNCC.Size = new System.Drawing.Size(753, 164);
            this.grb_TTNCC.TabIndex = 3;
            this.grb_TTNCC.TabStop = false;
            this.grb_TTNCC.Text = "Thông Tin Thể Loại";
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Location = new System.Drawing.Point(265, 36);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(271, 27);
            this.txt_MaLoai.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Loại";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Location = new System.Drawing.Point(265, 117);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(271, 27);
            this.txt_TrangThai.TabIndex = 3;
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Location = new System.Drawing.Point(265, 75);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.Size = new System.Drawing.Size(271, 27);
            this.txt_TenLoai.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trạng Thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Loại";
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 512);
            this.Controls.Add(this.grb_TacVu);
            this.Controls.Add(this.grb_DSNCC);
            this.Controls.Add(this.grb_TTNCC);
            this.Name = "TheLoai";
            this.Text = "TheLoai";
            this.grb_TacVu.ResumeLayout(false);
            this.grb_DSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowTL)).EndInit();
            this.grb_TTNCC.ResumeLayout(false);
            this.grb_TTNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grb_TacVu;
        private Button bt_Xoa;
        private Button bt_Sua;
        private Button bt_Them;
        private Button bt_Show;
        private GroupBox grb_DSNCC;
        private DataGridView dtg_ShowTL;
        private GroupBox grb_TTNCC;
        private TextBox txt_MaLoai;
        private Label label2;
        private TextBox txt_TrangThai;
        private TextBox txt_TenLoai;
        private Label label4;
        private Label label3;
    }
}