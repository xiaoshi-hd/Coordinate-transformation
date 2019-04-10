using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 坐标转换
{
    public partial class Form1 : Form
    {
        double a, b, c, f, e1, e2;//基本椭球参数
        int k;
        //double x1, y1, B1, L1, H1, X1, Y1, Z1;//作为输出参数
        List<double> B = new List<double>();
        List<double> L = new List<double>();
        List<double> H = new List<double>();
        List<double> X = new List<double>();
        List<double> Y = new List<double>();
        List<double> Z = new List<double>();
        List<double> x = new List<double>();
        List<double> y = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }
        public void chushihua()
        {
            if (rdb_54.Checked)
            {
                a = 6378245;//长半轴
                //b = 6356863.018773;//短半轴
                //b = a * (1 - f);
                //c = 6399698.90178271;//极曲率半径
                //c = Math.Pow(a, 2) / b;
                //f = 1 / 298.3;//扁率
                //f = (a - b) / a;
                e1 = 0.0066934216230;//第一偏心率的平方
                //e1 = Math.Pow(Math.Sqrt(a * a - b * b) / a,2);
                e2 = 0.0067385254147;//第二偏心率的平方
                //e2 = Math.Pow(Math.Sqrt(a * a - b * b) / b,2);
            }
            else if (rdb_75.Checked)
            {
                a = 6378140;
                //b = 6356755.288157;
                //c = 6399596.65198801;
                //f = 1 / 298.257;
                e1 = 0.0066943849996;
                e2 = 0.0067395018195;
            }
            else if (rdb_84.Checked)
            {
                a = 6378137;
                //b = 6356752.314245;
                //c = 6399596.625758;
                //f = 1 / 298.257223563;
                e1 = 0.006694379990;
                e2 = 0.006739496742;
            }
            else if (rdb_2000.Checked)
            {
                a = 6378137;
                //b = 6356752.314140;
                //c = 6399596.625864;
                //f = 1 / 298.207222101;
                e1 = 0.006694380022;
                e2 = 0.006739496775;
            }
            B.Clear();//作用是每次执行计算时，就把变量清空，可以进行连续计算
            L.Clear();
            H.Clear();
            X.Clear();
            Y.Clear();
            Z.Clear();
            x.Clear();
            y.Clear();
        }
        private void 大地坐标打开ToolStripMenuItem1_Click(object sender, EventArgs e)//大地坐标打开
        {
            dataGridView1.Rows.Clear();
            openFileDialog1.Title = "文件打开";
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                    {
                        int i = 0;
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            dataGridView1.Rows.Add();
                            string[] str = sr.ReadLine().Split(',');
                            dataGridView1.Rows[i].Cells[0].Value = i + 1;
                            dataGridView1.Rows[i].Cells[1].Value = str[0];
                            dataGridView1.Rows[i].Cells[2].Value = str[1];
                            dataGridView1.Rows[i].Cells[3].Value = str[2];
                            i++;
                        }
                    }
                }
                else
                {

                }
            }
        }

        private void 大地坐标打开ToolStripMenuItem_Click(object sender, EventArgs e)//空间直角坐标打开
        {
            dataGridView2.Rows.Clear();
            openFileDialog1.Title = "文件打开";
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                    {
                        int i = 0;
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            dataGridView2.Rows.Add();
                            string[] str = sr.ReadLine().Split(',');
                            dataGridView2.Rows[i].Cells[0].Value = i + 1;
                            dataGridView2.Rows[i].Cells[1].Value = str[0];
                            dataGridView2.Rows[i].Cells[2].Value = str[1];
                            dataGridView2.Rows[i].Cells[3].Value = str[2];
                            i++;
                        }
                    }
                }
                else
                {

                }
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)//高斯正算打开
        {
            dataGridView1.Rows.Clear();
            openFileDialog1.Title = "文件打开";
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                    {
                        int i = 0;
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            dataGridView1.Rows.Add();
                            string[] str = sr.ReadLine().Split(',');
                            dataGridView1.Rows[i].Cells[0].Value = i + 1;
                            dataGridView1.Rows[i].Cells[1].Value = str[0];
                            dataGridView1.Rows[i].Cells[2].Value = str[1];
                            i++;
                        }
                    }
                }
                else
                { 
                
                }
            }
        }
        private void 高斯反算打开ToolStripMenuItem_Click(object sender, EventArgs e)//高斯反算打开
        {
            dataGridView3.Rows.Clear();
            openFileDialog1.Title = "文件打开";
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                    {
                        int i = 0;
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            dataGridView3.Rows.Add();
                            string[] str = sr.ReadLine().Split(',');
                            dataGridView3.Rows[i].Cells[0].Value = i + 1;
                            dataGridView3.Rows[i].Cells[1].Value = str[0];
                            dataGridView3.Rows[i].Cells[2].Value = str[1];
                            i++;
                        }
                    }
                }
                else
                {

                }
            }
        }

        private void 计算ToolStripMenuItem_Click(object sender, EventArgs e)//高斯正算
        {
            chushihua();
            dataGridView3.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            #region 判断分带
            if (rdb_6.Checked)
            {
                k = 1;
            }
            else
            {
                k = -1;
            }
            #endregion
            #region 高斯正算
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double x1, y1;
                //数据导入
                B.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value));
                L.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value));
                //计算
                gaosi.zhengsuan(out x1, out y1, B[i], L[i], a, e1, e2, k);
                //数据导出
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].Cells[0].Value = i + 1;
                dataGridView3.Rows[i].Cells[1].Value = x1;
                dataGridView3.Rows[i].Cells[2].Value = y1;
            }
            
            //double B1 = 0, L1 = 0,X1 = 0;//子午线弧长计算方法1
            //B1 = Caculates.dmstohudu(Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value)) * 180 / Math.PI;
            //L1 = Caculates.dmstohudu(Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value)) * 180 / Math.PI;
            //X1 = 111134.8611 * B1 - (32005.779 * Math.Sin(B) + 133.9238 * Math.Pow(Math.Sin(B), 3) + 0.6973 * Math.Pow(Math.Sin(B), 5) + 0.0039 * Math.Pow(Math.Sin(B), 7)) * Math.Cos(B1);
            #endregion
        }



        private void 高斯反算ToolStripMenuItem_Click(object sender, EventArgs e)//高斯反算
        {
            chushihua();
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            #region 判断分带
            if (rdb_6.Checked)
            {
                k = 1;
            }
            else
            {
                k = -1;
            }
            #endregion
            #region 高斯反算
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                double B1, L1;
                //数据导入
                x.Add(Convert.ToDouble(dataGridView3.Rows[i].Cells[1].Value));
                y.Add(Convert.ToDouble(dataGridView3.Rows[i].Cells[2].Value));
                //计算
                gaosi.fansuan(out B1, out L1, x[i], y[i], a, e1, e2, k);
                //数据导出
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = B1;
                dataGridView1.Rows[i].Cells[2].Value = L1;
            }
            #endregion
        }

        private void 大地转直角ToolStripMenuItem_Click(object sender, EventArgs e)//大地转直角
        {
            chushihua();
            dataGridView2.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            #region 计算
            for (int i = 0; i < dataGridView1.Rows.Count; i++ )
            {
                B.Add(Caculates.dmstohudu(Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value)));
                L.Add(Caculates.dmstohudu(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)));
                H.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value));

                double X1, Y1, Z1;
                zhijiao.zhijiao_dadi(out X1, out Y1, out Z1, B[i], L[i], H[i], a, e1);

                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = i + 1;
                dataGridView2.Rows[i].Cells[1].Value = X1;
                dataGridView2.Rows[i].Cells[2].Value = Y1;
                dataGridView2.Rows[i].Cells[3].Value = Z1;
            }
            #endregion
        }

        private void 直角转大地ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chushihua();
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            #region 计算
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                X.Add(Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value));
                Y.Add(Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value));
                Z.Add(Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value));

                double B1, L1, H1;
                zhijiao.dadi_zhijiao(out B1, out L1, out H1, X[i], Y[i], Z[i], a, e1);

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = B1;
                dataGridView1.Rows[i].Cells[2].Value = L1;
                dataGridView1.Rows[i].Cells[3].Value = H1;
            }
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
