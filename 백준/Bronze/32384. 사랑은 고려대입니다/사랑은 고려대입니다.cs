using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            for(int i = 0; i < n; i++)
            {
                sw.Write("LoveisKoreaUniversity ");
            }
            sw.Flush();