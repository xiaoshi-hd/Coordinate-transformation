using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 坐标转换
{
    class zhijiao
    {
        public static void zhijiao_dadi(out double X, out double Y, out double Z, double B, double L, double H, double a, double e1)
        {
            double N = a / Math.Sqrt(1 - e1 * Math.Sin(B) * Math.Sin(B));//法线长
            X = (N + H) * Math.Cos(B) * Math.Cos(L);
            Y = (N + H) * Math.Cos(B) * Math.Sin(L);
            Z = (N * (1 - e1) + H) * Math.Sin(B);
        }
        public static void dadi_zhijiao(out double B, out double L, out double  H, double X, double Y, double Z, double a, double e1)
        {
            double B0, B1, Bs;//迭代初值,TAN B0
            double N;
            //L = Math.Atan(Y / X);//L的值域为-90~90度
            L = Math.Atan2(Y, X);//atan2值域为-180~180度，可以很好地表示反正切值
            if (L < 0)
            {
                L = Math.PI * 2 + L;
            }

            B0 = Z / Math.Sqrt(X * X + Y * Y);
            do
            {
                B1 = (Z + a * e1 * B0 /Math.Sqrt(1 + (1 - e1) * B0 * B0)) / Math.Sqrt(X * X + Y * Y);
                Bs = B1 - B0;
                B0 = B1;
            }
            while (Math.Abs(Bs) > Math.Tan(Caculates.dmstohudu(0.00000001)));//限差为0.0001秒
            B = Math.Atan(B1);

            N = a / Math.Sqrt(1 - e1 * Math.Sin(B) * Math.Sin(B));
            H = Math.Sqrt(X * X + Y * Y) / Math.Cos(B) - N;

            L = Caculates.hudutodms(L);
            B = Caculates.hudutodms(B);
        }
    }
}
