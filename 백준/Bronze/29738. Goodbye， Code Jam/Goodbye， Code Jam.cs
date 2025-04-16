using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0;i<a;i++)
            {
                sw.Write($"Case #{i + 1}: ");
                int b = int.Parse(sr.ReadLine());
                if (b <= 25) sw.WriteLine("World Finals");
                else if (b <= 1000) sw.WriteLine("Round 3");
                else if (b <= 4500) sw.WriteLine("Round 2");
                else sw.WriteLine("Round 1");
            }
            sw.Flush();