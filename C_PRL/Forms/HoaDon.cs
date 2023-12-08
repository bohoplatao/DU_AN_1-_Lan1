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
    public partial class HoaDon : Form
    {
        private HoaDonService _service;
        private HoaDonCTService _ctService;
        int _idWhenClick;
        int _idWhenClick2;

        public HoaDon()
        {
            InitializeComponent();
            _service = new HoaDonService();
            _ctService = new HoaDonCTService(); 
            
        }

        private void LoadData1()
        {
            int stt = 1;
            dtg_ChuaThanhToan.ColumnCount = 9;
            dtg_ChuaThanhToan.Columns[0].Name = "STT";
            dtg_ChuaThanhToan.Columns[1].Name = "MÃ Hóa Đơn";

            dtg_ChuaThanhToan.Columns[2].Name = "Mã Khách Hàng";
            dtg_ChuaThanhToan.Columns[3].Name = "Tên Người Nhận";
            dtg_ChuaThanhToan.Columns[4].Name = "Địa Chỉ";
            dtg_ChuaThanhToan.Columns[5].Name = "SDT";
            dtg_ChuaThanhToan.Columns[6].Name = "ngay mua";
            dtg_ChuaThanhToan.Columns[7].Name = "Chú Thích";
            dtg_ChuaThanhToan.Columns[8].Name = "Trang Thai";


            dtg_ChuaThanhToan.Columns[1].Visible = false;
            dtg_ChuaThanhToan.Rows.Clear();
            foreach (var a in _service.GetAll(null))
            {
                dtg_ChuaThanhToan.Rows.Add(stt++, a.MaHoaDon, a.MaKhachHang, a.TenNguoiNhan, a.DiaChi, a.SoDienThoai, a.NgayMua, a.ChuThich,a.TrangThai);
            }

        }

        private void dtg_ChuaThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idWhenClick = int.Parse(dtg_ChuaThanhToan.Rows[rowindex].Cells[1].Value.ToString());
            var a = _service.GetAll(null).FirstOrDefault(x => x.MaHoaDon == _idWhenClick);
            txt_MaHoaDon.Text = a.MaHoaDon.ToString();
            txt_MaKH.Text = a.MaKhachHang.ToString();
            txt_DChi.Text = a.DiaChi;
            txt_ChuThich.Text = a.ChuThich;
            txt_Sdt.Text = a.SoDienThoai.ToString();
            txt_TennguoiNhan.Text = a.TenNguoiNhan;
            dateTimePicker1.Text = a.NgayMua.ToString();
            txt_Trangthai.Text = a.TrangThai.ToString();

        }

        private void LoadData2()
        {
            int stt = 1;
            dtg_DaTHanhToan.ColumnCount = 6;
            dtg_DaTHanhToan.Columns[0].Name = "STT";
            dtg_DaTHanhToan.Columns[1].Name = "MÃ Hóa Đơn CT";

            dtg_DaTHanhToan.Columns[2].Name = "Mã Hóa Đơn";
            dtg_DaTHanhToan.Columns[3].Name = "Mã Serial";
            dtg_DaTHanhToan.Columns[4].Name = "Giá";
            dtg_DaTHanhToan.Columns[5].Name = "";


            dtg_DaTHanhToan.Columns[1].Visible = false;
            //dtg_DaTHanhToan.Columns[5].Visible = false;

            dtg_DaTHanhToan.Rows.Clear();
            foreach (var a in _ctService.GetAllHDCT())
            {
                dtg_DaTHanhToan.Rows.Add(stt++, a.MaHoaDonChiTiet, a.MaHoaDon, a.MaSerial, a.Gia, a.Serial);
            }
            


        }

        

       

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadData1();
            LoadData2();
        }

        private void dtg_DaTHanhToan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idWhenClick2 = int.Parse(dtg_DaTHanhToan.Rows[rowindex].Cells[1].Value.ToString());
            var a = _ctService.GetAllHDCT().FirstOrDefault(x => x.MaHoaDonChiTiet == _idWhenClick2);
            //txt_MaHoaDon.Text = a.MaHoaDon.ToString();
            txt_MaSerial.Text = a.MaSerial.ToString();
            txt_gia.Text = a.Gia.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            txt_ChuThich.Text = "";
            txt_DChi.Text = "";
            txt_gia.Text = "";
            txt_MaHoaDon.Text = "";
            txt_MaKH.Text = "";
            txt_MaSerial.Text = "";
            txt_Sdt.Text = "";
            txt_TennguoiNhan.Text = "";
            txt_Trangthai.Text = "";
            
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {

        }

        //private void bt_Them_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("Chon ma serial?");
        //    var a = new HoaDonCT();
        //    a.MaHoaDon = int.Parse(txt_MaHoaDon.Text);
        //    a.MaSerial = int.Parse(txt_MaSerial.Text);
        //    a.Gia = float.Parse(txt_gia.Text);
        //    var option = MessageBox.Show("Xac nhan Them", "Xac Nhan", MessageBoxButtons.YesNo);
        //    if (option == DialogResult.Yes)
        //    {
        //        MessageBox.Show(_ctService.Add(a));
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}


    }
}
