using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            long T = int.Parse(sr.ReadLine());
            long[] arr = new long[100];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 1;
            for(int i = 3; i < 100; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 3];
            }
            for(int i = 0; i < T; i++)
            {
                int a = int.Parse(sr.ReadLine());
                if (a <= 3) sw.WriteLine(1);
                else sw.WriteLine(arr[a - 1]);
            }
            sw.Flush();