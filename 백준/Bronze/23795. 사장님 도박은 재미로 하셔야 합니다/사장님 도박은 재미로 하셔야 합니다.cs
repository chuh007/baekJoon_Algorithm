using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int count = 0;
while (true)
{
    int a = int.Parse(sr.ReadLine());
    if (a == -1) break;
    count += a;
}
sw.Write(count);
sw.Flush();