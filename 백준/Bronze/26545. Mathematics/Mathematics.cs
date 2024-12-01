using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                int input = int.Parse(sr.ReadLine());
                sum += input;
            }
            sw.Write(sum);
            sw.Flush();