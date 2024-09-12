using System.Numerics;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
BigInteger[] a = Array.ConvertAll(sr.ReadLine().Split(), BigInteger.Parse);
            sw.WriteLine(a[0] * a[1]);
            sw.Flush();