using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
sw.WriteLine($"{arr[2] / arr[1]} {arr[2] % arr[1]}");
sw.Flush();