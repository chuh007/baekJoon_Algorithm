using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] a1a0 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int c = int.Parse(sr.ReadLine());
            int n0 = int.Parse(sr.ReadLine());
            if (a1a0[0] * n0 + a1a0[1] <= c * n0 && a1a0[0] <=c)
            {
                sw.Write(1);
            }
            else
            {
                sw.Write(0);
            }
            sw.Flush();