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
    public partial class Hang_va_Loai : Form
    {
      
        public Hang_va_Loai()
        {
            InitializeComponent();
          

            
        }


        
        private void bt_HangSX_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            bt_HangSX.BackColor = Color.Brown;
            bt_TheLoai.BackColor = DefaultBackColor;
            Hang hang = new Hang();
            hang.TopLevel = false;
            hang.FormBorderStyle = FormBorderStyle.None;
            hang.Dock = DockStyle.Fill;
            panel1.Controls.Add(hang);
            hang.Show();
            
        }

        private void bt_TheLoai_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            bt_TheLoai.BackColor = Color.Brown;
            bt_HangSX.BackColor = DefaultBackColor;
            TheLoai tl = new TheLoai();
            tl.TopLevel = false;
            tl.FormBorderStyle = FormBorderStyle.None;
            tl.Dock = DockStyle.Fill;
            panel1.Controls.Add(tl);
            tl.Show();
           

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu tt = new TrangChu();
            tt.Show();
            this.Hide();
        }

        private void bt_Hang_TheLoai_Click(object sender, EventArgs e)
        {

        }
    }
}
