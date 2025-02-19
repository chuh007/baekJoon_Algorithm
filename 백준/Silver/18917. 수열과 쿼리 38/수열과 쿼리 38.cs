using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            long sum = 0;
            long xor = 0;
            for (int i = 0; i < a; i++)
            {
                long[] arr = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);
                switch (arr[0])
                {
                    case 1:
                        sum += arr[1];
                        xor ^= arr[1];
                        break;
                    case 2:
                        sum -= arr[1];
                        xor ^= arr[1];
                        break;
                    case 3:
                        sw.WriteLine(sum);
                        break;
                    default:
                        sw.WriteLine(xor);
                        break;
                }
            }
            sw.Flush();