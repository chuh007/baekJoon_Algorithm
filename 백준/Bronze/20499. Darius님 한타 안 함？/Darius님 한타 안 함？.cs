using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split('/'), int.Parse);
            if (arr[0] + arr[2] < arr[1]||arr[1]==0) sw.Write("hasu");
            else sw.Write("gosu");
            sw.Flush();