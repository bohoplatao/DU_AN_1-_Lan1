namespace C_PRL.Forms
{
    partial class SALESS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SALESS));
            this.label1 = new System.Windows.Forms.Label();
            this.grb_NhaCC = new System.Windows.Forms.GroupBox();
            this.grb_TacVu = new System.Windows.Forms.GroupBox();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Show = new System.Windows.Forms.Button();
            this.grb_DSNCC = new System.Windows.Forms.GroupBox();
            this.dtg_ShowSALE = new System.Windows.Forms.DataGridView();
            this.grb_TTNCC = new System.Windows.Forms.GroupBox();
            this.dt_KT = new System.Windows.Forms.DateTimePicker();
            this.dt_BD = new System.Windows.Forms.DateTimePicker();
            this.txt_TenSale = new System.Windows.Forms.TextBox();
            this.txt_MaSale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_NhaCC.SuspendLayout();
            this.grb_TacVu.SuspendLayout();
            this.grb_DSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowSALE)).BeginInit();
            this.grb_TTNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(229, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "SALE";
            // 
            // grb_NhaCC
            // 
            this.grb_NhaCC.Controls.Add(this.grb_TacVu);
            this.grb_NhaCC.Controls.Add(this.grb_DSNCC);
            this.grb_NhaCC.Controls.Add(this.grb_TTNCC);
            this.grb_NhaCC.Location = new System.Drawing.Point(24, 42);
            this.grb_NhaCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_NhaCC.Name = "grb_NhaCC";
            this.grb_NhaCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_NhaCC.Size = new System.Drawing.Size(869, 590);
            this.grb_NhaCC.TabIndex = 15;
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
            this.grb_DSNCC.Controls.Add(this.dtg_ShowSALE);
            this.grb_DSNCC.Location = new System.Drawing.Point(6, 273);
            this.grb_DSNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_DSNCC.Name = "grb_DSNCC";
            this.grb_DSNCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_DSNCC.Size = new System.Drawing.Size(857, 224);
            this.grb_DSNCC.TabIndex = 1;
            this.grb_DSNCC.TabStop = false;
            this.grb_DSNCC.Text = "Danh Sách ";
            // 
            // dtg_ShowSALE
            // 
            this.dtg_ShowSALE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ShowSALE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowSALE.Location = new System.Drawing.Point(17, 20);
            this.dtg_ShowSALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_ShowSALE.Name = "dtg_ShowSALE";
            this.dtg_ShowSALE.RowHeadersWidth = 51;
            this.dtg_ShowSALE.RowTemplate.Height = 29;
            this.dtg_ShowSALE.Size = new System.Drawing.Size(834, 200);
            this.dtg_ShowSALE.TabIndex = 0;
            this.dtg_ShowSALE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowSALE_CellClick);
            // 
            // grb_TTNCC
            // 
            this.grb_TTNCC.Controls.Add(this.dt_KT);
            this.grb_TTNCC.Controls.Add(this.dt_BD);
            this.grb_TTNCC.Controls.Add(this.txt_TenSale);
            this.grb_TTNCC.Controls.Add(this.txt_MaSale);
            this.grb_TTNCC.Controls.Add(this.label7);
            this.grb_TTNCC.Controls.Add(this.label6);
            this.grb_TTNCC.Controls.Add(this.label5);
            this.grb_TTNCC.Controls.Add(this.label4);
            this.grb_TTNCC.Controls.Add(this.txt_MaNV);
            this.grb_TTNCC.Controls.Add(this.label2);
            this.grb_TTNCC.Location = new System.Drawing.Point(14, 20);
            this.grb_TTNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TTNCC.Name = "grb_TTNCC";
            this.grb_TTNCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TTNCC.Size = new System.Drawing.Size(843, 249);
            this.grb_TTNCC.TabIndex = 0;
            this.grb_TTNCC.TabStop = false;
            this.grb_TTNCC.Text = "Thông Tin ";
            this.grb_TTNCC.Enter += new System.EventHandler(this.grb_TTNCC_Enter);
            // 
            // dt_KT
            // 
            this.dt_KT.Location = new System.Drawing.Point(120, 114);
            this.dt_KT.Name = "dt_KT";
            this.dt_KT.Size = new System.Drawing.Size(321, 23);
            this.dt_KT.TabIndex = 21;
            // 
            // dt_BD
            // 
            this.dt_BD.Location = new System.Drawing.Point(120, 80);
            this.dt_BD.Name = "dt_BD";
            this.dt_BD.Size = new System.Drawing.Size(321, 23);
            this.dt_BD.TabIndex = 20;
            // 
            // txt_TenSale
            // 
            this.txt_TenSale.Location = new System.Drawing.Point(120, 46);
            this.txt_TenSale.Name = "txt_TenSale";
            this.txt_TenSale.Size = new System.Drawing.Size(321, 23);
            this.txt_TenSale.TabIndex = 19;
            // 
            // txt_MaSale
            // 
            this.txt_MaSale.Location = new System.Drawing.Point(120, 10);
            this.txt_MaSale.Name = "txt_MaSale";
            this.txt_MaSale.Size = new System.Drawing.Size(321, 23);
            this.txt_MaSale.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thời gian KT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thời Gian BD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên Đợt Sale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Sale";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(120, 153);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(321, 23);
            this.txt_MaNV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "MaNV";
            // 
            // SALESS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_NhaCC);
            this.Name = "SALESS";
            this.Text = "SALESS";
            this.grb_NhaCC.ResumeLayout(false);
            this.grb_TacVu.ResumeLayout(false);
            this.grb_DSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowSALE)).EndInit();
            this.grb_TTNCC.ResumeLayout(false);
            this.grb_TTNCC.PerformLayout();
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
        private DataGridView dtg_ShowSALE;
        private GroupBox grb_TTNCC;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_MaNV;
        private Label label2;
        private DateTimePicker dt_KT;
        private DateTimePicker dt_BD;
        private TextBox txt_TenSale;
        private TextBox txt_MaSale;
    }
}