using System.Linq;
            using System.Numerics;
            using System.Collections;
            using System.Collections.Generic;
            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int N = int.Parse(sr.ReadLine());
            int[] arr = new int[N];
            int[] rangeCount = new int[8002];
            int a = 0, b, c, d,input;
            for (int i = 0; i < N; i++)
            {
                input = int.Parse(sr.ReadLine());
                arr[i] = input;
                a += arr[i];
                rangeCount[input + 4000]++;
            }
            Array.Sort(arr);
            b = arr[arr.Length / 2];
            int max = rangeCount.Max();
            List<int> tlqkf = new List<int>();
            for(int i = 0; i < 8001; i++)
            {
                if (rangeCount[i] == max) tlqkf.Add(i-4000);
            }
            if (tlqkf.Count > 1)
            {
                tlqkf.Sort();
                c = tlqkf[1];
            }
            else c = tlqkf[0];
            d = arr.Length>1?arr[N-1]-arr[0]:0;
            sw.WriteLine((int)Math.Round((double)a / N));
            sw.WriteLine(b);
            sw.WriteLine(c);
            sw.WriteLine(d);
            sw.Flush();