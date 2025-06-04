using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            if(a < 30)
            {
                sw.Write($"{(float)a / 2:F1}");

            }
            else
            {
                sw.Write($"{(float)(a - 30) * 1.5f + 15f:F1}");
            }
            sw.Flush();