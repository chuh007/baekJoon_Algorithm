using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
for(int i = 0; i < input[1];i++)
{
    if (input[0] % 2 == 0) input[0] = (input[0] / 2) ^ 6;
    else input[0] = (input[0] * 2) ^ 6;
}
sw.WriteLine(input[0]);
sw.Close();