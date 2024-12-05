using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
while (true)
            {
                string s = sr.ReadLine();
                if (string.IsNullOrEmpty(s)) break;
                int[] NS = Array.ConvertAll(s.Split(), int.Parse);
                sw.WriteLine(NS[1] / (NS[0] + 1));
            }
            sw.Flush();