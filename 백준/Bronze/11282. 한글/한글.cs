using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            Console.OutputEncoding = Encoding.UTF8;
            sw.Write((char)(a + '가' - 1));
            sw.Flush();