using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    sw.Write("*");
                }
                sw.WriteLine();
            }
            sw.Flush();