using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            if (a <= 50 && b <= 10)
            {
                sw.Write("White");
            }
            else if (b > 30)
            {
                sw.Write("Red");
            }
            else sw.Write("Yellow");
            sw.Flush();