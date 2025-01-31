using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
int count = 0;
for(int i = 0; i < a; i++)
{
    string s = sr.ReadLine();
    if(s.Contains("OI") || s.Contains("01")) count++;
}
sw.WriteLine(count);
sw.Flush();