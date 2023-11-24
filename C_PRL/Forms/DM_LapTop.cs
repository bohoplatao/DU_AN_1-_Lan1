
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
    public partial class DM_LapTop : Form
    {
        private LapTopSerVice _service;
        int _idWhenClick;
        public DM_LapTop()
        {
            InitializeComponent();
            _service = new LapTopSerVice();
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
                dtg_ShowLT.Rows.Add(stt++, a.MaLaptop,a.TenLaptop, a.CanNang, a.MoTa, a.TrangThai, a.HinhAnh,a.Soluong);
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            var a = new LapTop();
            
            a.TenLaptop = txt_TenLapTop.Text;
            a.CanNang = float.Parse(txt_CanNang.Text);
            a.MoTa = txt_MoTa.Text;
            a.TrangThai = bool.Parse(txt_TrangThai.Text);
            a.HinhAnh = ptb_Anh.ImageLocation;
            a.Soluong = int.Parse(txt_Soluong.Text);
           

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
            var a = new LapTop();
            a.MaLaptop = int.Parse(txt_MaLapTop.Text);
            a.TenLaptop = txt_TenLapTop.Text;
            a.CanNang = float.Parse(txt_CanNang.Text);
            a.MoTa = txt_MoTa.Text;
            a.TrangThai = bool.Parse(txt_TrangThai.Text);
            a.HinhAnh = ptb_Anh.ImageLocation;
            a.Soluong = int.Parse(txt_Soluong.Text);

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
            var a = new LapTop();
            a.MaLaptop = _idWhenClick;
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

        private void dtg_ShowLT_CellClick(object sender, DataGridViewCellEventArgs e)
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
    


