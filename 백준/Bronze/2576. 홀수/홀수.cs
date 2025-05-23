using System.IO;
using System.Collections.Generic;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
List<int> arr = new List<int>();
for(int i = 0; i < 7; i++)
{
    int a = int.Parse(sr.ReadLine());
    if (a % 2 == 1) arr.Add(a);
}
if(arr.Count == 0)
{
    sw.WriteLine(-1);
}
else
{
    sw.WriteLine(arr.Sum());
    sw.WriteLine(arr.Min());
}
sw.Close();