using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace C_PRL.Forms
{
    public partial class BaoCao : Form
    {
        
        public BaoCao()
        {
            InitializeComponent();
            dothibaocao();
        }

        private void zed_Load(object sender, EventArgs e)
        {

        }
        public void dothibaocao()
        {
            //GraphPane myPane 
            GraphPane myPane = zed.GraphPane;

            myPane.Title.Text = "Số lượng nhập xuất";
            myPane.Title.FontSpec.Size = 14;

            myPane.XAxis.Title.Text = "Tháng";
            myPane.YAxis.Title.Text = "SL Nhập";

            PointPairList revenueData = new PointPairList();
            revenueData.Add(1, 12);
            revenueData.Add(2, 14);
            

            BarItem barItem = myPane.AddBar("Số Lượng", revenueData, Color.Blue);


            PointPairList curveDataPoints = new PointPairList();
            curveDataPoints.Add(1, 12);
            curveDataPoints.Add(2, 14);


            LineItem curve = myPane.AddCurve("Đường cong", curveDataPoints, Color.Red, SymbolType.Circle);

            // Thêm các điểm dữ liệu khác tương tự
            zed.AxisChange();
            zed.Invalidate();




        }
    }
    


}




