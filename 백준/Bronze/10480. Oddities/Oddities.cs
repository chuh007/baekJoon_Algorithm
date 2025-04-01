using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int b = int.Parse(sr.ReadLine());
                if (b % 2 == 0) sw.WriteLine($"{b} is even");
                else sw.WriteLine($"{b} is odd");
            }
            sw.Flush();