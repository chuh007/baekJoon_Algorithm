using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int q = int.Parse(sr.ReadLine());
            int a = 0, b = 0;
            for(int i = 0;i<q;i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                if (input[0] > input[1]) a++;
                if (input[1] > input[0]) b++;
            }
            sw.Write($"{a} {b}");
            sw.Flush();