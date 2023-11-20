using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.Forms
{
    public partial class TrangChu : Form
    {
        private List<Button> childButtonsList1;
        private List<Button> childButtonsList2;
        public TrangChu()
        {
            InitializeComponent();
            childButtonsList1 = new List<Button>();
            childButtonsList1.Add(bt_Hang_TheLoai);
            childButtonsList1.Add(bt_DM_LapTop);
            childButtonsList1.Add(bt_DM_KhachHang);
            childButtonsList1.Add(bt_DM_Nhanvien);

            childButtonsList2 = new List<Button>();
            childButtonsList2.Add(bt_TK_LapTop);
            childButtonsList2.Add(bt_TK_KhachHang);
            childButtonsList2.Add(bt_TK_HoaDon);
            childButtonsList2.Add(bt_TK_NhanVien);

            HideChildButtons1();
            HideChildButtons2();
            
        }
        
        private void HideChildButtons1()
        {
            foreach (Button btcon in childButtonsList1)
            {
                btcon.Visible = false;
            }
        }

        private void ShowChildButtons1()
        {
            foreach (Button btcon in childButtonsList1)
            {
                btcon.Visible = true;
            }
        }
        private void HideChildButtons2()
        {
            foreach (Button btcon in childButtonsList2)
            {
                btcon.Visible = false;
            }
        }

        private void ShowChildButtons2()
        {
            foreach (Button btcon in childButtonsList2)
            {
                btcon.Visible = true;
            }
        }

        private void bt_DanhMuc_Click(object sender, EventArgs e)
        {
            if (childButtonsList1[0].Visible)
                HideChildButtons1();
            else
                ShowChildButtons1();


        }

        private void bt_TìmKiem_Click(object sender, EventArgs e)
        {
            if (childButtonsList2[0].Visible)
                HideChildButtons2();
            else
                ShowChildButtons2();
        }

        private void bt_Hang_TheLoai_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
          
            Hang_va_Loai hang = new Hang_va_Loai();
            hang.TopLevel = false;
            hang.FormBorderStyle = FormBorderStyle.None;
            hang.Dock = DockStyle.Fill;
            panel1.Controls.Add(hang);
            hang.Show();
        }

        private void bt_HoaDon_Click(object sender, EventArgs e)
        {

        }

        private void bt_BaoCao_Click(object sender, EventArgs e)
        {

        }

        private void bt_TaiKhoan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả người dùng chọn
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void bt_DM_LapTop_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            DM_LapTop hang = new DM_LapTop();
            hang.TopLevel = false;
            hang.FormBorderStyle = FormBorderStyle.None;
            hang.Dock = DockStyle.Fill;
            panel1.Controls.Add(hang);
            hang.Show();
        }

        private void bt_DM_KhachHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            DM_KhachHang hang = new DM_KhachHang();
            hang.TopLevel = false;
            hang.FormBorderStyle = FormBorderStyle.None;
            hang.Dock = DockStyle.Fill;
            panel1.Controls.Add(hang);
            hang.Show();
        }

        private void bt_DM_Nhanvien_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            DM_NhanVien hang = new DM_NhanVien();
            hang.TopLevel = false;
            hang.FormBorderStyle = FormBorderStyle.None;
            hang.Dock = DockStyle.Fill;
            panel1.Controls.Add(hang);
            hang.Show();
        }

        private void bt_TK_LapTop_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            TK_LapTop hang = new TK_LapTop();
            hang.TopLevel = false;
            hang.FormBorderStyle = FormBorderStyle.None;
            hang.Dock = DockStyle.Fill;
            panel1.Controls.Add(hang);
            hang.Show();
        }

        private void bt_TK_KhachHang_Click(object sender, EventArgs e)
        {

        }

        private void bt_TK_HoaDon_Click(object sender, EventArgs e)
        {

        }

        private void bt_TK_NhanVien_Click(object sender, EventArgs e)
        {

        }
    }

   
}
