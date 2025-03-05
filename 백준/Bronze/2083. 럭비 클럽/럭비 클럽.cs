using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
while (true)
            {
                string[] s = sr.ReadLine().Split();
                if (s[0] == "#") break;
                
                if(int.Parse(s[1])>17 || int.Parse(s[2])>=80) sw.WriteLine($"{s[0]} Senior");
                else sw.WriteLine($"{s[0]} Junior");
            }
            sw.Flush();