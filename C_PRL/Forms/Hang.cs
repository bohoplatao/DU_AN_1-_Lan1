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
    public partial class Hang : Form
    {
       

        private NCCService _service;
        int _idWhenClick;
        public Hang()
        {
            InitializeComponent();
            _service = new NCCService();
            bt_Them.Enabled = false;
            bt_Sua.Enabled = false;

            bt_Xoa.Enabled = false;



        }

        

     

        //------------------------------------------------------------------------------------//
        private void bt_Show_Click(object sender, EventArgs e)
        {
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;

            bt_Xoa.Enabled = true;
            //--------------------------------------------
            int stt = 1;
            dtg_ShowNCC.ColumnCount = 4;
            dtg_ShowNCC.Columns[0].Name = "STT";
            dtg_ShowNCC.Columns[1].Name = "MÃ NHÀ CUNG CẤP";
            dtg_ShowNCC.Columns[2].Name = "TÊN NHÀ CUNG CẤP";
            dtg_ShowNCC.Columns[3].Name = "ĐỊA CHỈ";
          
           

            dtg_ShowNCC.Columns[1].Visible = false;
            dtg_ShowNCC.Rows.Clear();
            foreach (var ncc in _service.GetAll(null))
            {
                dtg_ShowNCC.Rows.Add(stt++, ncc.MaNCC, ncc.TenNCC, ncc.DiaChi);
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            var ncc = new NhaCungCap();
            ncc.TenNCC = txt_TenNCC.Text;
            ncc.DiaChi = txt_DiaChi.Text;
           
            var option = MessageBox.Show("Xac nhan Them", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(ncc));
            }
            else
            {
                return;
            }
        }

        private void dtg_ShowNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idWhenClick = int.Parse(dtg_ShowNCC.Rows[rowindex].Cells[1].Value.ToString());
            var ncc = _service.GetAll(null).FirstOrDefault(x => x.MaNCC == _idWhenClick);
            txt_MaNCC.Text = ncc.MaNCC.ToString();
            txt_TenNCC.Text = ncc.TenNCC;
            txt_DiaChi.Text = ncc.DiaChi;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            var ncc = new NhaCungCap();
            ncc.MaNCC = int.Parse(txt_MaNCC.Text);
            ncc.TenNCC = txt_TenNCC.Text;
            ncc.DiaChi = txt_DiaChi.Text;

            var option = MessageBox.Show("Xac nhan Sua", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(ncc));
            }
            else
            {
                return;
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            var ncc = new NhaCungCap();
            ncc.MaNCC = _idWhenClick;
            var option = MessageBox.Show("Xac nhan Xoa", "Xac Nhan", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(ncc));
            }
            else
            {
                return;
            }
        }

       

       
    }
}
