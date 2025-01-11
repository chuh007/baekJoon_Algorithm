using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int b = int.Parse(sr.ReadLine());
                for(int j = 0; j < b / 5; j++)
                {
                    sw.Write("++++ ");
                }
                for(int j = 0; j < b % 5; j++)
                {
                    sw.Write("|");
                }
                sw.WriteLine();
            }
            sw.Flush();