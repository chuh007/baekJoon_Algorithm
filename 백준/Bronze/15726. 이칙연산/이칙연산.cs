using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
decimal[] arr = Array.ConvertAll(sr.ReadLine().Split(), decimal.Parse);
            sw.Write(arr[0] * arr[1] / arr[2] > arr[0] / arr[1] * arr[2] ? (int)(arr[0] * arr[1] / arr[2]) : (int)(arr[0] / arr[1] * arr[2]));
            sw.Flush();