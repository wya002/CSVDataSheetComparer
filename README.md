# 📒CSVDataSheetComparer
2개의 CSV 데이터 파일을 파싱하여 비교 분석하는 프로그램


--------------------------
# 📒메인화면
<img src="https://user-images.githubusercontent.com/75249093/209571341-d59d9dd2-7f61-4e06-a4e3-dbc12b11157f.png" width="600" height="400"/>


--------------------------
# 📒CSV로딩화면
<img src="https://user-images.githubusercontent.com/75249093/210582093-e29fa59e-b98f-4efb-a1c9-5de734144714.png" width="800" height="400"/>

<img src="https://user-images.githubusercontent.com/75249093/210581581-f806b878-60d3-4908-b170-d0e6b8c934d5.png" width="600" height="400"/>


--------------------------
# 📒파라미터확인화면
<img src="https://user-images.githubusercontent.com/75249093/210582742-840b8b5f-8a28-42d7-976c-0b8a12da9269.png" width="600" height="400"/>


--------------------------
# 📒차트출력화면
(temporary code)


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Chart : Form
    {
        public string attribute1, attribute2;
        public Chart
            (string y1,string y2,List<string> y,List<string> compare_y, string range3, string range4, string range7, string range8, int rowcount1, int rowcount2, string filename1, string filename2)
        {
            InitializeComponent();

            //List<double> temp_x = new List<double>();
            List<decimal> temp_y = new List<decimal>();
            //List<double> temp_compare_x = new List<double>();
            List<decimal> temp_compare_y = new List<decimal>();

            /*for(int i = x.IndexOf(x1) + rowcount1; i <= x.Count - rowcount1 + x.IndexOf(x1); i+= rowcount1)
            {
                temp_x.Add(double.Parse(x[i]));
            }*/

            for (int i = y.IndexOf(y1) + rowcount1; i <= y.Count - rowcount1 + y.IndexOf(y1); i += rowcount1)
            {
                try
                {
                    temp_y.Add(decimal.Parse(y[i]));
                }
                catch
                {
                    continue;
                }
            }
            /*for (int i = compare_x.IndexOf(x2) + rowcount2; i <= compare_x.Count - rowcount2 + compare_x.IndexOf(x2); i += rowcount2)
            {
                temp_compare_x.Add(double.Parse(compare_x[i])); 
            }*/
            //double의 값을 넘어가는 값은 예외처리
            for (int i = compare_y.IndexOf(y2) + rowcount2; i <= compare_y.Count - rowcount2 + compare_y.IndexOf(y2); i += rowcount2)
            {
                            try
                {
                    temp_compare_y.Add(decimal.Parse(compare_y[i]));
                }
                catch
                {
                    continue;
                }
            }
            for(int i = 0; i < temp_y.Count; i++)
            {
                try
                {
                    chart1.Series[0].Points.AddXY(i + 1, temp_y[i]);
                }
                catch
                {
                    continue;
                }
            }
            for(int i = 0; i < temp_compare_y.Count; i++)
            {
                try 
                {
                    chart1.Series[1].Points.AddXY(i + 1, temp_compare_y[i]);
                }
                catch
                {
                    continue;
                }
            }
            chart1.Series[0].Name = filename1+ " - " + y1;
            chart1.Series[1].Name = filename2 + " - " + y2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            ScreenCaptureForm(new Point(this.Left, this.Top), this.Size);
        }

        //차트 화면 캡처 함수
                private void ScreenCaptureForm(Point _point, Size _size)
        {
            Rectangle rectangle = new Rectangle(_point, _size);

            Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            Graphics g = Graphics.FromImage(bitmap);

            g.CopyFromScreen(rectangle.Left, rectangle.Top, 0, 0, rectangle.Size);

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Image Save";
            dlg.DefaultExt = "png";
            dlg.Filter = "png 파일(*.png)|*.png";
            string fileName = "";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName.ToString();
                bitmap.Save(fileName, ImageFormat.Png);
                bitmap.Dispose();
            }
            else
            {
                dlg.Dispose();
                dlg = null;
            }
        }

    }
}


============================
