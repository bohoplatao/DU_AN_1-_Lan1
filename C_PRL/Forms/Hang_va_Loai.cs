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
    public partial class Hang_va_Loai : Form
    {
        private List<Button> childButtonsList1;
        private List<Button> childButtonsList2;
        public Hang_va_Loai()
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
        private void bt_HangSX_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            bt_HangSX.BackColor = Color.Brown;
            bt_TheLoai.BackColor = DefaultBackColor;
            Hang hang = new Hang();
            hang.TopLevel = false;
            hang.FormBorderStyle = FormBorderStyle.None;
            hang.Dock = DockStyle.Fill;
            panel1.Controls.Add(hang);
            hang.Show();
            
        }

        private void bt_TheLoai_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            bt_TheLoai.BackColor = Color.Brown;
            bt_HangSX.BackColor = DefaultBackColor;
            TheLoai tl = new TheLoai();
            tl.TopLevel = false;
            tl.FormBorderStyle = FormBorderStyle.None;
            tl.Dock = DockStyle.Fill;
            panel1.Controls.Add(tl);
            tl.Show();
           

        }

        private void bt_DanhMuc_Click(object sender, EventArgs e)
        {
            if (childButtonsList1[0].Visible)
                HideChildButtons1();
            else
                ShowChildButtons1();
        }

        private void bt_DM_LapTop_Click(object sender, EventArgs e)
        {

        }

        private void bt_DM_KhachHang_Click(object sender, EventArgs e)
        {

        }

        private void bt_DM_Nhanvien_Click(object sender, EventArgs e)
        {

        }

        private void bt_HoaDon_Click(object sender, EventArgs e)
        {

        }

        private void bt_TìmKiem_Click(object sender, EventArgs e)
        {
            if (childButtonsList2[0].Visible)
                HideChildButtons2();
            else
                ShowChildButtons2();
        }

        private void bt_TK_LapTop_Click(object sender, EventArgs e)
        {

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

        private void bt_BaoCao_Click(object sender, EventArgs e)
        {

        }

        private void bt_TaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu tt = new TrangChu();
            tt.Show();
            this.Hide();
        }

        private void bt_Hang_TheLoai_Click(object sender, EventArgs e)
        {

        }
    }
}
