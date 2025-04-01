using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] a = new int[4];
            int[] b = new int[2];

            for (int i = 0; i < 4; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }

            for (int i = 0; i < 2; i++)
            {
                b[i] = int.Parse(sr.ReadLine());
            }

            int scienceSum = a.Sum() - a.Min();
            int socialMax = b.Max();
            int total = scienceSum + socialMax;

            sw.Write(total);
            sw.Flush();