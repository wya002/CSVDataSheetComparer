namespace CSVDataSheetComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ReceivedData1;
        public string ReceivedData2;

        private void Search_Click(object sender, EventArgs e)
        {
            Form2 f2 = new();
            f2.Owner= this;
            if (f2.ShowDialog() == DialogResult.OK )
            {
                textBox2.Text = ReceivedData1;
                textBox4.Text = ReceivedData2;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}