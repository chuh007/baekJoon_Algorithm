using System.IO;
using System.Numerics;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
BigInteger a = BigInteger.Parse(sr.ReadLine());
            BigInteger b = BigInteger.Parse(sr.ReadLine());
            sw.Write(a + b);
            sw.Flush();