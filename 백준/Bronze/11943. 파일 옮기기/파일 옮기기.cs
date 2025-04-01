using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr1 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            sw.Write(Math.Min(arr1[0] + arr2[1], arr1[1] + arr2[0]));
            sw.Flush();