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
    public partial class TK_Nhanvien : Form
    {
        private NhanVienService _service;
        int _idWhenClick;
        public TK_Nhanvien()
        {
            InitializeComponent();
            _service = new NhanVienService();
            LoadData();
        }

        private void LoadData()
        {
            int stt = 1;
            dtg_ShowNV.ColumnCount = 9;
            dtg_ShowNV.Columns[0].Name = "STT";
            dtg_ShowNV.Columns[1].Name = "MÃ NV";

            dtg_ShowNV.Columns[2].Name = "Tên NV";
            dtg_ShowNV.Columns[3].Name = "Địa Chỉ    ";
            dtg_ShowNV.Columns[4].Name = "HÌnh Ảnh";
            dtg_ShowNV.Columns[5].Name = "SDT";
            dtg_ShowNV.Columns[6].Name = "ngay sinh";
            dtg_ShowNV.Columns[7].Name = "MK";
            dtg_ShowNV.Columns[8].Name = "QRCode";



            dtg_ShowNV.Columns[1].Visible = false;
            dtg_ShowNV.Rows.Clear();
            foreach (var a in _service.GetAll(null))
            {
                dtg_ShowNV.Rows.Add(stt++, a.MaNhanVien, a.TenNhanVien, a.DiaChi, a.HinhAnh, a.SoDienThoai, a.NgaySinh, a.MatKhau, a.QRCode);
            }
        }
        private void dtg_ShowNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idWhenClick = int.Parse(dtg_ShowNV.Rows[rowindex].Cells[1].Value.ToString());
            var a = _service.GetAll(null).FirstOrDefault(x => x.MaNhanVien == _idWhenClick);
            txt_MaNV.Text = a.MaNhanVien.ToString();
            txt_TenNV.Text = a.TenNhanVien;
            txt_DiaChi.Text = a.DiaChi;
            ptb_Anh.ImageLocation = a.HinhAnh;
            ptb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
            txt_SDT.Text = a.SoDienThoai.ToString();
            dt_ngaysinh.Text = a.NgaySinh.ToString();
            txt_MK.Text = a.MatKhau;
            ptb_QRCode.ImageLocation = a.QRCode;
            ptb_QRCode.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tb_Tk_TextChanged(object sender, EventArgs e)
        {
            int stt = 1;
            dtg_ShowNV.ColumnCount = 9;
            dtg_ShowNV.Columns[0].Name = "STT";
            dtg_ShowNV.Columns[1].Name = "MÃ NV";

            dtg_ShowNV.Columns[2].Name = "Tên NV";
            dtg_ShowNV.Columns[3].Name = "Địa Chỉ    ";
            dtg_ShowNV.Columns[4].Name = "HÌnh Ảnh";
            dtg_ShowNV.Columns[5].Name = "SDT";
            dtg_ShowNV.Columns[6].Name = "ngay sinh";
            dtg_ShowNV.Columns[7].Name = "MK";
            dtg_ShowNV.Columns[8].Name = "QRCode";



            dtg_ShowNV.Columns[1].Visible = false;
            dtg_ShowNV.Rows.Clear();
            foreach (var a in _service.GetAll(tb_Tk.Text))
            {
                dtg_ShowNV.Rows.Add(stt++, a.MaNhanVien, a.TenNhanVien, a.DiaChi, a.HinhAnh, a.SoDienThoai, a.NgaySinh, a.MatKhau, a.QRCode);
            }
        }

        private void dtg_ShowNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7) // Thay đổi số 2 thành chỉ số cột mật khẩu của bạn
            {
                if (e.Value != null)
                {
                    // Thay thế giá trị hiển thị thành ký tự '**'
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }
    }
}
