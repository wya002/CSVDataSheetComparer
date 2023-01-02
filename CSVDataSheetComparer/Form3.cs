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

        public Form3(string y1, string y2, string path1, string path2, int num1, int num2)
        {
            InitializeComponent();

            textBox2.Text = y1;
            textBox4.Text = y2;

            first_path = path1;
            second_path = path2;

            RowNum = num1;
            RowNum2 = num2;

            List<string[]> list = new();
            List<string[]> list2 = new();

            StreamReader sr = new(@first_path);
            StreamReader sr2 = new(second_path);

            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string line2 = sr2.ReadLine();

                string[] data = line.Split(',');
                string[] data2 = line2.Split(',');]

                list.Add(data);
                list2.Add(data2);
            }

            textBox5.Text = "1";
            textBox6.Text = (list.Count-1).ToString();
            textBox7.Text = list[1][list.IndexOf()];
            textBox8.Text = list[list.Count() - 1][0];

            textBox9.Text = "1";
            textBox10.Text = (list2.Count - 1).ToString();
            textBox11.Text = list2[1][0];
            textBox12.Text = list2[list2.Count() - 1][0];

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
