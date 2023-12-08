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
    public partial class SALESS : Form
    {
        private SaleService _service;
        int _idWhenClick;
        public SALESS()
        {
            InitializeComponent();
            _service = new SaleService();
        }

        private void grb_TTNCC_Enter(object sender, EventArgs e)
        {

        }

       

        private void bt_Show_Click(object sender, EventArgs e)
        {
            int stt = 1;
            dtg_ShowSALE.ColumnCount = 8;
            dtg_ShowSALE.Columns[0].Name = "STT";
            dtg_ShowSALE.Columns[1].Name = "Mã Sale";
            dtg_ShowSALE.Columns[2].Name = "Tên đợt sale";
            dtg_ShowSALE.Columns[3].Name = "Thời Gian Bắt Đầu";
            dtg_ShowSALE.Columns[4].Name = "Thời Gian Kết THúc";
            dtg_ShowSALE.Columns[5].Name = "MÃ Nhân Viên";
            dtg_ShowSALE.Columns[6].Name = "Tên Nhân Viên";
            dtg_ShowSALE.Columns[7].Name = "sdt";

            dtg_ShowSALE.Rows.Clear();
            foreach (var s in _service.GetNhanVienWithSales())
            {
                dtg_ShowSALE.Rows.Add(stt++, s.MaSale, s.TenDotSale, s.ThoiGianBD, s.ThoiGianKT, s.MaNhanVien, s.TenNhanVien, s.SoDienThoai);
            }
        }

        private void dtg_ShowSALE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idWhenClick = int.Parse(dtg_ShowSALE.Rows[rowindex].Cells[1].Value.ToString());
            var sv = _service.GetAllSALE().FirstOrDefault(x => x.MaSale == _idWhenClick);
            txt_MaSale.Text = sv.MaSale.ToString();
            txt_TenSale.Text = sv.TenDotSale;
            dt_BD.Value = sv.ThoiGianBD;
            dt_KT.Value = sv.ThoiGianKT;
            txt_MaNV.Text = sv.MaNhanVien.ToString();
            
            
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            var s = new Sale();
            s.TenDotSale = txt_TenSale.Text;
            s.ThoiGianBD = dt_BD.Value;
            s.ThoiGianKT = dt_KT.Value;
            s.MaNhanVien = int.Parse(txt_MaNV.Text);
            
            var option = MessageBox.Show("Xac nhan Them", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(s));
            }
            else
            {
                return;
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            var s = new Sale();
            s.MaSale = _idWhenClick;
            s.TenDotSale = txt_TenSale.Text;
            s.ThoiGianBD = dt_BD.Value;
            s.ThoiGianKT = dt_KT.Value;
            s.MaNhanVien = int.Parse(txt_MaNV.Text);
            var option = MessageBox.Show("Xac nhan sua", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(s));
            }
            else
            {
                return;
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            var sv = new Sale();
            sv.MaSale = _idWhenClick;
            var option = MessageBox.Show("Xac nhan xoa", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(sv));
            }
            else
            {
                return;
            }
        }




      
    }
}
