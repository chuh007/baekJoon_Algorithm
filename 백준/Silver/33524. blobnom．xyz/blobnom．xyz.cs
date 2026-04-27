using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr1 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Array.Sort(arr1);
            for(int i = 0; i < input[1]; i++)
            {
                int low = 0;
                int high = arr1.Length - 1;
                while(low <= high)
                {
                    int middle = (low + high) / 2;
                    if (arr1[middle] > arr2[i])
                    {
                        high = middle - 1;
                    }
                    else
                    {
                        low = middle + 1;
                    }
                }
                if (low == 0) sw.Write("0 ");
                else sw.Write($"{(int)((1 + Math.Sqrt((4 * (long)low - 1) / 3.0)) / 2)} ");
            }
            sw.Flush();