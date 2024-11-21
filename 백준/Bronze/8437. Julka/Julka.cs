using System.Numerics;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
BigInteger a = BigInteger.Parse(sr.ReadLine());
            BigInteger b = BigInteger.Parse(sr.ReadLine());
            sw.WriteLine((a + b) / 2);
            sw.Write((a - b) / 2);
            sw.Flush();