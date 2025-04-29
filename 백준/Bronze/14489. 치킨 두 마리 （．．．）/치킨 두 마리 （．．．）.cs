using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int a = int.Parse(sr.ReadLine());
            sw.Write(arr[0] + arr[1] >= a * 2 ? arr[0] + arr[1] - a * 2 : arr[0] + arr[1]);
            sw.Flush();