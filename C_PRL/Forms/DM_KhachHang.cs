using A_DAL.Model;
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

namespace C_PRL.Forms
{
    public partial class DM_KhachHang : Form
    {
        private KhachHangService _service;
        int _idWhenClick;
        public DM_KhachHang()
        {
            InitializeComponent();
            _service = new KhachHangService();
            bt_Them.Enabled = false;
            bt_Sua.Enabled = false;

            bt_Xoa.Enabled = false;
        }

        private void bt_ThemAanh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;

            ptb_Anh.ImageLocation = filename;
            ptb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bt_Show_Click(object sender, EventArgs e)
        {
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;

            bt_Xoa.Enabled = true;
            //--------------------------------------------
            int stt = 1;
            dtg_ShowKH.ColumnCount = 7;
            dtg_ShowKH.Columns[0].Name = "STT";
            dtg_ShowKH.Columns[1].Name = "MÃ Khách Hàng";
            dtg_ShowKH.Columns[2].Name = "TÊN KH";
            dtg_ShowKH.Columns[3].Name = "ĐỊA CHỈ";
            dtg_ShowKH.Columns[4].Name = "Hình Ảnh ";
            dtg_ShowKH.Columns[5].Name = "SDT";
            dtg_ShowKH.Columns[6].Name = "Ngày Sinh";






            dtg_ShowKH.Columns[1].Visible = false;
            dtg_ShowKH.Rows.Clear();
            foreach (var a in _service.GetAll(null))
            {
                dtg_ShowKH.Rows.Add(stt++, a.MaKhachHang, a.TenKhachHang, a.DiaChi,a.HinhAnh,a.SoDienThoai,a.NgaySinh);
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            var a = new KhachHang();
            a.TenKhachHang = txt_TenKH.Text;
            a.DiaChi = txt_DiaChi.Text;
            a.HinhAnh = ptb_Anh.ImageLocation;
            a.SoDienThoai = Convert.ToDecimal(txt_SDT.Text);
            a.NgaySinh = dt_ngaysinh.Value;

            var option = MessageBox.Show("Xac nhan Them", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(a));
            }
            else
            {
                return;
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            var a = new KhachHang();
            a.MaKhachHang = int.Parse(txt_MaKH.Text);
            a.TenKhachHang = txt_TenKH.Text;
            a.DiaChi = txt_DiaChi.Text;
            a.HinhAnh = ptb_Anh.ImageLocation;
            a.SoDienThoai= Convert.ToDecimal(txt_SDT.Text);
            a.NgaySinh = dt_ngaysinh.Value;
            var option = MessageBox.Show("Xac nhan Sua", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(a));
            }
            else
            {
                return;
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            var a = new KhachHang();
            a.MaKhachHang = _idWhenClick;
            var option = MessageBox.Show("Xac nhan Xoa", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(a));
            }
            else
            {
                return;
            }
        }

        private void dtg_ShowKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idWhenClick = int.Parse(dtg_ShowKH.Rows[rowindex].Cells[1].Value.ToString());
            var a = _service.GetAll(null).FirstOrDefault(x => x.MaKhachHang == _idWhenClick);
            txt_MaKH.Text = a.MaKhachHang.ToString();
            txt_TenKH.Text = a.TenKhachHang;
            txt_DiaChi.Text = a.DiaChi;
            ptb_Anh.ImageLocation = a.HinhAnh;
            ptb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
            txt_SDT.Text = a.SoDienThoai.ToString();
            dt_ngaysinh.Text = a.NgaySinh.ToString();
        }
    }
}
