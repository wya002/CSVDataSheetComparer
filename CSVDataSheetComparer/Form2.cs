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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\Downloads";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textSheet1.Text = ofd.FileName;
            }
            if(textSheet2.Text != null)
            {
                applyButton.Enabled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.InitialDirectory = "C:\\Downloads";
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                textSheet2.Text = ofd2.FileName;
            }
            if (textSheet1.Text != null)
            {
                applyButton.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Form1 f1 = (Form1) Owner;
            f1.ReceivedData1 = textSheet1.Text;
            f1.ReceivedData2 = textSheet2.Text;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
