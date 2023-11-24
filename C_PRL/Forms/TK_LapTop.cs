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
    public partial class TK_LapTop : Form
    {
        private LapTopSerVice _service;
        int _idWhenClick;
        public TK_LapTop()
        {
            InitializeComponent();
            _service = new LapTopSerVice();
            LoadData();
        }

      

       
        private void LoadData()
        {
            int stt = 1;
            dtg_ShowLT.ColumnCount = 8;
            dtg_ShowLT.Columns[0].Name = "STT";
            dtg_ShowLT.Columns[1].Name = "MÃ LT";

            dtg_ShowLT.Columns[2].Name = "Tên LT";
            dtg_ShowLT.Columns[3].Name = "Cân nặng ";
            dtg_ShowLT.Columns[4].Name = "Mô Tả";
            dtg_ShowLT.Columns[5].Name = "Trạng Thái";
            dtg_ShowLT.Columns[6].Name = "Ảnh";
            dtg_ShowLT.Columns[7].Name = "Số Lượng";


            dtg_ShowLT.Columns[1].Visible = false;
            dtg_ShowLT.Rows.Clear();
            foreach (var a in _service.GetAll(null))
            {
                dtg_ShowLT.Rows.Add(stt++, a.MaLaptop, a.TenLaptop, a.CanNang, a.MoTa, a.TrangThai, a.HinhAnh, a.Soluong);
            }
        }

        

      

       

        

        private void tb_Timkiem_TextChanged(object sender, EventArgs e)
        {
            //_service.GetAll(tb_Timkiem.Text);
            int stt = 1;
            dtg_ShowLT.ColumnCount = 8;
            dtg_ShowLT.Columns[0].Name = "STT";
            dtg_ShowLT.Columns[1].Name = "MÃ LT";

            dtg_ShowLT.Columns[2].Name = "Tên LT";
            dtg_ShowLT.Columns[3].Name = "Cân nặng ";
            dtg_ShowLT.Columns[4].Name = "Mô Tả";
            dtg_ShowLT.Columns[5].Name = "Trạng Thái";
            dtg_ShowLT.Columns[6].Name = "Ảnh";
            dtg_ShowLT.Columns[7].Name = "Số Lượng";


            dtg_ShowLT.Columns[1].Visible = false;
            dtg_ShowLT.Rows.Clear();
            foreach (var a in _service.GetAll(tb_Timkiem.Text))
            {
                dtg_ShowLT.Rows.Add(stt++, a.MaLaptop, a.TenLaptop, a.CanNang, a.MoTa, a.TrangThai, a.HinhAnh, a.Soluong);
            }
        }

        private void dtg_ShowLT_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idWhenClick = int.Parse(dtg_ShowLT.Rows[rowindex].Cells[1].Value.ToString());
            var a = _service.GetAll(null).FirstOrDefault(x => x.MaLaptop == _idWhenClick);
            txt_MaLapTop.Text = a.MaLaptop.ToString();
            txt_TenLapTop.Text = a.TenLaptop;
            txt_CanNang.Text = a.CanNang.ToString();
            txt_MoTa.Text = a.MoTa;
            txt_TrangThai.Text = a.TrangThai.ToString();
            ptb_Anh.ImageLocation = a.HinhAnh;
            ptb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
            txt_Soluong.Text = a.Soluong.ToString();
        }
    }
}
