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

namespace CSVDataSheetComparer
{
    public partial class Form4 : Form
    {
        public string attribute1, attribute2;
        public Form4(string y1, string y2, List<string[]> y, List<string[]> compare_y,
            int IndexNum, int IndexNum2, int rowcount1, int rowcount2, string filename1, string filename2)
        {
            InitializeComponent();
            List<decimal> temp_y = new List<decimal>();
            List<decimal> temp_compare_y = new List<decimal>();

            for (int i = 1; i <= y.Count()-1; i += rowcount1)
            {
                try
                {
                    temp_y.Add(decimal.Parse(y[i][IndexNum]));
                }
                catch
                {
                    continue;
                }
            }
            //double의 값을 넘어가는 값은 예외처리
            for (int i = 1; i <= compare_y.Count() - 1; i += rowcount2)
            {
                try
                {
                    temp_compare_y.Add(decimal.Parse(compare_y[i][IndexNum2]));
                }
                catch
                {
                    continue;
                }
            }
            for (int i = 0; i < temp_y.Count; i++)
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
            for (int i = 0; i < temp_compare_y.Count; i++)
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
            chart1.Series[0].Name = filename1 + " - " + y1;
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
            if (dlg.ShowDialog() == DialogResult.OK)
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
