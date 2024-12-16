using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] NM = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Array.Sort(arr);
            long low, mid, high = 0;
            low = 0;
            high = arr[arr.Length - 1];
            while (low <= high)
            {
                mid = (low + high) / 2;
                long sum = 0;
                for(int i = 0; i < NM[0]; i++)
                {
                    sum += arr[i] - mid < 0 ? 0 : arr[i] - mid;
                }
                if (sum >= NM[1]) low = mid + 1;
                else high = mid - 1;
            }
            sw.Write(high);
            sw.Flush();