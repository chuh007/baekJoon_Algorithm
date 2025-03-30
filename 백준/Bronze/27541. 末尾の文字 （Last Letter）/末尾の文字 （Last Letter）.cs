using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            string input = sr.ReadLine();
            if (input.EndsWith("G"))
            {
                input = input.Substring(0, a - 1);
            }
            else
            {
                input += "G";
            }
            sw.WriteLine(input);
            sw.Flush();