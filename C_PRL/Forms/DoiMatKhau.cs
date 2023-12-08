using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_PRL.Forms
{
    public partial class DoiMatKhau : Form
    {
        NhanVienService _service = new NhanVienService();
        int tk;
        string mk;
        public DoiMatKhau( int tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = checkb1.Checked;
            txt_mkcu.UseSystemPasswordChar = !showPassword;
            txt_mkmoi.UseSystemPasswordChar = !showPassword;
            txtnhaplaimkmoi.UseSystemPasswordChar = !showPassword;
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            if(txt_mkmoi.Text !="" && txtnhaplaimkmoi.Text !="" && txtnhaplaimkmoi.Text != "")
            {
                if (txt_mkmoi.Text == txtnhaplaimkmoi.Text)
                {
                    bool doimk = _service.ChanggPassWord(tk,txt_mkcu.Text,txt_mkmoi.Text);

                    if (doimk)
                    {
                        MessageBox.Show(" Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(" Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
