using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                string[] input = sr.ReadLine().Split();
                for(int j = 0; j < int.Parse(input[0]); j++)
                {
                    sw.Write(input[1]);
                }
                sw.WriteLine();
            }
            sw.Flush();