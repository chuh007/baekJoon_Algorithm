using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = { 1, 1, 2, 2, 2, 8 };
            int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            for (int i = 0; i < arr.Length; i++)
            {
                sw.Write((arr[i] - input[i]) + " ");
            }
            sw.Flush();