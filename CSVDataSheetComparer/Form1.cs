using System.Data;

namespace CSVDataSheetComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Ȧ�� �� �� ��ȯ -> LightGray
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            //��Ʈ ũ�� ��ȯ -> 12
            dataGridView1.Font = new Font("Arial", 12, FontStyle.Regular);
            dataGridView2.Font = new Font("Arial", 12, FontStyle.Regular);

            //���� �� �� �� �� ����
            dataGridView1.TopLeftHeaderCell.Value = "num";
            dataGridView2.TopLeftHeaderCell.Value = "num";
        }

        public string ReceivedData1; // CSV ���� 1 �ּ�
        public string ReceivedData2; // CSV ���� 2 �ּ�

        public int RowNum = 0;
        public int RowNum2 = 1;

        private void Search_Click(object sender, EventArgs e)
        {
            Form2 f2 = new();
            f2.Owner= this;
            if (f2.ShowDialog() == DialogResult.OK )
            {
                //���� �� ���ε�� ������ �׸��� �� �ʱ�ȭ
                dataGridView1.Columns.Clear();
                dataGridView2.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView1.Refresh();
                dataGridView2.Refresh();

                StreamReader sr = new StreamReader(@ReceivedData1);
                StreamReader sr2 = new StreamReader(@ReceivedData2);

                string first_FileName = ReceivedData1.Substring(ReceivedData1.LastIndexOf('\\') + 1);
                string second_FileName = ReceivedData2.Substring(ReceivedData2.LastIndexOf('\\') + 1);
                label3.Text = label3.Text + " " + first_FileName;
                label4.Text = label4.Text + " " + second_FileName;

                dataGridView1.Columns.Add("Attribute", "Attribute");
                dataGridView2.Columns.Add("Attribute", "Attribute");

                string line = sr.ReadLine();
                string line2 = sr2.ReadLine();

                foreach(string cols in line.Split(','))
                {
                    dataGridView1.Rows.Add(cols);
                    RowNum += 1;
                }
                foreach(string cols in line2.Split(','))
                {
                    dataGridView2.Rows.Add(cols);
                    RowNum2 += 1;
                }
                sr.Close();
                sr2.Close();

                //�÷� ��� ���� ����
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                foreach (DataGridViewColumn column in dataGridView2.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                //default �� ���� ����
                dataGridView1.CurrentCell = null;
                dataGridView2.CurrentCell = null;

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //�� ��ȣ �Է�
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rect = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dataGridView1.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics,
                (e.RowIndex + 1).ToString(),
                dataGridView1.RowHeadersDefaultCellStyle.Font,
                rect,
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rect = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dataGridView2.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics,
                (e.RowIndex + 1).ToString(),
                dataGridView2.RowHeadersDefaultCellStyle.Font,
                rect,
                dataGridView2.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        //�����ͱ׸��� �信�� ���õ� �� �ؽ�Ʈ �ڽ��� ���
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentCell.Value.ToString();
            if(textBox2.Text != "" && textBox4.Text != "")
            {
                make_Chart.Enabled = true;
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox4.Text = dataGridView2.CurrentCell.Value.ToString();
            if (textBox2.Text != "" && textBox4.Text != "")
            {
                make_Chart.Enabled = true;
            }
        }

        private void make_Chart_Click(object sender, EventArgs e)
        {
            Form3 f3 = new(textBox2.Text, textBox4.Text, ReceivedData1, ReceivedData2, RowNum, RowNum2
                ,dataGridView1.CurrentCell.RowIndex, dataGridView2.CurrentCell.RowIndex);

            f3.ShowDialog();
        }
    }
}