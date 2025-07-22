using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
string answer = "";
for(int i = 0; i < a; i++)
{
    string s = sr.ReadLine();
    if(s.Contains("S"))
    {
        answer = s;
    }
}
sw.WriteLine(answer);
sw.Flush();