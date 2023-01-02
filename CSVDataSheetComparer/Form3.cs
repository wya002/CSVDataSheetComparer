using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVDataSheetComparer
{
    public partial class Form3 : Form
    {
        public string recievedData1;
        public string recievedData2;

        public Form3(string y1, string y2)
        {
            InitializeComponent();

            textBox2.Text = y1;
            textBox4.Text = y2;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
