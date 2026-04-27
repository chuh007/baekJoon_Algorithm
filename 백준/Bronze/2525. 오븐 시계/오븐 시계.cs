using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int a = input[0];
            int b = input[1];
            int c = int.Parse(sr.ReadLine());
            b += c;
            if (b >= 60)
            {
                a += b / 60;
                b = b % 60;
                if (a > 23)
                {
                    a -= 24;
                }
            }
            sw.WriteLine($"{a} {b}");
            sw.Flush();