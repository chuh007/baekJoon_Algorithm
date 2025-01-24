using System.IO;
using System.Collections.Generic;
using System.Linq;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
sw.WriteLine(a/10);
sw.Flush();