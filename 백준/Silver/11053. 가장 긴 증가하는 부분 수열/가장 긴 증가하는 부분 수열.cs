using System.Collections.Generic;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr = new int[a];
            arr[0] = 1;
            for (int i = 1; i < a; i++)
            {
                int max = 1;
                for(int j = 0; j < i; j++)
                {
                    if(input[j] < input[i])
                    {
                        max = max > arr[j] ? max : arr[j] + 1;
                    }
                }
                arr[i] = max;
            }
            sw.Write(arr.Max());
            sw.Flush();