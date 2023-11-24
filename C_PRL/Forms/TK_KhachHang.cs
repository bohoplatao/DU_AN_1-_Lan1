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
    public partial class TK_KhachHang : Form
    {
        private KhachHangService _service;
        int _idWhenClick;
        public TK_KhachHang()
        {
            InitializeComponent();
            _service = new KhachHangService();
            LoadData();
        }

        private void LoadData()
        {
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
                dtg_ShowKH.Rows.Add(stt++, a.MaKhachHang, a.TenKhachHang, a.DiaChi, a.HinhAnh, a.SoDienThoai, a.NgaySinh);
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

        private void tb_Tk_TextChanged(object sender, EventArgs e)
        {
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
            foreach (var a in _service.GetAll(tb_Tk.Text))
            {
                dtg_ShowKH.Rows.Add(stt++, a.MaKhachHang, a.TenKhachHang, a.DiaChi, a.HinhAnh, a.SoDienThoai, a.NgaySinh);
            }
        }
    }
}
