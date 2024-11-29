using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            for(int i = 0; i < n / 5; i++)
            {
                sw.Write("V");
            }
            for (int i = 0; i < n % 5; i++)
            {
                sw.Write("I");
            }
            sw.Flush();