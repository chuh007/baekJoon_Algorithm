using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = sr.ReadLine();
            switch (s[0])
            {
                case 'M':
                    sw.Write("MatKor");
                    break;
                case 'W':
                    sw.Write("WiCys");
                    break;
                case 'C':
                    sw.Write("CyKor");
                    break;
                case 'A':
                    sw.Write("AlKor");
                    break;
                case '$':
                    sw.Write("$clear");
                    break;
            }
            sw.Flush();