namespace C_PRL.Forms
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_doimk = new System.Windows.Forms.Button();
            this.checkb1 = new System.Windows.Forms.CheckBox();
            this.txt_mkcu = new System.Windows.Forms.TextBox();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.txtnhaplaimkmoi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mật Khẩu Cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nhập Lại Mật Khẩu mới";
            // 
            // btn_doimk
            // 
            this.btn_doimk.Location = new System.Drawing.Point(564, 312);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(148, 50);
            this.btn_doimk.TabIndex = 47;
            this.btn_doimk.Text = "Đổi Mật Khẩu";
            this.btn_doimk.UseVisualStyleBackColor = true;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // checkb1
            // 
            this.checkb1.AutoSize = true;
            this.checkb1.Location = new System.Drawing.Point(387, 281);
            this.checkb1.Name = "checkb1";
            this.checkb1.Size = new System.Drawing.Size(124, 19);
            this.checkb1.TabIndex = 48;
            this.checkb1.Text = "Hiển thị mật khẩu ";
            this.checkb1.UseVisualStyleBackColor = true;
            this.checkb1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_mkcu
            // 
            this.txt_mkcu.Location = new System.Drawing.Point(520, 133);
            this.txt_mkcu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mkcu.Name = "txt_mkcu";
            this.txt_mkcu.Size = new System.Drawing.Size(225, 23);
            this.txt_mkcu.TabIndex = 49;
            this.txt_mkcu.UseSystemPasswordChar = true;
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Location = new System.Drawing.Point(520, 188);
            this.txt_mkmoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.Size = new System.Drawing.Size(225, 23);
            this.txt_mkmoi.TabIndex = 50;
            this.txt_mkmoi.UseSystemPasswordChar = true;
            // 
            // txtnhaplaimkmoi
            // 
            this.txtnhaplaimkmoi.Location = new System.Drawing.Point(520, 234);
            this.txtnhaplaimkmoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnhaplaimkmoi.Name = "txtnhaplaimkmoi";
            this.txtnhaplaimkmoi.Size = new System.Drawing.Size(225, 23);
            this.txtnhaplaimkmoi.TabIndex = 51;
            this.txtnhaplaimkmoi.UseSystemPasswordChar = true;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 510);
            this.Controls.Add(this.txtnhaplaimkmoi);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.txt_mkcu);
            this.Controls.Add(this.checkb1);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_doimk;
        private CheckBox checkb1;
        private TextBox txt_mkcu;
        private TextBox txt_mkmoi;
        private TextBox txtnhaplaimkmoi;
    }
}