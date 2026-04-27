using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                string s = sr.ReadLine();
                sw.WriteLine($"{i+1}. {s}");
            }
            sw.Flush();