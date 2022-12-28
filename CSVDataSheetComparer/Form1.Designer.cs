namespace CSVDataSheetComparer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.make_Chart = new System.Windows.Forms.Button();
            this.Base = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.base_y = new System.Windows.Forms.Label();
            this.base_x = new System.Windows.Forms.Label();
            this.Comparing = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comparing_y = new System.Windows.Forms.Label();
            this.comparing_x = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Base.SuspendLayout();
            this.Comparing.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(614, 1064);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(944, 101);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(614, 1064);
            this.dataGridView2.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(24, 101);
            this.Search.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(240, 147);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(24, 1019);
            this.Exit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(240, 147);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // make_Chart
            // 
            this.make_Chart.Enabled = false;
            this.make_Chart.Location = new System.Drawing.Point(24, 264);
            this.make_Chart.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.make_Chart.Name = "make_Chart";
            this.make_Chart.Size = new System.Drawing.Size(240, 147);
            this.make_Chart.TabIndex = 4;
            this.make_Chart.Text = "Make Chart";
            this.make_Chart.UseVisualStyleBackColor = true;
            // 
            // Base
            // 
            this.Base.Controls.Add(this.textBox2);
            this.Base.Controls.Add(this.textBox1);
            this.Base.Controls.Add(this.base_y);
            this.Base.Controls.Add(this.base_x);
            this.Base.Location = new System.Drawing.Point(24, 427);
            this.Base.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Base.Name = "Base";
            this.Base.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Base.Size = new System.Drawing.Size(240, 261);
            this.Base.TabIndex = 5;
            this.Base.TabStop = false;
            this.Base.Text = "DataSheet1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 144);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(174, 39);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(174, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Cell Number";
            // 
            // base_y
            // 
            this.base_y.AutoSize = true;
            this.base_y.Location = new System.Drawing.Point(10, 157);
            this.base_y.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.base_y.Name = "base_y";
            this.base_y.Size = new System.Drawing.Size(39, 32);
            this.base_y.TabIndex = 1;
            this.base_y.Text = "y :";
            // 
            // base_x
            // 
            this.base_x.AutoSize = true;
            this.base_x.Location = new System.Drawing.Point(10, 80);
            this.base_x.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.base_x.Name = "base_x";
            this.base_x.Size = new System.Drawing.Size(38, 32);
            this.base_x.TabIndex = 0;
            this.base_x.Text = "x :";
            // 
            // Comparing
            // 
            this.Comparing.Controls.Add(this.textBox4);
            this.Comparing.Controls.Add(this.textBox3);
            this.Comparing.Controls.Add(this.comparing_y);
            this.Comparing.Controls.Add(this.comparing_x);
            this.Comparing.Location = new System.Drawing.Point(24, 704);
            this.Comparing.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Comparing.Name = "Comparing";
            this.Comparing.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Comparing.Size = new System.Drawing.Size(240, 261);
            this.Comparing.TabIndex = 6;
            this.Comparing.TabStop = false;
            this.Comparing.Text = "DataSheet2";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(50, 144);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(174, 39);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 72);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(174, 39);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Cell Number";
            // 
            // comparing_y
            // 
            this.comparing_y.AutoSize = true;
            this.comparing_y.Location = new System.Drawing.Point(10, 157);
            this.comparing_y.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.comparing_y.Name = "comparing_y";
            this.comparing_y.Size = new System.Drawing.Size(39, 32);
            this.comparing_y.TabIndex = 3;
            this.comparing_y.Text = "y :";
            // 
            // comparing_x
            // 
            this.comparing_x.AutoSize = true;
            this.comparing_x.Location = new System.Drawing.Point(10, 80);
            this.comparing_x.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.comparing_x.Name = "comparing_x";
            this.comparing_x.Size = new System.Drawing.Size(38, 32);
            this.comparing_x.TabIndex = 2;
            this.comparing_x.Text = "x :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1104, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "DataSheet1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(940, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "DataSheet2 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1200);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comparing);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.make_Chart);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV DataSheet Comparer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Base.ResumeLayout(false);
            this.Base.PerformLayout();
            this.Comparing.ResumeLayout(false);
            this.Comparing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button make_Chart;
        private System.Windows.Forms.GroupBox Base;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label base_y;
        private System.Windows.Forms.Label base_x;
        private System.Windows.Forms.GroupBox Comparing;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label comparing_y;
        private System.Windows.Forms.Label comparing_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}