using System.IO;
using System.Collections.Generic;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
float[] arr = new float[a];
for(int i = 0; i < a; i++)
{
    arr[i] = float.Parse(sr.ReadLine());
}
arr = arr.OrderBy(x => x).ToArray();
sw.WriteLine($"{arr[1]:0.00}");
sw.Flush();