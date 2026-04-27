using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            sw.WriteLine(a * b);
            sw.Flush();