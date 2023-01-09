using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CSVDataSheetComparer
{
    public partial class Form3 : Form
    {
        public string recievedData1;
        public string recievedData2;

        public string first_path;
        public string second_path;

        public int RowNum;
        public int RowNum2;

        public int IndexNum;
        public int IndexNum2;

        public List<string[]> list = new();
        public List<string[]> list2 = new();

        public string first_y;
        public string second_y;

        public Form3(string y1, string y2, string path1, string path2, int num1, int num2, int index1, int index2)
        {
            InitializeComponent();

            first_y= y1;
            second_y= y2;

            textBox2.Text = y1;
            textBox4.Text = y2;

            first_path = path1;
            second_path = path2;

            RowNum = num1;
            RowNum2 = num2;

            IndexNum = index1;
            IndexNum2 = index2;

            StreamReader sr = new(@first_path);
            StreamReader sr2 = new(second_path);

            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string line2 = sr2.ReadLine();

                string[] data = line.Split(',');
                string[] data2 = line2.Split(',');

                list.Add(data);
                list2.Add(data2);
            }

            //Base 값
            textBox5.Text = "1";
            textBox6.Text = (list.Count-1).ToString();
            textBox7.Text = list[1][IndexNum];
            textBox8.Text = list[list.Count() - 1][IndexNum];

            //Comparing 값
            textBox9.Text = "1";
            textBox10.Text = (list2.Count - 1).ToString();
            textBox11.Text = list2[1][IndexNum2];
            textBox12.Text = list2[list2.Count() - 1][IndexNum2];
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyChart_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(first_y, second_y, list, list2, IndexNum, IndexNum2, RowNum, RowNum2, first_path, second_path);
            f4.ShowDialog();
        }
    }
}
