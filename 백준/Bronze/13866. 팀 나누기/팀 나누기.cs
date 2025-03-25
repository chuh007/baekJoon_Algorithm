using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            Array.Sort(arr);
            sw.Write(Math.Max(arr[0] + arr[3] - (arr[1] + arr[2]), arr[1] + arr[2] - (arr[0] + arr[3])));
            sw.Flush();