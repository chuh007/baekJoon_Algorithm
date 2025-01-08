using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            switch (a % 8)
            {
                case 0:
                    sw.Write(2);
                    break;
                case 1:
                    sw.Write(1);
                    break;
                case 2:
                    sw.Write(2);
                    break;
                case 3:
                    sw.Write(3);
                    break;
                case 4:
                    sw.Write(4);
                    break;
                case 5:
                    sw.Write(5);
                    break;
                case 6:
                    sw.Write(4);
                    break;
                case 7:
                    sw.Write(3);
                    break;
            }
            sw.Flush();