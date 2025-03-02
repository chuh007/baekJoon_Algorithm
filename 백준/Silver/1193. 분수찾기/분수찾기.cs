using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int n = (int)Math.Ceiling((Math.Sqrt(8 * a + 1) - 1) / 2);
            int index = a - (n * (n - 1) / 2);
            int row, col;
            if (n % 2 == 0)
            {
                row = index;
                col = (n + 1) - index;
            }
            else
            {
                row = (n + 1) - index;
                col = index;
            }
            sw.WriteLine($"{row}/{col}");
            sw.Flush();