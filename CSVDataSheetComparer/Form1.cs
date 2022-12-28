using System.Data;

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

        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        private void Search_Click(object sender, EventArgs e)
        {
            Form2 f2 = new();
            f2.Owner= this;
            if (f2.ShowDialog() == DialogResult.OK )
            {
                StreamReader sr = new StreamReader(@ReceivedData1);
                StreamReader sr2 = new StreamReader(@ReceivedData2);

                dataGridView1.Columns.Add("Attribute", "Attribute");
                dataGridView2.Columns.Add("Attribute", "Attribute");

                string line = sr.ReadLine();
                string line2 = sr2.ReadLine();

                foreach(string cols in line.Split(','))
                {
                    dataGridView1.Rows.Add(cols);
                }
                foreach(string cols in line2.Split(','))
                {
                    dataGridView2.Rows.Add(cols);
                }
                sr.Close();
                sr2.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}