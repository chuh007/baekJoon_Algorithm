using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
bool isSampleWrong = false, isSystemWrong = false;
for(int i = 0; i < arr[0]; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    if (input[0] != input[1]) isSampleWrong = true;
}
for (int i = 0; i < arr[1]; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    if (input[0] != input[1]) isSystemWrong = true;
}
sw.Write(isSampleWrong ? "Wrong Answer" : isSystemWrong ? "Why Wrong!!!" : "Accepted");
sw.Flush();