using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int num = 0, answer = 0;
for(int i = 0; i < input[0]; i++)
{
    int count = 0;
    for (int j = 0; j < input[1]; j++)
    {
        if (arr[num] == 0) count++;
        num++;
    }
    if (count < input[2]) answer++;
}
sw.Write(answer);
sw.Flush();