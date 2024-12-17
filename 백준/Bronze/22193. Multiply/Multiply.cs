using System.Numerics;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = sr.ReadLine();
            BigInteger a = BigInteger.Parse(sr.ReadLine());
            BigInteger b = BigInteger.Parse(sr.ReadLine());
            sw.Write(a * b);
            sw.Flush();