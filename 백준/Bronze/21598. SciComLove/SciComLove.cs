using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            switch (n)
            {
                case 1:
                    sw.Write("SciComLove");
                    break;
                default:
                    sw.Write("SciComLove\nSciComLove");
                    break;
            }
            sw.Flush();