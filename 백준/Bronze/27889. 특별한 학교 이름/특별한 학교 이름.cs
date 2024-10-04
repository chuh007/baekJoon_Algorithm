using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = sr.ReadLine();
            switch (s[0])
            {
                case 'N':
                    sw.Write("North London Collegiate School");
                    break;
                case 'B':
                    sw.Write("Branksome Hall Asia");
                    break;
                case 'K':
                    sw.Write("Korea International School");
                    break;
                case 'S':
                    sw.Write("St. Johnsbury Academy");
                    break;
            }
            sw.Flush();