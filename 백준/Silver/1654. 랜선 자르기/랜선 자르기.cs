using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            long[] arr = new long[input[0]];
            for (int i = 0; i < input[0]; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }
            Array.Sort(arr);
            long low, high, mid = 0;
            low = 1;
            high = arr[arr.Length - 1];
            while(low <= high)
            {
                mid = (low + high) / 2;
                long sum = 0;
                foreach (int item in arr)
                {
                    sum += item / mid;
                }
                if (sum >= input[1]) low = mid + 1;
                else high = mid - 1;
            }
            sw.Write(high);
            sw.Flush();