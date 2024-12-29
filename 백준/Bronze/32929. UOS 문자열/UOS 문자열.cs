using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            switch (a % 3)
            {
                case 0:
                    sw.Write("S");
                    break;
                case 1:
                    sw.Write("U");
                    break;
                case 2:
                    sw.Write("O");
                    break;
            }
            sw.Flush();