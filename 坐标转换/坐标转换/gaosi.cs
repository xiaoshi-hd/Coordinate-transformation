using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 坐标转换
{
    class gaosi
    {
        public static void zhengsuan(out double x, out double y, double B, double L,double a, double e1, double e2, int k)
        {
            //公式精确到0.001米
            double a0, a2, a4, a6, a8;
            double m0, m2, m4, m6, m8;
            double yita2, t, N;
            double X;//子午线弧长
            double l,L0;//经差以及中央子午线
            double n;// 辅助量
            double daihao;//带号
            #region 判断分带
            if (k == 1)//6度带
            {
                if (L % 6 == 0)
                {
                    daihao = (int)(L / 6);
                    L0 = 6 * daihao - 3;
                }
                else 
                {
                    daihao = (int)(L / 6) + 1;
                    L0 = 6 * daihao - 3;
                }
            }
            else //3度带
            {
                if ((L - 1.5) % 3 == 0)
                {
                    daihao = (int)((L - 1.5) / 3);//int 强制类型转换返回最接近0的整数部分，-0.1 返回 0，0.1 返回 0
                    L0 = 3 * daihao;
                }
                else 
                {
                    daihao = (int)Math.Floor((L - 1.5) / 3) + 1;//math.floor 返回原类型小于原数值的整数部分-0.1 返回 -1， 0.1 返回 0
                    L0 = 3 * daihao;
                }
            }
            #endregion
            l = Caculates.dmstohudu(L) - Caculates.dmstohudu(L0);
            B = Caculates.dmstohudu(B);
            //L = Caculates.dmstohudu(L);
            #region 计算子午线弧长
            m0 = a * (1 - e1);
            m2 = 3 * e1 * m0 / 2;
            m4 = 5 * e1 * m2 / 4;
            m6 = 7 * e1 * m4 / 6;
            m8 = 9 * e1 * m6 / 8;

            a0 = m0 + m2 / 2 + 3 * m4 / 8 + 5 * m6 / 16 + 35 * m8 / 128;
            a2 = m2 / 2 + m4 / 2 + 15 * m6 / 32 + 7 * m8 / 16;
            a4 = m4 / 8 + 3 * m6 / 16 + 7 * m8 / 32;
            a6 = m6 / 32 + m8 / 16;
            a8 = m8 / 128;
            //子午线弧长计算公式2
            X = a0 * B - a2 * Math.Sin(2 * B) / 2 + a4 * Math.Sin(4 * B) / 4 - a6 * Math.Sin(6 * B) / 6 + a8 * Math.Sin(8 * B) / 8;
            //MessageBox.Show(X.ToString());
            #endregion 
            yita2 = e2 * Math.Cos(B) * Math.Cos(B);//η平方
            t = Math.Tan(B);
            N = a / Math.Sqrt(1 - e1 * Math.Sin(B) * Math.Sin(B));
            #region 计算高斯平面坐标
            n = Math.Cos(B) * l;
            x = X + N * t * (n * n / 2 + Math.Pow(n, 4) * (5 - t * t + 9 * yita2 + 4 * yita2 * yita2) / 24 + Math.Pow(n, 6) * (61 - 58 * t * t + Math.Pow(t, 4)) / 720);
            y = N * (n + Math.Pow(n, 3) * (1 - t * t + yita2) / 6 + Math.Pow(n, 5) * (5 - 18 * t * t + Math.Pow(t, 4) + 14 * yita2 - 58 * yita2 * t * t) / 120);
            y = y + 500000 + daihao * 1000000;//计算高斯通用坐标
            //MessageBox.Show(x.ToString());
            //MessageBox.Show(y.ToString());       
            #endregion  
        }
        public static void fansuan(out double B, out double L, double x, double y, double a, double e1, double e2, int k)
        {
            //公式精确到0.0001"
            double a0, a2, a4, a6, a8;
            double m0, m2, m4, m6, m8;
            double Bfs,Bf0,Bfi,FBf;//定义迭代变量
            double tf, yitaf2, Nf, Vf;
            double l, L0;//经差以及中央子午线
            double daihao;//带号
            daihao = (int)(y / 1000000);
            y = y - daihao * 1000000 - 500000;
            #region 判断分带
            if (k == 1)//6度带
            {
                L0 = 6 * daihao - 3;
            }
            else //3度带
            {
                L0 = 3 * daihao;
            }
            //MessageBox.Show(L0.ToString());
            #endregion 
            #region 求底点纬度
            m0 = a * (1 - e1);
            m2 = 3 * e1 * m0 / 2;
            m4 = 5 * e1 * m2 / 4;
            m6 = 7 * e1 * m4 / 6;
            m8 = 9 * e1 * m6 / 8;

            a0 = m0 + m2 / 2 + 3 * m4 / 8 + 5 * m6 / 16 + 35 * m8 / 128;
            a2 = m2 / 2 + m4 / 2 + 15 * m6 / 32 + 7 * m8 / 16;
            a4 = m4 / 8 + 3 * m6 / 16 + 7 * m8 / 32;
            a6 = m6 / 32 + m8 / 16;
            a8 = m8 / 128;
            //底点纬度 当x = X时，x轴上点的纬度,用子午线弧长的公式倒推迭代出来
            Bf0 = x / a0;
            do 
            {
                FBf = - a2 * Math.Sin(2 * Bf0) / 2 + a4 * Math.Sin(4 * Bf0) / 4 - a6 * Math.Sin(6 * Bf0) / 6 + a8 * Math.Sin(8 * Bf0) / 8;
                Bfi = (x - FBf) / a0;
                Bfs = Bfi - Bf0;
                Bf0 = Bfi;
            }
            while (Math.Abs(Bfs) > Caculates.dmstohudu(0.0000001));
            #endregion
            #region 求经纬度
            yitaf2 = e2 * Math.Cos(Bfi) * Math.Cos(Bfi);
            tf = Math.Tan(Bfi);
            Nf = a / Math.Sqrt(1 - e1 * Math.Sin(Bfi) * Math.Sin(Bfi));
            Vf = Math.Sqrt(1 + e2 * Math.Cos(Bfi) * Math.Cos(Bfi));

            B = Bfi - Vf * Vf * tf * (Math.Pow((y / Nf),2) - (5 + 3 * tf * tf + yitaf2 - 9 * yitaf2 * tf * tf) * Math.Pow((y / Nf), 4) / 12 + (61 + 90 * tf * tf + 45 * tf * tf) * Math.Pow((y / Nf),6) / 360) / 2;
            l = (y / Nf - (1 + 2 * tf * tf + yitaf2) * Math.Pow((y / Nf), 3) / 6 + (5 + 28 * tf * tf + 24 * Math.Pow(tf, 4) + 6 * yitaf2 + 8 * yitaf2 * tf * tf) * Math.Pow((y / Nf), 5) / 120) / Math.Cos(Bfi);
            B = Caculates.hudutodms(B);
            L = Caculates.hudutodms(l + Caculates.dmstohudu(L0));
            #endregion
        }
    }
}
