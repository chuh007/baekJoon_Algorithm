using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
sw.Write(arr[0] > arr[1] ? arr[1] * 2 + 1 : arr[0] * 2 - 1);
sw.Flush();