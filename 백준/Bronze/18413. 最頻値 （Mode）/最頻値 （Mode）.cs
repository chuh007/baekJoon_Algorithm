using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr = new int[nm[1] + 1];
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            foreach(int i in input)
            {
                arr[i]++;
            }
            sw.Write(arr.Max());
            sw.Flush();