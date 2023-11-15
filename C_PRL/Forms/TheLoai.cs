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
    public partial class TheLoai : Form
    {
        private PhanLoaiService _service;
        int _idWhenClick;
        public TheLoai()
        {
            InitializeComponent();
            _service = new PhanLoaiService();
            bt_Them.Enabled = false;
            bt_Sua.Enabled = false;

            bt_Xoa.Enabled = false;
        }

        private void bt_Show_Click(object sender, EventArgs e)
        {
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;

            bt_Xoa.Enabled = true;
            //--------------------------------------------
            int stt = 1;
            dtg_ShowTL.ColumnCount = 4;
            dtg_ShowTL.Columns[0].Name = "STT";
            dtg_ShowTL.Columns[1].Name = "MÃ LOẠI";
            dtg_ShowTL.Columns[2].Name = "TÊN LOẠI";
            dtg_ShowTL.Columns[3].Name = "TRẠNG THÁI";



            dtg_ShowTL.Columns[1].Visible = false;
            dtg_ShowTL.Rows.Clear();
            foreach (var ncc in _service.GetAll(null))
            {
                dtg_ShowTL.Rows.Add(stt++, ncc.MaPhanLoai, ncc.TenLoai, ncc.TrangThai);
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            var pl = new PhanLoai();
            pl.TenLoai = txt_TenLoai.Text;
            pl.TrangThai = txt_TrangThai.Text;

            var option = MessageBox.Show("Xac nhan Them", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(pl));
            }
            else
            {
                return;
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            var pl = new PhanLoai();
            pl.MaPhanLoai = int.Parse(txt_MaLoai.Text);
            pl.TenLoai = txt_TenLoai.Text;
            pl.TrangThai = txt_TrangThai.Text;

            var option = MessageBox.Show("Xac nhan Sua", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(pl));
            }
            else
            {
                return;
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            var pl = new PhanLoai();
            pl.MaPhanLoai = _idWhenClick;
            var option = MessageBox.Show("Xac nhan Xoa", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(pl));
            }
            else
            {
                return;
            }
        }

        private void dtg_ShowTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idWhenClick = int.Parse(dtg_ShowTL.Rows[rowindex].Cells[1].Value.ToString());
            var pl = _service.GetAll(null).FirstOrDefault(x => x.MaPhanLoai == _idWhenClick);
            txt_MaLoai.Text = pl.MaPhanLoai.ToString();
            txt_TenLoai.Text = pl.TenLoai;
            txt_TrangThai.Text = pl.TrangThai;
        }
    }
}
