using System.IO;
using System.Collections.Generic;
using System.Linq;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string[] s = sr.ReadLine().Split();
int a = int.Parse(s[0]);
if (s[1][0] == 'm') sw.Write(0);
else if (s[1][0] == 'b') sw.Write(a * 200);
else if (s[1][0] == 'c') sw.Write(a * 400);
else if (s[1][0] == 'g') sw.Write(a * 600);
else sw.Write(a * 1000);
sw.Flush();