using System.IO;
using System.Collections.Generic;
using System.Linq;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string[] s1 = sr.ReadLine().Split();
string[] s2 = sr.ReadLine().Split();
string[] s3 = sr.ReadLine().Split();
string[] s4 = sr.ReadLine().Split();
string[] s5 = sr.ReadLine().Split();
string[] s6 = sr.ReadLine().Split();
string[] s7 = sr.ReadLine().Split();
Dictionary<string,int> dict = new Dictionary<string, int>
{
    { s1[0], int.Parse(s1[1]) },
    { s2[0], int.Parse(s2[1]) },
    { s3[0], int.Parse(s3[1]) },
    { s4[0], int.Parse(s4[1]) },
    { s5[0], int.Parse(s5[1]) },
    { s6[0], int.Parse(s6[1]) },
    { s7[0], int.Parse(s7[1]) }
};
var a = dict.OrderByDescending(x => x.Value).First();
sw.Write(a.Key);
sw.Flush();