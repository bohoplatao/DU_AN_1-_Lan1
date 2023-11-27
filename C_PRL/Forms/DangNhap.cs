using A_DAL.Repositories;
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
        DangNhapRepos _repos = new DangNhapRepos();
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
             
            var data = _repos.GetOne().FirstOrDefault(x => x.SoDienThoai.ToString() == txt_Login.Text);
           
            if (data == null || data.MatKhau != txt_PassWord.Text)
            {
                return;
            }
            else
            {
               

                TrangChu trangchu = new TrangChu();
                trangchu.Show();
                trangchu.FormClosed += Login_FormClosed;
                this.Hide();

            }
            

            
           


        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_LoginQR_Click(object sender, EventArgs e)
        {
            DangNhapQR qr = new DangNhapQR();
            qr.Show();
            qr.FormClosed += Login_FormClosed;
            this.Hide();
        }
    }
}
