using System.IO;
using System.Collections.Generic;
using System.Linq;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
int b = int.Parse(sr.ReadLine());
if (a < 2)
    sw.WriteLine("Before");
else
{
    if (a == 2 && b < 18)
        sw.WriteLine("Before");
    else if (a == 2 && b == 18)
        sw.WriteLine("Special");
    else sw.WriteLine("After");
}
sw.Flush();