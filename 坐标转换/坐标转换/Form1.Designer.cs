namespace 坐标转换
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大地坐标打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.大地坐标打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高斯反算打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空间直角计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大地转直角ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直角转大地ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高斯反算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.邻带换算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdb_2000 = new System.Windows.Forms.RadioButton();
            this.rdb_84 = new System.Windows.Forms.RadioButton();
            this.rdb_75 = new System.Windows.Forms.RadioButton();
            this.rdb_54 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdb_3 = new System.Windows.Forms.RadioButton();
            this.rdb_6 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(904, 121);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "点号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "B";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "L";
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "H";
            this.Column8.Name = "Column8";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(904, 121);
            this.dataGridView2.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "点号";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "X";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Y";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Z";
            this.Column7.Name = "Column7";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 17);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(904, 121);
            this.dataGridView3.TabIndex = 2;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "点号";
            this.Column9.Name = "Column9";
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "x";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "y";
            this.Column11.Name = "Column11";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "大地坐标";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(0, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(910, 141);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "空间直角坐标";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(0, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(910, 141);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "高斯平面直角坐标";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.空间直角计算ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大地坐标打开ToolStripMenuItem1,
            this.大地坐标打开ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.高斯反算打开ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 大地坐标打开ToolStripMenuItem1
            // 
            this.大地坐标打开ToolStripMenuItem1.Name = "大地坐标打开ToolStripMenuItem1";
            this.大地坐标打开ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.大地坐标打开ToolStripMenuItem1.Text = "大地坐标打开";
            this.大地坐标打开ToolStripMenuItem1.Click += new System.EventHandler(this.大地坐标打开ToolStripMenuItem1_Click);
            // 
            // 大地坐标打开ToolStripMenuItem
            // 
            this.大地坐标打开ToolStripMenuItem.Name = "大地坐标打开ToolStripMenuItem";
            this.大地坐标打开ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.大地坐标打开ToolStripMenuItem.Text = "直角坐标打开";
            this.大地坐标打开ToolStripMenuItem.Click += new System.EventHandler(this.大地坐标打开ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开ToolStripMenuItem.Text = "高斯正算打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 高斯反算打开ToolStripMenuItem
            // 
            this.高斯反算打开ToolStripMenuItem.Name = "高斯反算打开ToolStripMenuItem";
            this.高斯反算打开ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.高斯反算打开ToolStripMenuItem.Text = "高斯反算打开";
            this.高斯反算打开ToolStripMenuItem.Click += new System.EventHandler(this.高斯反算打开ToolStripMenuItem_Click);
            // 
            // 空间直角计算ToolStripMenuItem
            // 
            this.空间直角计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大地转直角ToolStripMenuItem,
            this.直角转大地ToolStripMenuItem});
            this.空间直角计算ToolStripMenuItem.Name = "空间直角计算ToolStripMenuItem";
            this.空间直角计算ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.空间直角计算ToolStripMenuItem.Text = "空间直角计算";
            // 
            // 大地转直角ToolStripMenuItem
            // 
            this.大地转直角ToolStripMenuItem.Name = "大地转直角ToolStripMenuItem";
            this.大地转直角ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.大地转直角ToolStripMenuItem.Text = "大地转直角";
            this.大地转直角ToolStripMenuItem.Click += new System.EventHandler(this.大地转直角ToolStripMenuItem_Click);
            // 
            // 直角转大地ToolStripMenuItem
            // 
            this.直角转大地ToolStripMenuItem.Name = "直角转大地ToolStripMenuItem";
            this.直角转大地ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.直角转大地ToolStripMenuItem.Text = "直角转大地";
            this.直角转大地ToolStripMenuItem.Click += new System.EventHandler(this.直角转大地ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算ToolStripMenuItem,
            this.高斯反算ToolStripMenuItem,
            this.邻带换算ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.工具ToolStripMenuItem.Text = "高斯计算";
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.计算ToolStripMenuItem.Text = "高斯正算";
            this.计算ToolStripMenuItem.Click += new System.EventHandler(this.计算ToolStripMenuItem_Click);
            // 
            // 高斯反算ToolStripMenuItem
            // 
            this.高斯反算ToolStripMenuItem.Name = "高斯反算ToolStripMenuItem";
            this.高斯反算ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.高斯反算ToolStripMenuItem.Text = "高斯反算";
            this.高斯反算ToolStripMenuItem.Click += new System.EventHandler(this.高斯反算ToolStripMenuItem_Click);
            // 
            // 邻带换算ToolStripMenuItem
            // 
            this.邻带换算ToolStripMenuItem.Name = "邻带换算ToolStripMenuItem";
            this.邻带换算ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.邻带换算ToolStripMenuItem.Text = "邻带换算";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助文档ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助文档ToolStripMenuItem
            // 
            this.帮助文档ToolStripMenuItem.Name = "帮助文档ToolStripMenuItem";
            this.帮助文档ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.帮助文档ToolStripMenuItem.Text = "帮助文档";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(935, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdb_2000);
            this.groupBox4.Controls.Add(this.rdb_84);
            this.groupBox4.Controls.Add(this.rdb_75);
            this.groupBox4.Controls.Add(this.rdb_54);
            this.groupBox4.Location = new System.Drawing.Point(0, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(678, 85);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "选择椭球";
            // 
            // rdb_2000
            // 
            this.rdb_2000.AutoSize = true;
            this.rdb_2000.Location = new System.Drawing.Point(518, 39);
            this.rdb_2000.Name = "rdb_2000";
            this.rdb_2000.Size = new System.Drawing.Size(95, 16);
            this.rdb_2000.TabIndex = 3;
            this.rdb_2000.Text = "CGCS2000椭球";
            this.rdb_2000.UseVisualStyleBackColor = true;
            // 
            // rdb_84
            // 
            this.rdb_84.AutoSize = true;
            this.rdb_84.Location = new System.Drawing.Point(350, 39);
            this.rdb_84.Name = "rdb_84";
            this.rdb_84.Size = new System.Drawing.Size(83, 16);
            this.rdb_84.TabIndex = 2;
            this.rdb_84.Text = "WGS-84椭球";
            this.rdb_84.UseVisualStyleBackColor = true;
            // 
            // rdb_75
            // 
            this.rdb_75.AutoSize = true;
            this.rdb_75.Location = new System.Drawing.Point(199, 39);
            this.rdb_75.Name = "rdb_75";
            this.rdb_75.Size = new System.Drawing.Size(95, 16);
            this.rdb_75.TabIndex = 1;
            this.rdb_75.Text = "ICGG1975椭球";
            this.rdb_75.UseVisualStyleBackColor = true;
            // 
            // rdb_54
            // 
            this.rdb_54.AutoSize = true;
            this.rdb_54.Checked = true;
            this.rdb_54.Location = new System.Drawing.Point(48, 39);
            this.rdb_54.Name = "rdb_54";
            this.rdb_54.Size = new System.Drawing.Size(119, 16);
            this.rdb_54.TabIndex = 0;
            this.rdb_54.TabStop = true;
            this.rdb_54.Text = "克拉索夫斯基椭球";
            this.rdb_54.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdb_3);
            this.groupBox5.Controls.Add(this.rdb_6);
            this.groupBox5.Location = new System.Drawing.Point(684, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 83);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "分带选择";
            // 
            // rdb_3
            // 
            this.rdb_3.AutoSize = true;
            this.rdb_3.Location = new System.Drawing.Point(28, 61);
            this.rdb_3.Name = "rdb_3";
            this.rdb_3.Size = new System.Drawing.Size(53, 16);
            this.rdb_3.TabIndex = 4;
            this.rdb_3.Text = "3度带";
            this.rdb_3.UseVisualStyleBackColor = true;
            // 
            // rdb_6
            // 
            this.rdb_6.AutoSize = true;
            this.rdb_6.Checked = true;
            this.rdb_6.Location = new System.Drawing.Point(28, 20);
            this.rdb_6.Name = "rdb_6";
            this.rdb_6.Size = new System.Drawing.Size(53, 16);
            this.rdb_6.TabIndex = 4;
            this.rdb_6.TabStop = true;
            this.rdb_6.Text = "6度带";
            this.rdb_6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 581);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdb_2000;
        private System.Windows.Forms.RadioButton rdb_84;
        private System.Windows.Forms.RadioButton rdb_75;
        private System.Windows.Forms.RadioButton rdb_54;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdb_3;
        private System.Windows.Forms.RadioButton rdb_6;
        private System.Windows.Forms.ToolStripMenuItem 高斯反算打开ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.ToolStripMenuItem 高斯反算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大地坐标打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空间直角计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大地转直角ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直角转大地ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 邻带换算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大地坐标打开ToolStripMenuItem1;
    }
}

