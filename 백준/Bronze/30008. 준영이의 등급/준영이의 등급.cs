using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
foreach(int i in input)
{
    int num = i * 100 / arr[0];
    if (num < 5) sw.Write("1 ");
    else if (num < 12) sw.Write("2 ");
    else if (num < 24) sw.Write("3 ");
    else if (num < 41) sw.Write("4 ");
    else if (num < 61) sw.Write("5 ");
    else if (num < 78) sw.Write("6 ");
    else if (num < 90) sw.Write("7 ");
    else if (num < 97) sw.Write("8 ");
    else sw.Write("9 ");
}
sw.Flush();