using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            if (arr[0] + arr[1] + arr[2] > 99) sw.Write("OK");
            else if (arr[0] <= arr[1] && arr[0] <= arr[2])
                sw.Write("Soongsil");
            else if (arr[1] <= arr[0] && arr[1] <= arr[2])
                sw.Write("Korea");
            else sw.Write("Hanyang");
            sw.Flush();