using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string[] arr = sr.ReadLine().Split();
sw.Write(IsSoSu(int.Parse(arr[0])) && IsSoSu(int.Parse(arr[1] + arr[0])) ? "Yes" : "No");
bool IsSoSu(int num)
{
    for(int i  = 2;i * i < num; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}
sw.Flush();