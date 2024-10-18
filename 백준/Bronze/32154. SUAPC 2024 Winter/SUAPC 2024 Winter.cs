using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            switch (n)
            {
                case 1:
                    sw.WriteLine(11);
                    sw.Write("A B C D E F G H J L M");
                    break;
                case 2:
                    sw.WriteLine(9);
                    sw.Write("A C E F G H I L M");
                    break;
                case 3:
                    sw.WriteLine(9);
                    sw.Write("A C E F G H I L M");
                    break;
                case 4:
                    sw.WriteLine(9);
                    sw.Write("A B C E F G H L M");
                    break;
                case 5:
                    sw.WriteLine(8);
                    sw.Write("A C E F G H L M");
                    break;
                case 6:
                    sw.WriteLine(8);
                    sw.Write("A C E F G H L M");
                    break;
                case 7:
                    sw.WriteLine(8);
                    sw.Write("A C E F G H L M");
                    break;
                case 8:
                    sw.WriteLine(8);
                    sw.Write("A C E F G H L M");
                    break;
                case 9:
                    sw.WriteLine(8);
                    sw.Write("A C E F G H L M");
                    break;
                case 10:
                    sw.WriteLine(8);
                    sw.Write("A B C F G H L M");
                    break;
            }
            sw.Flush();