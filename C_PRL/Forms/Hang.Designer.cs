namespace C_PRL.Forms
{
    partial class Hang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hang));
            this.grb_TTNCC = new System.Windows.Forms.GroupBox();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_DSNCC = new System.Windows.Forms.GroupBox();
            this.dtg_ShowNCC = new System.Windows.Forms.DataGridView();
            this.grb_TacVu = new System.Windows.Forms.GroupBox();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Show = new System.Windows.Forms.Button();
            this.grb_NhaCC = new System.Windows.Forms.GroupBox();
            this.grb_TTNCC.SuspendLayout();
            this.grb_DSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowNCC)).BeginInit();
            this.grb_TacVu.SuspendLayout();
            this.grb_NhaCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_TTNCC
            // 
            this.grb_TTNCC.Controls.Add(this.txt_MaNCC);
            this.grb_TTNCC.Controls.Add(this.label2);
            this.grb_TTNCC.Controls.Add(this.txt_DiaChi);
            this.grb_TTNCC.Controls.Add(this.txt_TenNCC);
            this.grb_TTNCC.Controls.Add(this.label4);
            this.grb_TTNCC.Controls.Add(this.label3);
            this.grb_TTNCC.Location = new System.Drawing.Point(14, 20);
            this.grb_TTNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TTNCC.Name = "grb_TTNCC";
            this.grb_TTNCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TTNCC.Size = new System.Drawing.Size(752, 134);
            this.grb_TTNCC.TabIndex = 0;
            this.grb_TTNCC.TabStop = false;
            this.grb_TTNCC.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Location = new System.Drawing.Point(232, 27);
            this.txt_MaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(427, 23);
            this.txt_MaNCC.TabIndex = 5;
            this.txt_MaNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaNCC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Nhà Cung Cấp";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(232, 88);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(427, 23);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Location = new System.Drawing.Point(232, 56);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(427, 23);
            this.txt_TenNCC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhà Cung Cấp";
            // 
            // grb_DSNCC
            // 
            this.grb_DSNCC.Controls.Add(this.dtg_ShowNCC);
            this.grb_DSNCC.Location = new System.Drawing.Point(14, 158);
            this.grb_DSNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_DSNCC.Name = "grb_DSNCC";
            this.grb_DSNCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_DSNCC.Size = new System.Drawing.Size(752, 201);
            this.grb_DSNCC.TabIndex = 1;
            this.grb_DSNCC.TabStop = false;
            this.grb_DSNCC.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // dtg_ShowNCC
            // 
            this.dtg_ShowNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ShowNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowNCC.Location = new System.Drawing.Point(17, 20);
            this.dtg_ShowNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_ShowNCC.Name = "dtg_ShowNCC";
            this.dtg_ShowNCC.RowHeadersWidth = 51;
            this.dtg_ShowNCC.RowTemplate.Height = 29;
            this.dtg_ShowNCC.Size = new System.Drawing.Size(710, 158);
            this.dtg_ShowNCC.TabIndex = 0;
            this.dtg_ShowNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowNCC_CellClick);
            // 
            // grb_TacVu
            // 
            this.grb_TacVu.Controls.Add(this.bt_Xoa);
            this.grb_TacVu.Controls.Add(this.bt_Sua);
            this.grb_TacVu.Controls.Add(this.bt_Them);
            this.grb_TacVu.Controls.Add(this.bt_Show);
            this.grb_TacVu.Location = new System.Drawing.Point(14, 363);
            this.grb_TacVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TacVu.Name = "grb_TacVu";
            this.grb_TacVu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TacVu.Size = new System.Drawing.Size(752, 85);
            this.grb_TacVu.TabIndex = 2;
            this.grb_TacVu.TabStop = false;
            this.grb_TacVu.Text = "Tác Vụ";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.Image")));
            this.bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Xoa.Location = new System.Drawing.Point(601, 20);
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
            this.bt_Sua.Location = new System.Drawing.Point(415, 20);
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
            this.bt_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Them.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Them.Image = ((System.Drawing.Image)(resources.GetObject("bt_Them.Image")));
            this.bt_Them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_Them.Location = new System.Drawing.Point(223, 20);
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
            this.bt_Show.Location = new System.Drawing.Point(31, 20);
            this.bt_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Show.Name = "bt_Show";
            this.bt_Show.Size = new System.Drawing.Size(126, 51);
            this.bt_Show.TabIndex = 0;
            this.bt_Show.Text = "Show";
            this.bt_Show.UseVisualStyleBackColor = true;
            this.bt_Show.Click += new System.EventHandler(this.bt_Show_Click);
            // 
            // grb_NhaCC
            // 
            this.grb_NhaCC.Controls.Add(this.grb_TacVu);
            this.grb_NhaCC.Controls.Add(this.grb_DSNCC);
            this.grb_NhaCC.Controls.Add(this.grb_TTNCC);
            this.grb_NhaCC.Location = new System.Drawing.Point(63, 2);
            this.grb_NhaCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_NhaCC.Name = "grb_NhaCC";
            this.grb_NhaCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_NhaCC.Size = new System.Drawing.Size(792, 462);
            this.grb_NhaCC.TabIndex = 8;
            this.grb_NhaCC.TabStop = false;
            // 
            // Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 475);
            this.Controls.Add(this.grb_NhaCC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hang";
            this.Text = "Nhà Cung Cấp";
            this.grb_TTNCC.ResumeLayout(false);
            this.grb_TTNCC.PerformLayout();
            this.grb_DSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowNCC)).EndInit();
            this.grb_TacVu.ResumeLayout(false);
            this.grb_NhaCC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grb_TTNCC;
        private TextBox txt_MaNCC;
        private Label label2;
        private TextBox txt_DiaChi;
        private TextBox txt_TenNCC;
        private Label label4;
        private Label label3;
        private GroupBox grb_DSNCC;
        private DataGridView dtg_ShowNCC;
        private GroupBox grb_TacVu;
        private Button bt_Xoa;
        private Button bt_Sua;
        private Button bt_Them;
        private Button bt_Show;
        private GroupBox grb_NhaCC;
    }
}