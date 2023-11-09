using C_PRL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát???", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thoát thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

            if (result == DialogResult.No)
            {
                MessageBox.Show("Tiếp tục chương trình", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            TrangChu tt= new TrangChu();
            tt.Show();
            this.Hide();
        }
    }
}
