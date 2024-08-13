using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int wow=0;
                float[] ar = Array.ConvertAll(Console.ReadLine().Split(' '),float.Parse);
                float x1, y1, plrange1, x2, y2, plrange2, torangexy,toRangepl1, toRangepl2;
                x1 = ar[0];
                y1 = ar[1];
                plrange1 = ar[2];
                x2 = ar[3];
                y2 = ar[4];
                plrange2 = ar[5];
                torangexy = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
                toRangepl1 = (plrange1 + plrange2) * (plrange1 + plrange2);
                toRangepl2 = (plrange1 - plrange2) * (plrange1 - plrange2);
                if (x1 == x2 && y1 == y2&&plrange1==plrange2)
                {
                    wow = -1;
                }
                else if (x1 == x2 && y1 == y2)
                {
                    wow = 0;
                }
                else if (torangexy == toRangepl1 || torangexy == toRangepl2)
                {
                    wow = 1;
                }
                else if ((torangexy<toRangepl1)&&(torangexy> toRangepl2))
                {
                    wow = 2;
                }
                else
                {
                    wow = 0;
                }
                Console.WriteLine(wow);
            }
        }
    }
}
