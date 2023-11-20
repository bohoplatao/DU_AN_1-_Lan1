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
    public partial class DM_NhanVien : Form
    {
        private NhanVienService _service;
        int _idWhenClick;
        public DM_NhanVien()
        {
            InitializeComponent();
            _service = new NhanVienService();
        }

       

        private void bt_Show_Click(object sender, EventArgs e)
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

        private void bt_ThemAanh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;

            ptb_Anh.ImageLocation = filename;
            ptb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bt_ThemQR_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;

            ptb_Anh.ImageLocation = filename;
            ptb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            var a = new NhanVien();

            a.TenNhanVien = txt_TenNV.Text;
            a.DiaChi = txt_DiaChi.Text;
            a.HinhAnh = ptb_Anh.ImageLocation;
            a.SoDienThoai = decimal.Parse(txt_SDT.Text);
            a.NgaySinh = dt_ngaysinh.Value;
            a.MatKhau = txt_MK.Text;
            a.QRCode = ptb_QRCode.ImageLocation;


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
            var a = new NhanVien();
            a.MaNhanVien = int.Parse(txt_MaNV.Text);
            a.TenNhanVien = txt_TenNV.Text;
            a.DiaChi = txt_DiaChi.Text;
            a.HinhAnh = ptb_Anh.ImageLocation;
            a.SoDienThoai = decimal.Parse(txt_SDT.Text);
            a.NgaySinh = dt_ngaysinh.Value;
            a.MatKhau = txt_MK.Text;
            a.QRCode = ptb_QRCode.ImageLocation;


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

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            var a = new NhanVien();
            a.MaNhanVien = _idWhenClick;
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
            dt_ngaysinh .Text = a.NgaySinh.ToString();
            txt_MK.Text = a.MatKhau;
            ptb_QRCode.ImageLocation = a.QRCode;
            ptb_QRCode.SizeMode = PictureBoxSizeMode.StretchImage;



            
        }
    }
}
