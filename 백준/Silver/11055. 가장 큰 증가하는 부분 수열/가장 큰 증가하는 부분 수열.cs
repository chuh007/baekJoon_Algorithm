using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr = new int[a];
            for (int i = 0; i < a; i++)
            {
                arr[i] = input[i];
                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i])
                    {
                        arr[i] = arr[i] > arr[j] + input[i] ? arr[i] : arr[j] + input[i];
                    }
                }
            }
            sw.Write(arr.Max());
            sw.Flush();